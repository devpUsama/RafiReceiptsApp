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

                // Summaries for standard types.
                int opdCount = todaysReceipts.Where(r => r.TokenType == "OPD").Count();
                decimal opdTotal = todaysReceipts.Where(r => r.TokenType == "OPD").Sum(r => (decimal?)r.Fee) ?? 0m;

                int ecgCount = todaysReceipts.Where(r => r.TokenType == "ECG").Count();
                decimal ecgTotal = todaysReceipts.Where(r => r.TokenType == "ECG").Sum(r => (decimal?)r.Fee) ?? 0m;

                int usgCount = todaysReceipts.Where(r => r.TokenType == "USG").Count();
                decimal usgTotal = todaysReceipts.Where(r => r.TokenType == "USG").Sum(r => (decimal?)r.Fee) ?? 0m;

                // Summaries for doctor tokens.
                int drZainCount = todaysReceipts.Where(r => r.TokenType == "Dr Zain").Count();
                decimal drZainTotal = todaysReceipts.Where(r => r.TokenType == "Dr Zain").Sum(r => (decimal?)r.Fee) ?? 0m;

                int drHammadCount = todaysReceipts.Where(r => r.TokenType == "Dr Hammad").Count();
                decimal drHammadTotal = todaysReceipts.Where(r => r.TokenType == "Dr Hammad").Sum(r => (decimal?)r.Fee) ?? 0m;

                int drJawadCount = todaysReceipts.Where(r => r.TokenType == "Dr Jawad").Count();
                decimal drJawadTotal = todaysReceipts.Where(r => r.TokenType == "Dr Jawad").Sum(r => (decimal?)r.Fee) ?? 0m;

                int drFizzaCount = todaysReceipts.Where(r => r.TokenType == "Dr Fizza").Count();
                decimal drFizzaTotal = todaysReceipts.Where(r => r.TokenType == "Dr Fizza").Sum(r => (decimal?)r.Fee) ?? 0m;

                // Summaries for 'Others'
                int othersCount = todaysReceipts.Where(r => r.TokenType == "Others").Count();
                decimal othersTotal = todaysReceipts.Where(r => r.TokenType == "Others").Sum(r => (decimal?)r.Fee) ?? 0m;

                int totalCountToday = todaysReceipts.Count();
                decimal totalAmountToday = todaysReceipts.Sum(r => (decimal?)r.Fee) ?? 0m;

                // Monthly Summary: Filter receipts for current month.
                var monthReceipts = context.Receipts
                    .Where(r => r.CreatedAt.Year == currentYear && r.CreatedAt.Month == currentMonth)
                    .ToList();
                int totalCountMonth = monthReceipts.Count();
                decimal totalAmountMonth = monthReceipts.Sum(r => (decimal?)r.Fee) ?? 0m;

                // Update the labels. Make sure to have corresponding labels on HistoryForm.
                lblOpdSummary.Text = $"OPD: {opdCount} tokens, Total: {opdTotal:C}";
                lblEcgSummary.Text = $"ECG: {ecgCount} tokens, Total: {ecgTotal:C}";
                lblUsgSummary.Text = $"USG: {usgCount} tokens, Total: {usgTotal:C}";
                lblDrZainSummary.Text = $"Dr Zain: {drZainCount} tokens, Total: {drZainTotal:C}";
                lblDrHammadSummary.Text = $"Dr Hammad: {drHammadCount} tokens, Total: {drHammadTotal:C}";
                lblDrJawadSummary.Text = $"Dr Jawad: {drJawadCount} tokens, Total: {drJawadTotal:C}";
                lblDrFizzaSummary.Text = $"Dr Fizza: {drFizzaCount} tokens, Total: {drFizzaTotal:C}";
                lblOthersSummary.Text = $"Others: {othersCount} tokens, Total: {othersTotal:C}";

                lblTodayTotal.Text = $"Today's Total: {totalCountToday} tokens, Amount: {totalAmountToday:C}";
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
                             $"Others: {lblOthersSummary.Text}\n" +
                             $"{lblTodayTotal.Text}";
            return summary;
        }

        private string GenerateMonthlySummaryText()
        {
            // Build a string with monthly total.
            string summary = $"{lblMonthTotal.Text}";
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
            string monthlySummary = GenerateMonthlySummaryText(); // your method for monthly summary text
                                                                  // Use a representative date within the month (e.g., first day of the month)
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

        private void btnReprint_Click(object sender, EventArgs e)
        {
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
    }
}
