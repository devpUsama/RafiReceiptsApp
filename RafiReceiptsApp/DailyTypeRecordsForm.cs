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
            // zero margins + custom 3" width
            pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            pd.DefaultPageSettings.PaperSize = new PaperSize("Custom", 300, 20000);
            pd.PrintPage += PrintSummaryPage;
            pd.Print();
        }

        private void PrintSummaryPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics!;
            var bounds = e.MarginBounds;
            float x = bounds.Left, y = bounds.Top, w = bounds.Width;

            // fonts
            var headerFont = new Font("Arial", 16, FontStyle.Bold);
            var labelFont = new Font("Arial", 10, FontStyle.Regular);
            var valueFont = new Font("Arial", 10, FontStyle.Bold);

            // 1) RMC header
            var hdr = "RMC";
            g.DrawString(hdr, headerFont, Brushes.Black,
                new RectangleF(x, y, w, headerFont.GetHeight(g)),
                new StringFormat { Alignment = StringAlignment.Center });
            y += headerFont.GetHeight(g) + 5;

            // 2) Subtitle with token type & date
            string subtitle = $"{_tokenType} Summary for {DateTime.Today:yyyy-MM-dd}";
            g.DrawString(subtitle, labelFont, Brushes.Black,
                new RectangleF(x, y, w, labelFont.GetHeight(g)),
                new StringFormat { Alignment = StringAlignment.Center });
            y += labelFont.GetHeight(g) + 5;

            // 3) Horizontal line
            g.DrawLine(Pens.Black, x, y, x + w, y);
            y += 8;

            // 4) Total tokens
            int count = _todayList.Count;
            decimal sum = _todayList.Sum(r => r.Fee);

            g.DrawString("Total Tokens:", labelFont, Brushes.Black, x, y);
            g.DrawString(count.ToString(), valueFont, Brushes.Black, x + 100, y);
            y += labelFont.GetHeight(g) + 5;

            // 5) Total amount
            g.DrawString("Total Amount:", labelFont, Brushes.Black, x, y);
            g.DrawString(sum.ToString("C"), valueFont, Brushes.Black, x + 100, y);
            y += labelFont.GetHeight(g) + 5;

            // 6) Horizontal line
            g.DrawLine(Pens.Black, x, y, x + w, y);
            y += 8;

            e.HasMorePages = false;
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
