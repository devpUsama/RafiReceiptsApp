using System;
using System.Drawing;
using System.Drawing.Printing;

namespace RafiReceiptsApp.Services
{
    public class SummaryPrinter
    {
        private readonly string _summaryType; // "Daily" or "Monthly"
        private readonly DateTime _summaryDate; // For daily: DateTime.Today; for monthly: any date in the desired month
        private readonly string _summaryDetails;
        private readonly DateTime _generatedAt;

        public SummaryPrinter(string summaryType, DateTime summaryDate, string summaryDetails)
        {
            _summaryType = summaryType;
            _summaryDate = summaryDate;
            _summaryDetails = summaryDetails;
            _generatedAt = DateTime.Now; // Timestamp when the print job is generated.
        }

        public void Print()
        {
            PrintDocument printDoc = new PrintDocument();

            // 1) Set margins to zero
            printDoc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

            // 2) Define a custom paper size of 3" wide (300 hundredths of an inch)
            //    height can be large—printer will cut at end of content.
            PaperSize ps = new PaperSize("Custom", 300, 20000);
            printDoc.DefaultPageSettings.PaperSize = ps;

            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);

            // Optionally, configure printer settings here.

            printDoc.Print();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics!;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Respect printer non-printable edges with a safe padding
            var area = e.MarginBounds;
            const float safePad = 12f; // increase if right-edge still clips
            float left = area.Left + safePad;
            float width = Math.Max(8f, area.Width - safePad * 2f);
            float top = area.Top;
            float bottom = area.Bottom;
            float y = top;

            float sectionSpacing = 10f;
            float lineSpacing = 6f;

            using (var centerFmt = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            using (var leftTopFmt = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Near })
            using (var wrapFmt = new StringFormat(StringFormatFlags.LineLimit)
            {
                Trimming = StringTrimming.EllipsisCharacter,
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            })
            // Fonts chosen to match patient receipt style
            using (var headerFont = new Font("Georgia", 16, FontStyle.Bold))
            using (var subHeaderFont = new Font("Segoe UI", 9, FontStyle.Regular))
            using (var sectionTitleFont = new Font("Segoe UI", 10, FontStyle.Bold))
            using (var detailFont = new Font("Segoe UI", 10, FontStyle.Regular))
            using (var verseFont = new Font("Segoe UI", 9, FontStyle.Italic))
            {
                // Helper to safely get strings
                static string S(object? o) => o?.ToString() ?? string.Empty;

                // Helper: draw dotted separator
                void DrawDashedLine(float yPos)
                {
                    using var pen = new Pen(Color.Black, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot };
                    g.DrawLine(pen, left, yPos, left + width, yPos);
                }

                // Helper: measure wrapped text
                SizeF MeasureWrapped(string text, Font f, float maxWidth) =>
                    string.IsNullOrEmpty(text) ? SizeF.Empty : g.MeasureString(text, f, new SizeF(maxWidth, float.MaxValue), wrapFmt);

                // Header: hospital name, address, generation time
                string hospitalName = "Rafi Medical Complex";
                string hospitalAddress = "Vehari Road Hasilpur Old";
                string generatedAt = $"Generated at: {_generatedAt:g}";

                var hSize = g.MeasureString(hospitalName, headerFont);
                g.DrawString(hospitalName, headerFont, Brushes.Black, new RectangleF(left, y, width, hSize.Height), centerFmt);
                y += hSize.Height + 4;

                var addrSize = g.MeasureString(hospitalAddress, subHeaderFont);
                g.DrawString(hospitalAddress, subHeaderFont, Brushes.Black, new RectangleF(left, y, width, addrSize.Height), centerFmt);
                y += addrSize.Height + 6;

                var genSize = g.MeasureString(generatedAt, subHeaderFont);
                g.DrawString(generatedAt, subHeaderFont, Brushes.Black, new RectangleF(left, y, width, genSize.Height), centerFmt);
                y += genSize.Height + sectionSpacing;

                // Summary title (Daily / Monthly)
                string summaryTitle = _summaryType?.Equals("Daily", StringComparison.OrdinalIgnoreCase) == true
                    ? "Daily Summary"
                    : "Monthly Summary";
                var stSize = g.MeasureString(summaryTitle, sectionTitleFont);
                g.DrawString(summaryTitle, sectionTitleFont, Brushes.Black, new RectangleF(left, y, width, stSize.Height), centerFmt);
                y += stSize.Height + sectionSpacing;

                DrawDashedLine(y); y += 8;

                // A small "Summary Info" heading (centered)
                string infoHeading = "Summary Info";
                var infoSize = g.MeasureString(infoHeading, sectionTitleFont);
                g.DrawString(infoHeading, sectionTitleFont, Brushes.Black, new RectangleF(left, y, width, infoSize.Height), centerFmt);
                y += infoSize.Height + 6;

                // Draw the summary details. Allow wrapped lines and prevent overflow.
                // We treat _summaryDetails as possibly multi-line text (newline separated).
                var lines = (_summaryDetails ?? string.Empty)
                    .Replace("\r\n", "\n")
                    .Replace('\r', '\n')
                    .Split('\n');

                foreach (var rawLine in lines)
                {
                    // Skip empty leading/trailing
                    string line = rawLine?.Trim();
                    if (string.IsNullOrEmpty(line))
                    {
                        // add a small blank line
                        y += detailFont.GetHeight(g) + lineSpacing;
                        if (y > bottom - 60) break;
                        continue;
                    }

                    // Measure wrapped height for this line
                    var needed = MeasureWrapped(line, detailFont, width);
                    float available = bottom - 60 - y; // reserve footer space (~60px)

                    if (needed.Height <= available)
                    {
                        // Draw directly
                        var rect = new RectangleF(left, y, width, needed.Height);
                        g.DrawString(line, detailFont, Brushes.Black, rect, wrapFmt);
                        y += needed.Height + lineSpacing;
                    }
                    else
                    {
                        // Need to truncate to fit remaining space - approximate by shrinking text
                        // We'll binary-search for a substring length that fits into available height.
                        int lo = 0, hi = line.Length;
                        string fitted = string.Empty;

                        while (lo < hi)
                        {
                            int mid = (lo + hi) / 2;
                            string probe = line.Substring(0, mid).TrimEnd() + "...";
                            var probeSize = MeasureWrapped(probe, detailFont, width);
                            if (probeSize.Height <= Math.Max(0, available))
                            {
                                lo = mid + 1;
                                fitted = probe;
                            }
                            else
                            {
                                hi = mid;
                            }
                        }

                        if (string.IsNullOrEmpty(fitted))
                        {
                            // If nothing fits, just append "..." and draw a single short line
                            fitted = line.Length > 10 ? line.Substring(0, 10).TrimEnd() + "..." : line;
                        }

                        var rect = new RectangleF(left, y, width, MeasureWrapped(fitted, detailFont, width).Height);
                        g.DrawString(fitted, detailFont, Brushes.Black, rect, wrapFmt);
                        y += rect.Height + lineSpacing;

                        // We have filled the printable area; stop here to avoid overflow.
                        break;
                    }

                    // Safeguard: if we are dangerously near bottom, stop rendering further lines
                    if (y > bottom - 80) // leave space for footer and final separator
                        break;
                }

                // Footer separator and message
                DrawDashedLine(y); y += 8;
                string footer = "Thank you for your Service";
                var footerSize = g.MeasureString(footer, verseFont);
                g.DrawString(footer, verseFont, Brushes.Black, new RectangleF(left, y, width, footerSize.Height), centerFmt);
                y += footerSize.Height + 6;

                DrawDashedLine(y);

                // Single page only in this implementation
                e.HasMorePages = false;
            }
        }

    }
}
