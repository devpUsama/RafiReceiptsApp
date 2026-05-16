using RafiReceiptsApp.Models; // for Receipt
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
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

        // Use margin bounds but apply a SAFE padding so we never draw into the printer's non-printable edge
        var area = e.MarginBounds;
        const float safePad = 12f;                  // <- ADJUST this if clipping persists (8..20 typical)
        float left = area.Left + safePad;
        float width = Math.Max(8f, area.Width - safePad * 2f);
        float top = area.Top;
        float bottom = area.Bottom;
        float y = top;

        // spacing & fonts (dispose with using)
        float sectionSpacing = 10f;
        float interLineSpacing = 6f;
        float boxPad = 8f;

        using (var centerFmt = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
        using (var leftTopFmt = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near })
        using (var wrapFmt = new StringFormat(StringFormatFlags.LineLimit)
        {
            Trimming = StringTrimming.Word,
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Near
        })

        // Fonts: header reduced, patient fields bumped slightly
        using (var headerFont = new Font("Georgia", 16, FontStyle.Bold))        // reduced size (was 18)
        using (var headerSubFont = new Font("Segoe UI", 9, FontStyle.Regular))
        using (var sectionTitleFont = new Font("Segoe UI", 9, FontStyle.Bold)) // "Patient Visit Receipt"
        using (var labelFont = new Font("Segoe UI", 9, FontStyle.Regular))     // bumped +1
        using (var valueFont = new Font("Segoe UI", 10, FontStyle.Bold))        // bumped +2
        using (var boxFont = new Font("Consolas", 17, FontStyle.Bold))
        using (var verseFont = new Font("Segoe UI", 9, FontStyle.Italic))
        {
            static string S(object? o) => o?.ToString() ?? string.Empty;

            // Helper to measure wrapped text
            SizeF MeasureWrapped(Graphics g2, string text, Font f, float maxWidth, StringFormat fmt)
                => string.IsNullOrEmpty(text) ? SizeF.Empty : g2.MeasureString(text, f, new SizeF(maxWidth, float.MaxValue), fmt);

            void DrawDashedLine(float yPos)
            {
                using var pen = new Pen(Color.Black, 1) { DashStyle = DashStyle.Dot };
                g.DrawLine(pen, left, yPos, left + width, yPos);
            }

            

            // Header: Hospital name & address
            string hospitalName = "Rafi Medical Complex";
            string hospitalAddress = "Vehari Road Hasilpur Old";
            string smallInfo = DateTime.Now.ToString("g");

            // Draw hospital name (smaller so no clipping)
            var hSize = g.MeasureString(hospitalName, headerFont);
            g.DrawString(hospitalName, headerFont, Brushes.Black, new RectangleF(left, y, width, hSize.Height), centerFmt);
            y += hSize.Height + 4;

            // Address
            var addrSize = g.MeasureString(hospitalAddress, headerSubFont);
            g.DrawString(hospitalAddress, headerSubFont, Brushes.Black, new RectangleF(left, y, width, addrSize.Height), centerFmt);
            y += addrSize.Height + 6;

            // Date/time (centered)
            var infoSize = g.MeasureString(smallInfo, headerSubFont);
            g.DrawString(smallInfo, headerSubFont, Brushes.Black, left + (width - infoSize.Width) / 2f, y);
            y += infoSize.Height + 6;

            // New centered section title
            string sectionTitle = "Patient Visit Receipt";
            var stSize = g.MeasureString(sectionTitle, sectionTitleFont);
            g.DrawString(sectionTitle, sectionTitleFont, Brushes.Black, new RectangleF(left, y, width, stSize.Height), centerFmt);
            y += stSize.Height + sectionSpacing;

            if (_isReprint)
            {
                using (var watermarkFont = new Font("Arial", 10, FontStyle.Bold))
                {
                    string reprintText = "*** REPRINT ***";
                    var wmSize = g.MeasureString(reprintText, watermarkFont);
                    g.DrawString(reprintText, watermarkFont, Brushes.Black, new RectangleF(left, y, width, wmSize.Height), centerFmt);
                    y += wmSize.Height + 10; // Add some space below it
                }
            }

            // Section separator
            DrawDashedLine(y); y += 6;


            // --- ADD HERE: Token section heading ---
            string tokenSectionTitle = "Token Info:";
            var tokenSectionSize = g.MeasureString(tokenSectionTitle, sectionTitleFont);
            g.DrawString(tokenSectionTitle, sectionTitleFont, Brushes.Black, new RectangleF(left, y, width, tokenSectionSize.Height), leftTopFmt);
            y += tokenSectionSize.Height + 6;

            // Big token queue number box (centered)
            string tokenTxt = S(_receipt?.QueueNumber);
            if (!string.IsNullOrWhiteSpace(tokenTxt))
            {
                var ts = g.MeasureString(tokenTxt, boxFont);
                float boxW = Math.Min(width, ts.Width + boxPad * 2f);
                float boxH = ts.Height + boxPad * 2f;
                float boxX = left + (width - boxW) / 2f;
                var boxRect = new RectangleF(boxX, y, boxW, boxH);

                using (var pen = new Pen(Color.Black, 1) { DashStyle = DashStyle.Dot })
                    g.DrawRectangle(pen, boxRect.X, boxRect.Y, boxRect.Width, boxRect.Height);

                // center text safely inside boxRect
                g.DrawString(tokenTxt, boxFont, Brushes.Black, boxRect, centerFmt);
                y += boxH + 8;
            }

            // Two-column "label : value" helper (value right-aligned)
            void FieldRight(string label, string value)
            {
                if (string.IsNullOrEmpty(value)) return;
                float leftCol = width * 0.55f;
                float rightCol = width - leftCol;

                var lSize = g.MeasureString(label + ":", labelFont);
                var vSize = MeasureWrapped(g, value, valueFont, rightCol, wrapFmt);

                float rowHeight = Math.Max(lSize.Height, vSize.Height);

                // If row overflows bottom, truncate value to fit remaining space
                if (y + rowHeight > bottom - 20)
                {
                    float remaining = Math.Max(0, bottom - 20 - y);
                    // truncate with simple substring fallback
                    while (vSize.Height > remaining && value.Length > 0)
                    {
                        value = value.Substring(0, Math.Max(0, value.Length - 4)).TrimEnd() + "...";
                        vSize = MeasureWrapped(g, value, valueFont, rightCol, wrapFmt);
                    }
                    rowHeight = Math.Max(lSize.Height, vSize.Height);
                }

                // draw label & value (value right-aligned within its column)
                g.DrawString(label + ":", labelFont, Brushes.Black, new RectangleF(left, y, leftCol, rowHeight), leftTopFmt);
                var measuredVal = g.MeasureString(value, valueFont, new SizeF(rightCol, rowHeight), wrapFmt);
                float valX = left + leftCol + (rightCol - measuredVal.Width);
                g.DrawString(value, valueFont, Brushes.Black, new RectangleF(valX, y, measuredVal.Width, measuredVal.Height), leftTopFmt);

                y += rowHeight + interLineSpacing;
            }

            // Token fields
            FieldRight("Visit For", S(_receipt?.TokenType));

            // NEW: If USG token, print its subcategory (USGType) in the token section as requested
            if (string.Equals(S(_receipt?.TokenType), "USG", StringComparison.OrdinalIgnoreCase) &&
                !string.IsNullOrWhiteSpace(S(_receipt?.USGType)))
            {
                FieldRight("USG Type", S(_receipt?.USGType));
            }

            FieldRight("Token ID", S(_receipt?.Id));
            FieldRight("Fee", _receipt != null ? _receipt.Fee.ToString("F2") : "0.00");

            DrawDashedLine(y); y += sectionSpacing;

            // --- ADD HERE: Patient section heading ---
            string patientSectionTitle = "Patient Info:";
            var patientSectionSize = g.MeasureString(patientSectionTitle, sectionTitleFont);
            g.DrawString(patientSectionTitle, sectionTitleFont, Brushes.Black, new RectangleF(left, y, width, patientSectionSize.Height), leftTopFmt);
            y += patientSectionSize.Height + 6;

            // Patient section (label left, wrapped value right)
            void FieldWrapped(string label, string value)
            {
                if (string.IsNullOrEmpty(value)) return;
                float labelCol = width * 0.30f;
                float valueCol = width - labelCol;

                var lSize = g.MeasureString(label + ":", labelFont);
                var vSize = MeasureWrapped(g, value, valueFont, valueCol, wrapFmt);
                float rowHeight = Math.Max(lSize.Height, vSize.Height);

                if (y + rowHeight > bottom - 20)
                {
                    float remaining = Math.Max(0, bottom - 20 - y);
                    while (vSize.Height > remaining && value.Length > 0)
                    {
                        value = value.Substring(0, Math.Max(0, value.Length - 4)).TrimEnd() + "...";
                        vSize = MeasureWrapped(g, value, valueFont, valueCol, wrapFmt);
                    }
                    rowHeight = Math.Max(lSize.Height, vSize.Height);
                }

                g.DrawString(label + ":", labelFont, Brushes.Black, new RectangleF(left, y, labelCol, rowHeight), leftTopFmt);
                g.DrawString(value, valueFont, Brushes.Black, new RectangleF(left + labelCol, y, valueCol, rowHeight), wrapFmt);

                y += rowHeight + interLineSpacing;
            }

            // Patient fields (value font is slightly larger now)
            FieldWrapped("Patient Name", S(_receipt?.PatientName));
            FieldWrapped("Address", S(_receipt?.Address));
            FieldWrapped("Temperature", S(_receipt?.Temperature));
            FieldWrapped("BP", S(_receipt?.BloodPressure));

            DrawDashedLine(y); y += sectionSpacing;

            // Footer: verse (centered)
            string verse = "\"And when I am ill, it is He who cures me.\"";
            var verseSize = MeasureWrapped(g, verse, verseFont, width, wrapFmt);
            if (y + verseSize.Height > bottom - 10)
            {
                // truncate to fit
                while (verseSize.Height > Math.Max(0, bottom - 10 - y) && verse.Length > 0)
                {
                    verse = verse.Substring(0, Math.Max(0, verse.Length - 6)).TrimEnd() + "...";
                    verseSize = MeasureWrapped(g, verse, verseFont, width, wrapFmt);
                }
            }
            g.DrawString(verse, verseFont, Brushes.Black, new RectangleF(left, y, width, verseSize.Height), centerFmt);
            y += verseSize.Height + 6;

            DrawDashedLine(y);
            e.HasMorePages = false;
        }
    }
}
