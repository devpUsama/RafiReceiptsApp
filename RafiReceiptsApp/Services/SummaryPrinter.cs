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
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);

            // Optionally, configure printer settings here.

            printDoc.Print();
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics!;
            float leftMargin = 10;
            float rightMargin = 10;
            float topMargin = 10;
            float yPos = topMargin;
            float pageWidth = e.PageBounds.Width;
            float availableWidth = pageWidth - (leftMargin + rightMargin);

            // Define fonts.
            Font headerFont = new Font("Arial", 20, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 14, FontStyle.Bold);
            Font detailFont = new Font("Arial", 12, FontStyle.Regular);

            // Define a StringFormat for text wrapping.
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Near;
            sf.Trimming = StringTrimming.EllipsisCharacter;

            // 1. Print Header: "RMC" centered.
            string header = "RMC";
            SizeF headerSize = g.MeasureString(header, headerFont);
            float xHeader = (pageWidth - headerSize.Width) / 2;
            g.DrawString(header, headerFont, Brushes.Black, xHeader, yPos);
            yPos += headerSize.Height + 10;

            // 2. Print Date or Month line.
            string dateLine;
            if (_summaryType.Equals("Daily", StringComparison.OrdinalIgnoreCase))
            {
                dateLine = $"Date: {_summaryDate.ToShortDateString()}";
            }
            else // for monthly summary
            {
                dateLine = $"Month: {_summaryDate.ToString("MMMM yyyy")}";
            }
            SizeF dateSize = g.MeasureString(dateLine, subHeaderFont);
            g.DrawString(dateLine, subHeaderFont, Brushes.Black, new RectangleF(leftMargin, yPos, availableWidth, dateSize.Height), sf);
            yPos += dateSize.Height + 5;

            // 3. Print Generation Timestamp.
            string generatedLine = $"Generated at: {_generatedAt.ToString("g")}";
            SizeF genSize = g.MeasureString(generatedLine, detailFont);
            g.DrawString(generatedLine, detailFont, Brushes.Black, new RectangleF(leftMargin, yPos, availableWidth, genSize.Height), sf);
            yPos += genSize.Height + 10;

            // 4. Draw a horizontal line.
            g.DrawLine(Pens.Black, leftMargin, yPos, pageWidth - rightMargin, yPos);
            yPos += 5;

            // 5. Print the Summary Details.
            // Use DrawString with a rectangle to wrap the text.
            RectangleF summaryRect = new RectangleF(leftMargin, yPos, availableWidth, e.PageBounds.Height - yPos - 20); // leave some bottom margin
            g.DrawString(_summaryDetails, detailFont, Brushes.Black, summaryRect, sf);

            // We assume all content fits on one page.
            e.HasMorePages = false;
        }
    }
}
