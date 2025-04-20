using System;
using System.Drawing;
using System.Drawing.Printing;
using RafiReceiptsApp.Models; // for Receipt

public class ReceiptPrinter
{
    private readonly Receipt _receipt;

    public ReceiptPrinter(Receipt receipt)
    {
        _receipt = receipt;
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

        // Use the margin bounds (will be full width now)
        var area = e.MarginBounds;
        float left = area.Left;
        float width = area.Width;
        float y = area.Top;

        // Fonts
        var headerFont = new Font("Arial", 16, FontStyle.Bold);
        var labelFont = new Font("Arial", 10, FontStyle.Regular);
        var valueFont = new Font("Arial", 10, FontStyle.Bold);
        var boxFont = new Font("Arial", 14, FontStyle.Bold);

        // StringFormat for wrapping
        var wrapFmt = new StringFormat(StringFormatFlags.LineLimit)
        {
            Trimming = StringTrimming.Word,
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Near
        };

        // 1) Header centered
        var hdr = "RMC";
        var hdrSize = g.MeasureString(hdr, headerFont);
        g.DrawString(hdr, headerFont, Brushes.Black,
            new RectangleF(left, y, width, hdrSize.Height),
            new StringFormat { Alignment = StringAlignment.Center });
        y += hdrSize.Height + 8;

        // --- after drawing "RMC" and advancing y ---

        // 2) Print ID centered under the header
        string idText = $"ID: {_receipt.Id}";
        SizeF idSize = g.MeasureString(idText, labelFont);
        float xId = (width - idSize.Width) / 2;
        g.DrawString(idText, labelFont, Brushes.Black, xId, y);

        // Advance past the ID
        y += idSize.Height + 5;

        // 2) Line
        g.DrawLine(Pens.Black, left, y, left + width, y);
        y += 10;

        // Helper to draw wrapped label/value
        void Field(string label, string value)
        {
            var labSize = g.MeasureString(label + ":", labelFont);
            g.DrawString(label + ":", labelFont, Brushes.Black, left, y);

            var valRect = new RectangleF(
                left + labSize.Width + 5,
                y,
                width - labSize.Width - 5,
                labSize.Height * 4
            );
            g.DrawString(value, valueFont, Brushes.Black, valRect, wrapFmt);

            // Advance by actual height used
            var used = g.MeasureString(value, valueFont, (int)valRect.Width);
            y += Math.Max(labSize.Height, used.Height) + 6;
        }

        // 3) Receipt Type in box
        {
            var txt = _receipt.TokenType;
            var ts = g.MeasureString(txt, boxFont);
            float pad = 6;
            var boxW = ts.Width + pad * 2;
            var boxH = ts.Height + pad * 2;
            var boxX = left + (width - boxW) / 2;
            var boxR = new RectangleF(boxX, y, boxW, boxH);

            g.DrawRectangle(Pens.Black, boxR.X, boxR.Y, boxR.Width, boxR.Height);
            g.DrawString(txt, boxFont, Brushes.Black, boxR,
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            y += boxH + 8;
        }

        // 4) USG type if present
        if (_receipt.TokenType == "USG" && !string.IsNullOrWhiteSpace(_receipt.USGType))
            Field("USG Type", _receipt.USGType);

        // 5) Other fields
        Field("Patient Name", _receipt.PatientName);
        Field("Address", _receipt.Address);

        if (!string.IsNullOrWhiteSpace(_receipt.Temperature))
            Field("Temperature", _receipt.Temperature);

        if (!string.IsNullOrWhiteSpace(_receipt.BloodPressure))
            Field("BP", _receipt.BloodPressure);

        Field("Fee", _receipt.Fee.ToString("F2"));

        // 6) Queue Number in box
        {
            var txt = _receipt.QueueNumber.ToString();
            var ts = g.MeasureString(txt, boxFont);
            float pad = 6;
            var boxW = ts.Width + pad * 2;
            var boxH = ts.Height + pad * 2;
            var boxX = left + (width - boxW) / 2;
            var boxR = new RectangleF(boxX, y, boxW, boxH);

            g.DrawRectangle(Pens.Black, boxR.X, boxR.Y, boxR.Width, boxR.Height);
            g.DrawString(txt, boxFont, Brushes.Black, boxR,
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            y += boxH + 8;
        }


        // 7) Date/Time
        Field("Date", _receipt.CreatedAt.ToString("g"));

        // Advance past the ID
        y += idSize.Height + 5;

        // 3) Draw a horizontal line
        g.DrawLine(Pens.Black, left, y, left + width, y);
        y += 5;

        e.HasMorePages = false;
    }
}
