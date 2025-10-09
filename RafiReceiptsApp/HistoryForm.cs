using RafiReceiptsApp.Models;
using RafiReceiptsApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RafiReceiptsApp
{
    public partial class HistoryForm : Form
    {

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            // Check for F2 to submit
            if (keyData == Keys.F4)
            {
                // Perform the click for the save/generate button.
                btnReprint.PerformClick();
                return true;
            }
            // Check for F3 to cancel
            else if (keyData == Keys.Escape)
            {
                btnCancel.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public HistoryForm()
        {
            InitializeComponent();
            // 1. Make the grid read‑only so clicks don’t trigger editing
            dataGridHistory.ReadOnly = true;
            dataGridHistory.AllowUserToAddRows = false;
            dataGridHistory.AllowUserToDeleteRows = false;

            // 2. Prevent entering into edit mode on single‑click
            dataGridHistory.EditMode = DataGridViewEditMode.EditProgrammatically;

            // 3. Optional: disable row header editing menu
            dataGridHistory.RowHeadersVisible = false;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {

            LoadHistoryData();   // The method that loads receipt records into the grid.
            LoadSummaryData();   // The new method to calculate and display filters/summaries.
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    // Retrieve all receipts from the database
                    var receipts = context.Receipts
                        .OrderByDescending(r => r.CreatedAt)
                        .ToList();

                    // Bind the list to the DataGridView
                    dataGridHistory.DataSource = receipts;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading history: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void LoadHistoryData()
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var receipts = context.Receipts
                                           .OrderByDescending(r => r.CreatedAt)
                                           .ToList();
                    dataGridHistory.DataSource = receipts;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading history: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            // Ensure that the double-click happened on a valid row (e.RowIndex will be -1 for header rows).
            if (e.RowIndex >= 0)
            {
                // Retrieve the current list of receipts that the grid is bound to.
                var receipts = dataGridHistory.DataSource as List<Receipt>;
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
                        LoadHistoryData();
                    }
                }
            }
        }

        private void LoadSummaryData()
        {
            using (var context = new ApplicationDbContext())
            {
                DateTime today = DateTime.Today;
                int currentYear = today.Year;
                int currentMonth = today.Month;

                // Query receipts for today.
                var todaysReceipts = context.Receipts
                    .Where(r => r.CreatedAt.Date == today)
                    .ToList();

                // Query receipts for the current month.
                var monthReceipts = context.Receipts
                    .Where(r => r.CreatedAt.Year == currentYear && r.CreatedAt.Month == currentMonth)
                    .ToList();

                // Helper local func to compute counts/totals by token type for a given set
                (int count, decimal total) ByType(List<Receipt> source, string tokenType)
                {
                    var q = source.Where(r => r.TokenType == tokenType);
                    int c = q.Count();
                    decimal t = q.Sum(r => (decimal?)r.Fee) ?? 0m;
                    return (c, t);
                }

                // --- DAILY Summaries (unchanged behavior) ---
                var opd = ByType(todaysReceipts, "OPD");
                var ecg = ByType(todaysReceipts, "ECG");
                var usg = ByType(todaysReceipts, "USG");
                var drZain = ByType(todaysReceipts, "Dr Zain");
                var drHammad = ByType(todaysReceipts, "Dr Hammad");
                var drJawad = ByType(todaysReceipts, "Dr Jawad");
                var drFizza = ByType(todaysReceipts, "Dr Fizza");
                var drTehreem = ByType(todaysReceipts, "Dr Tehreem");
                var drZuhaib = ByType(todaysReceipts, "Dr Zuhaib");
                var others = ByType(todaysReceipts, "Others");

                int totalCountToday = todaysReceipts.Count();
                decimal totalAmountToday = todaysReceipts.Sum(r => (decimal?)r.Fee) ?? 0m;

                // Update the DAILY labels (your existing labels)
                lblOpdSummary.Text = $"OPD: {opd.count} tokens, Total: {opd.total:C}";
                lblEcgSummary.Text = $"ECG: {ecg.count} tokens, Total: {ecg.total:C}";
                lblUsgSummary.Text = $"USG: {usg.count} tokens, Total: {usg.total:C}";
                lblDrZainSummary.Text = $"Dr Zain: {drZain.count} tokens, Total: {drZain.total:C}";
                lblDrHammadSummary.Text = $"Dr Hammad: {drHammad.count} tokens, Total: {drHammad.total:C}";
                lblDrJawadSummary.Text = $"Dr Jawad: {drJawad.count} tokens, Total: {drJawad.total:C}";
                lblDrFizzaSummary.Text = $"Dr Fizza: {drFizza.count} tokens, Total: {drFizza.total:C}";
                lblDrTehreemSummary.Text = $"Dr Tehreem: {drTehreem.count} tokens, Total: {drTehreem.total:C}";
                lblDrZuhaibSummary.Text = $"Dr Zuhaib: {drZuhaib.count} tokens, Total: {drZuhaib.total:C}";
                lblOthersSummary.Text = $"Others: {others.count} tokens, Total: {others.total:C}";

                lblTodayTotal.Text = $"Today's Total: {totalCountToday} tokens, Amount: {totalAmountToday:C}";

                // --- MONTHLY Summaries (new: compute and update per-type monthly labels) ---
                var m_opd = ByType(monthReceipts, "OPD");
                var m_ecg = ByType(monthReceipts, "ECG");
                var m_usg = ByType(monthReceipts, "USG");
                var m_drZain = ByType(monthReceipts, "Dr Zain");
                var m_drHammad = ByType(monthReceipts, "Dr Hammad");
                var m_drJawad = ByType(monthReceipts, "Dr Jawad");
                var m_drFizza = ByType(monthReceipts, "Dr Fizza");
                var m_drTehreem = ByType(monthReceipts, "Dr Tehreem");
                var m_drZuhaib = ByType(monthReceipts, "Dr Zuhaib");
                var m_others = ByType(monthReceipts, "Others");

                int totalCountMonth = monthReceipts.Count();
                decimal totalAmountMonth = monthReceipts.Sum(r => (decimal?)r.Fee) ?? 0m;

                // Update MONTHLY labels - NOTE: add these labels on the form with the same names
                // e.g. lblOpdSummaryMonth, lblEcgSummaryMonth, lblUsgSummaryMonth, etc.
                lblOpdSummaryMonth.Text = $"OPD: {m_opd.count} tokens, Total: {m_opd.total:C}";
                lblEcgSummaryMonth.Text = $"ECG: {m_ecg.count} tokens, Total: {m_ecg.total:C}";
                lblUsgSummaryMonth.Text = $"USG: {m_usg.count} tokens, Total: {m_usg.total:C}";
                lblDrZainSummaryMonth.Text = $"Dr Zain: {m_drZain.count} tokens, Total: {m_drZain.total:C}";
                lblDrHammadSummaryMonth.Text = $"Dr Hammad: {m_drHammad.count} tokens, Total: {m_drHammad.total:C}";
                lblDrJawadSummaryMonth.Text = $"Dr Jawad: {m_drJawad.count} tokens, Total: {m_drJawad.total:C}";
                lblDrFizzaSummaryMonth.Text = $"Dr Fizza: {m_drFizza.count} tokens, Total: {m_drFizza.total:C}";
                lblDrTehreemSummaryMonth.Text = $"Dr Tehreem: {m_drTehreem.count} tokens, Total: {m_drTehreem.total:C}";
                lblDrZuhaibSummaryMonth.Text = $"Dr Zuhaib: {m_drZuhaib.count} tokens, Total: {m_drZuhaib.total:C}";
                lblOthersSummaryMonth.Text = $"Others: {m_others.count} tokens, Total: {m_others.total:C}";

                lblMonthTotal.Text = $"This Month: {totalCountMonth} tokens, Amount: {totalAmountMonth:C}";
            }
        }


        private string GenerateDailySummaryText()
        {
            // Assuming you have the summary labels updated, or you can recalculate here.
            // For instance, you can simply build a string with your daily summaries.
            string summary = $"OPD: {lblOpdSummary.Text}\n" +
                             $"ECG: {lblEcgSummary.Text}\n" +
                             $"USG: {lblUsgSummary.Text}\n" +
                             $"Dr Zain: {lblDrZainSummary.Text}\n" +
                             $"Dr Fizza: {lblDrFizzaSummary.Text}\n" +
                             $"Dr Hammad: {lblDrHammadSummary.Text}\n" +
                             $"Dr Jawad: {lblDrJawadSummary.Text}\n" +
                             $"Dr Tehreem: {lblDrTehreemSummary.Text}\n" +
                             $"Dr Zuhaib: {lblDrZuhaibSummary.Text}\n" +
                             $"Others: {lblOthersSummary.Text}\n" +
                             $"{lblTodayTotal.Text}";
            return summary;
        }

        private string GenerateMonthlySummaryText()
        {
            // Build a string mirroring the daily layout but using monthly labels.
            // Ensure the form has the monthly labels (names used here).
            string summary = $"OPD: {lblOpdSummaryMonth.Text}\n" +
                             $"ECG: {lblEcgSummaryMonth.Text}\n" +
                             $"USG: {lblUsgSummaryMonth.Text}\n" +
                             $"Dr Zain: {lblDrZainSummaryMonth.Text}\n" +
                             $"Dr Fizza: {lblDrFizzaSummaryMonth.Text}\n" +
                             $"Dr Hammad: {lblDrHammadSummaryMonth.Text}\n" +
                             $"Dr Jawad: {lblDrJawadSummaryMonth.Text}\n" +
                             $"Dr Tehreem: {lblDrTehreemSummaryMonth.Text}\n" +
                             $"Dr Zuhaib: {lblDrZuhaibSummaryMonth.Text}\n" +
                             $"Others: {lblOthersSummaryMonth.Text}\n" +
                             $"{lblMonthTotal.Text}";
            return summary;
        }

        private void btnPrintDaily_Click(object sender, EventArgs e)
        {
            string dailySummary = GenerateDailySummaryText(); // your method that creates a summary text block
            SummaryPrinter printer = new SummaryPrinter("Daily", DateTime.Today, dailySummary);
            try
            {
                printer.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing daily summary: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintMonthly_Click(object sender, EventArgs e)
        {
            // Recompute summaries so labels are fresh before printing.
            LoadSummaryData();

            string monthlySummary = GenerateMonthlySummaryText();
            DateTime monthDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            SummaryPrinter printer = new SummaryPrinter("Monthly", monthDate, monthlySummary);
            try
            {
                printer.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing monthly summary: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ConfirmRePrint()
        {
            // Create a tiny modal form at runtime (no designer, no extra files)
            using (Form prompt = new Form())
            {
                prompt.Width = 380;
                prompt.Height = 140;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.MinimizeBox = false;
                prompt.MaximizeBox = false;
                prompt.ShowInTaskbar = false;
                prompt.Text = "Confirm RePrint";

                Label textLabel = new Label() { Left = 12, Top = 12, Width = 340, Text = "Enter the RePrint password:" };
                TextBox inputBox = new TextBox() { Left = 12, Top = 36, Width = 340 };

                // MAKE IT MASKED
                inputBox.UseSystemPasswordChar = true; // -> hides characters / shows bullets

                Button okButton = new Button() { Text = "OK", Left = 190, Width = 80, Top = 70, DialogResult = DialogResult.OK };
                Button cancelButton = new Button() { Text = "Cancel", Left = 272, Width = 80, Top = 70, DialogResult = DialogResult.Cancel };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(okButton);
                prompt.Controls.Add(cancelButton);

                prompt.AcceptButton = okButton;
                prompt.CancelButton = cancelButton;

                if (prompt.ShowDialog(this) == DialogResult.OK)
                {
                    string password = inputBox.Text ?? string.Empty;

                    // compare securely (still avoiding plaintext storage in production)
                    if (string.Equals(password, "123123", StringComparison.Ordinal))
                        return true;

                    MessageBox.Show("Incorrect password. RePrint aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    // Cancel pressed
                    return false;
                }
            }
        }


        private void btnReprint_Click(object sender, EventArgs e)
        {

            if (!ConfirmRePrint())
                return;


            // Ensure a row is selected.
            if (dataGridHistory.CurrentRow != null)
            {
                // Assuming your DataGridView is bound to a List<Receipt>.
                var receipts = dataGridHistory.DataSource as List<Receipt>;
                if (receipts != null && dataGridHistory.CurrentRow.Index >= 0)
                {
                    // Get the Receipt corresponding to the selected row.
                    Receipt selectedReceipt = receipts[dataGridHistory.CurrentRow.Index];

                    // Optionally, check if the receipt exists.
                    if (selectedReceipt != null)
                    {
                        try
                        {
                            // Reprint the receipt using your existing printer functionality.
                            var printer = new ReceiptPrinter(selectedReceipt);
                            printer.Print();
                            MessageBox.Show("Receipt reprint initiated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Printing Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No receipt selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to reprint.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDailyOPD_Click(object sender, EventArgs e)
        {
            using var form = new DailyTypeRecordsForm("OPD");
            form.ShowDialog();
        }

        private void btnDailyECG_Click(object sender, EventArgs e)
        {
            using var form = new DailyTypeRecordsForm("ECG");
            form.ShowDialog();
        }

        private void btnDailyUSG_Click(object sender, EventArgs e)
        {
            using var form = new DailyTypeRecordsForm("USG");
            form.ShowDialog();
        }

        private void btnDailyDrZain_Click(object sender, EventArgs e)
        {
            using var form = new DailyTypeRecordsForm("Dr Zain");
            form.ShowDialog();
        }

        private void btnDailyDrFizza_Click(object sender, EventArgs e)
        {
            using var form = new DailyTypeRecordsForm("Dr Fizza");
            form.ShowDialog();
        }

        private void btnDailyDrHammad_Click(object sender, EventArgs e)
        {
            using var form = new DailyTypeRecordsForm("Dr Hammad");
            form.ShowDialog();
        }

        private void btnDailyDrJawad_Click(object sender, EventArgs e)
        {
            using var form = new DailyTypeRecordsForm("Dr Jawad");
            form.ShowDialog();
        }

        private void btnDailyOther_Click(object sender, EventArgs e)
        {
            using var form = new DailyTypeRecordsForm("Other");
            form.ShowDialog();
        }

        private void btnDailyDrTehreem_Click(object sender, EventArgs e)
        {
            using var form = new DailyTypeRecordsForm("Dr Tehreem");
            form.ShowDialog();
        }

        private void btnDailyDrZuhaib_Click(object sender, EventArgs e)
        {
            using var form = new DailyTypeRecordsForm("Dr Zuhaib");
            form.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
