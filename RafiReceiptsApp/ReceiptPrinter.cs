using RafiReceiptsApp.Models; // Ensure this matches your actual namespace
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;

public class ReceiptPrinter
{
    private readonly Receipt _receipt;
    private readonly bool _isReprint;

    public ReceiptPrinter(Receipt receipt, bool isReprint = false)
    {
        _receipt = receipt;
        _isReprint = isReprint;
    }

    public void Print()
    {
        var printDoc = new PrintDocument();

        // 1) Set margins to zero
        printDoc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

        // 2) Define a custom paper size of 3" wide (300 hundredths of an inch)
        //    height can be large—printer will cut at end of content.
        PaperSize ps = new PaperSize("Custom", 300, 20000);
        printDoc.DefaultPageSettings.PaperSize = ps;

        // 3) Handle PrintPage
        printDoc.PrintPage += PrintPage;

        // 4) Send to the printer
        printDoc.Print();
    }

    private void PrintPage(object sender, PrintPageEventArgs e)
    {
        Graphics g = e.Graphics!;
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

        // Use margin bounds but apply a SAFE padding so we never draw into the printer's non-printable edge
        var area = e.MarginBounds;
        const float safePad = 12f;
        float left = area.Left + safePad;
        float width = Math.Max(8f, area.Width - safePad * 2f);
        float y = area.Top + safePad;

        // Ensure GDI+ objects are properly disposed to prevent memory leaks in production
        using var headerFont = new Font("Arial", 16, FontStyle.Bold);
        using var labelFont = new Font("Arial", 10, FontStyle.Regular);
        using var valueFont = new Font("Arial", 10, FontStyle.Bold);
        using var boxFont = new Font("Arial", 14, FontStyle.Bold);

        using var centerFmt = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
        using var wrapFmt = new StringFormat(StringFormatFlags.LineLimit)
        {
            Trimming = StringTrimming.Word,
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Near
        };

        // --- 1) Header centered ---
        string hdr = "RMC";
        var hdrSize = g.MeasureString(hdr, headerFont);
        g.DrawString(hdr, headerFont, Brushes.Black, new RectangleF(left, y, width, hdrSize.Height), centerFmt);
        y += hdrSize.Height + 8;

        // --- 2) Print ID centered under the header ---
        string idText = $"ID: {_receipt.Id}"; // Removed ?. here
        SizeF idSize = g.MeasureString(idText, labelFont);
        g.DrawString(idText, labelFont, Brushes.Black, new RectangleF(left, y, width, idSize.Height), centerFmt);
        y += idSize.Height + 5;

        // --- 3) Reprint Watermark (if applicable) ---
        if (_isReprint)
        {
            using var watermarkFont = new Font("Arial", 10, FontStyle.Bold);
            string reprintText = "*** REPRINT ***";
            var wmSize = g.MeasureString(reprintText, watermarkFont);
            g.DrawString(reprintText, watermarkFont, Brushes.Black, new RectangleF(left, y, width, wmSize.Height), centerFmt);
            y += wmSize.Height + 5;
        }

        // --- 4) Line Separator ---
        g.DrawLine(Pens.Black, left, y, left + width, y);
        y += 10;

        // --- Helper to draw wrapped label/value safely ---
        void Field(string label, string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return;

            var labSize = g.MeasureString(label + ":", labelFont);
            g.DrawString(label + ":", labelFont, Brushes.Black, left, y);

            float valLeft = left + labSize.Width + 5;
            float valWidth = width - labSize.Width - 5;

            // Calculate height needed for the wrapped value
            var used = g.MeasureString(value, valueFont, new SizeF(valWidth, float.MaxValue), wrapFmt);

            var valRect = new RectangleF(valLeft, y, valWidth, used.Height);
            g.DrawString(value, valueFont, Brushes.Black, valRect, wrapFmt);

            y += Math.Max(labSize.Height, used.Height) + 6;
        }

        // --- Helper to draw boxed values (Tokens/Queue numbers) ---
        void DrawBox(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return;

            var ts = g.MeasureString(text, boxFont);
            float pad = 6;

            // Math.Min ensures the box never exceeds the paper width
            float boxW = Math.Min(width, ts.Width + pad * 2);
            float boxH = ts.Height + pad * 2;
            float boxX = left + (width - boxW) / 2;
            var boxR = new RectangleF(boxX, y, boxW, boxH);

            g.DrawRectangle(Pens.Black, boxR.X, boxR.Y, boxR.Width, boxR.Height);
            g.DrawString(text, boxFont, Brushes.Black, boxR, centerFmt);
            y += boxH + 8;
        }

        // --- 5) Receipt Type in box ---
        DrawBox(_receipt.TokenType);

        // --- 6) USG type if present ---
        if (string.Equals(_receipt.TokenType, "USG", StringComparison.OrdinalIgnoreCase) &&
            !string.IsNullOrWhiteSpace(_receipt.USGType))
        {
            Field("USG Type", _receipt.USGType);
        }

        // --- 7) Other fields ---
        Field("Patient Name", _receipt.PatientName);
        Field("Address", _receipt.Address);
        Field("Temperature", _receipt.Temperature);
        Field("BP", _receipt.BloodPressure);

        Field("Fee", _receipt.Fee.ToString("F2")); // Removed ?. here

        // --- 8) Queue Number in box ---
        DrawBox(_receipt.QueueNumber.ToString()); // Removed ?. here

        // --- 9) Date/Time ---
        // Fallback to current time if CreatedAt is somehow default
        string dateStr = _receipt.CreatedAt != default ? _receipt.CreatedAt.ToString("g") : DateTime.Now.ToString("g"); // Removed ?. here
        Field("Date", dateStr);

        // --- 10) Final horizontal line ---
        y += 5; // Extra padding before the line
        g.DrawLine(Pens.Black, left, y, left + width, y);
        y += 5;

        e.HasMorePages = false;
    }
}