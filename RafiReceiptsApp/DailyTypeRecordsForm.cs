using RafiReceiptsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RafiReceiptsApp
{
    public partial class DailyTypeRecordsForm : Form
    {

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check for F2 to submit
            if (keyData == Keys.F2)
            {
                // Perform the click for the save/generate button.
                btnPrintSummary.PerformClick();
                return true;
            }
            // Check for F3 to cancel
            else if (keyData == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private readonly string _tokenType;

        public DailyTypeRecordsForm(string tokenType)
        {
            InitializeComponent();
            _tokenType = tokenType;
            lblTitle.Text = $"{_tokenType} Records for {DateTime.Today:yyyy-MM-dd}";

            // Make grid read-only
            dgvRecords.ReadOnly = true;
            dgvRecords.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;

            Load += DailyTypeRecordsForm_Load;
        }

        private void DailyTypeRecordsForm_Load(object? sender, EventArgs e)
        {
            LoadRecords();
        }

        private List<Receipt> _todayList = new List<Receipt>();
        private void LoadRecords()
        {
            using var ctx = new ApplicationDbContext();
            var today = DateTime.Today;
            _todayList = ctx.Receipts
                           .Where(r => r.TokenType == _tokenType
                                    && r.CreatedAt.Date == today)
                           .OrderBy(r => r.QueueNumber)
                           .ToList();

            dgvRecords.DataSource = _todayList;

            // Update summary labels
            int count = _todayList.Count;
            decimal sum = _todayList.Sum(r => r.Fee);

            lblTokenCount.Text = $"Total Tokens: {count}";
            lblTotalAmount.Text = $"Total Amount: {sum:C}";
        }

        private void btnPrintSummary_Click(object? sender, EventArgs e)
        {
            var pd = new PrintDocument();
            // 1) Set margins to zero
            pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

            // 2) Define a custom paper size of 3" wide (300 hundredths of an inch)
            //    height can be large—printer will cut at end of content.
            PaperSize ps = new PaperSize("Custom", 300, 20000);
            pd.DefaultPageSettings.PaperSize = ps;
            pd.PrintPage += PrintSummaryPage;
            pd.Print();
        }

        private void PrintSummaryPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics!;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            // Use the graphics visible clip (actual printable area in device units/pixels)
            var clip = g.VisibleClipBounds;
            float dpiX = g.DpiX;
            float dpiY = g.DpiY;

            // Safe padding in device pixels: at least 12px or ~0.04in, whichever is larger.
            float safePad = Math.Max(12f, dpiX * 0.04f);

            float left = clip.Left + safePad;
            float top = clip.Top + safePad;
            float width = Math.Max(8f, clip.Width - safePad * 2f);
            float bottom = clip.Bottom - safePad;
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
            using (var headerFont = new Font("Georgia", 16, FontStyle.Bold))
            using (var subHeaderFont = new Font("Segoe UI", 9, FontStyle.Regular))
            using (var sectionTitleFont = new Font("Segoe UI", 10, FontStyle.Bold))
            using (var labelFont = new Font("Segoe UI", 9, FontStyle.Regular))
            using (var valueFont = new Font("Segoe UI", 11, FontStyle.Bold))
            using (var footerFont = new Font("Segoe UI", 9, FontStyle.Italic))
            {
                static string S(object? o) => o?.ToString() ?? string.Empty;

                void DrawDashedLine(float yPos)
                {
                    using var pen = new Pen(Color.Black, 1) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot };
                    g.DrawLine(pen, left, yPos, left + width, yPos);
                }

                // Header
                string hospitalName = "Rafi Medical Complex";
                string hospitalAddress = "Vehari Road Hasilpur Old";
                string generatedAt = $"Generated at: {DateTime.Now:g}";

                var hSize = g.MeasureString(hospitalName, headerFont);
                g.DrawString(hospitalName, headerFont, Brushes.Black, new RectangleF(left, y, width, hSize.Height), centerFmt);
                y += hSize.Height + 4;

                var addrSize = g.MeasureString(hospitalAddress, subHeaderFont);
                g.DrawString(hospitalAddress, subHeaderFont, Brushes.Black, new RectangleF(left, y, width, addrSize.Height), centerFmt);
                y += addrSize.Height + 6;

                var genSize = g.MeasureString(generatedAt, subHeaderFont);
                g.DrawString(generatedAt, subHeaderFont, Brushes.Black, new RectangleF(left, y, width, genSize.Height), centerFmt);
                y += genSize.Height + 8;

                // Title for this summary
                string title = $"{S(_tokenType)} Summary for {DateTime.Today:yyyy-MM-dd}";
                var tSize = g.MeasureString(title, sectionTitleFont);
                g.DrawString(title, sectionTitleFont, Brushes.Black, new RectangleF(left, y, width, tSize.Height), centerFmt);
                y += tSize.Height + sectionSpacing;

                // Token Info section header
                DrawDashedLine(y); y += 6;
                string tokenSection = "Token Info";
                var tsz = g.MeasureString(tokenSection, sectionTitleFont);
                g.DrawString(tokenSection, sectionTitleFont, Brushes.Black, new RectangleF(left, y, width, tsz.Height), centerFmt);
                y += tsz.Height + 6;

                // Totals
                int count = _todayList?.Count ?? 0;
                decimal sum = _todayList?.Sum(r => r.Fee) ?? 0m;

                float leftCol = width * 0.6f;
                float rightCol = width - leftCol;

                void DrawLabelValue(string label, string value)
                {
                    var lSize = g.MeasureString(label + ":", labelFont);
                    var vSize = g.MeasureString(value, valueFont);
                    float rowHeight = Math.Max(lSize.Height, vSize.Height);

                    g.DrawString(label + ":", labelFont, Brushes.Black, new RectangleF(left, y, leftCol, rowHeight), leftTopFmt);
                    float valX = left + leftCol + (rightCol - vSize.Width);
                    g.DrawString(value, valueFont, Brushes.Black, new RectangleF(valX, y, vSize.Width, vSize.Height), leftTopFmt);

                    y += rowHeight + lineSpacing;
                }

                DrawLabelValue("Total Tokens", count.ToString());
                DrawLabelValue("Total Amount", sum.ToString("C"));

                y += 4;
                DrawDashedLine(y); y += sectionSpacing;

                //// Details heading
                //string detailsTitle = "Summary Details";
                //var dTitleSize = g.MeasureString(detailsTitle, sectionTitleFont);
                //g.DrawString(detailsTitle, sectionTitleFont, Brushes.Black, new RectangleF(left, y, width, dTitleSize.Height), centerFmt);
                //y += dTitleSize.Height + 6;

                //// Column widths for records - ensure they sum to width and leave safe margins
                //float col1 = width * 0.12f;       // Queue#
                //float col2 = width * 0.58f;       // ID / description
                //float col3 = width - col1 - col2; // Fee

                //// Header row (optional)
                //// g.DrawString("Q#", labelFont, Brushes.Black, new RectangleF(left, y, col1, labelFont.GetHeight(g)), leftTopFmt);
                //// g.DrawString("ID / Desc", labelFont, Brushes.Black, new RectangleF(left + col1, y, col2, labelFont.GetHeight(g)), leftTopFmt);
                //// g.DrawString("Fee", labelFont, Brushes.Black, new RectangleF(left + col1 + col2, y, col3, labelFont.GetHeight(g)), leftTopFmt);
                //// y += labelFont.GetHeight(g) + lineSpacing;

                //// Print each record using measured column widths so nothing spills over paper.
                //foreach (var r in _todayList ?? Enumerable.Empty<Receipt>())
                //{
                //    string q = S(r.QueueNumber);
                //    string id = S(r.Id);
                //    // If you want to show patient name or other short desc, replace id with that.
                //    string fee = r.Fee.ToString("F2");

                //    // Measure wrapped heights for each column (limit per-column width)
                //    var qSize = g.MeasureString(q, labelFont, new SizeF(col1, float.MaxValue), wrapFmt);
                //    var idSizeRec = g.MeasureString(id, labelFont, new SizeF(col2, float.MaxValue), wrapFmt);
                //    var feeSize = g.MeasureString(fee, labelFont, new SizeF(col3, float.MaxValue), wrapFmt);

                //    float rowH = Math.Max(qSize.Height, Math.Max(idSizeRec.Height, feeSize.Height));

                //    // Reserve footer space; stop if no room
                //    if (y + rowH > bottom - 60)
                //    {
                //        // indicate more records truncated
                //        g.DrawString("...", labelFont, Brushes.Black, new RectangleF(left, y, width, labelFont.GetHeight(g)), leftTopFmt);
                //        y += labelFont.GetHeight(g) + lineSpacing;
                //        break;
                //    }

                //    // Draw each column within its column rectangle (wrap-safe)
                //    g.DrawString(q, labelFont, Brushes.Black, new RectangleF(left, y, col1, rowH), wrapFmt);
                //    g.DrawString(id, labelFont, Brushes.Black, new RectangleF(left + col1, y, col2, rowH), wrapFmt);

                //    // Right-align fee within col3
                //    var measuredFee = g.MeasureString(fee, labelFont, new SizeF(col3, rowH), wrapFmt);
                //    float feeX = left + col1 + col2 + (col3 - measuredFee.Width);
                //    g.DrawString(fee, labelFont, Brushes.Black, new RectangleF(feeX, y, measuredFee.Width, measuredFee.Height), wrapFmt);

                //    y += rowH + lineSpacing;
                //}

                // Footer - leave small gap then draw footer centered
                //y = Math.Min(y + 6, bottom - 40);
                //DrawDashedLine(y); 
                //y += 8;
                string footer = "Thank you for your Service";
                var fSize = g.MeasureString(footer, footerFont);
                g.DrawString(footer, footerFont, Brushes.Black, new RectangleF(left, y, width, fSize.Height), centerFmt);
                y += fSize.Height + 6;
                DrawDashedLine(y);

                e.HasMorePages = false;
            }
        }



        private void dgvRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure that the double-click happened on a valid row (e.RowIndex will be -1 for header rows).
            if (e.RowIndex >= 0)
            {
                // Retrieve the current list of receipts that the grid is bound to.
                var receipts = dgvRecords.DataSource as List<Receipt>;
                if (receipts != null)
                {
                    // Get the receipt corresponding to the row double-clicked.
                    Receipt selectedReceipt = receipts[e.RowIndex];

                    // Open the EditReceiptForm, passing the selected receipt.
                    EditReceiptForm editForm = new EditReceiptForm(selectedReceipt);
                    // Show the edit form modally, so that the user must complete the edit before returning.
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        // Refresh the history data to update any changes.
                        LoadRecords();
                    }
                }
            }
        }
    }
}
