using RafiReceiptsApp.Models;
using RafiReceiptsApp.Services;

namespace RafiReceiptsApp
{
    public partial class MainForm : Form
    {

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            // Check for F1 to OPD
            if (keyData == Keys.F1)
            {
                // Perform the click for the save/generate button.
                btnOPD.PerformClick();
                return true;
            }
            // Check for F2 to USG
            else if (keyData == Keys.F2)
            {
                btnUSG.PerformClick();
                return true;
            }
            // Check for F3 to ECG
            else if (keyData == Keys.F3)
            {
                btnECG.PerformClick();
                return true;
            }
            // Check for F4 to Dr Zain
            else if (keyData == Keys.F4)
            {
                btnDrZain.PerformClick();
                return true;
            }
            // Check for F5 to Dr Fizza
            else if (keyData == Keys.F5)
            {
                btnDrFizza.PerformClick();
                return true;
            }
            // Check for F6 to Dr Jawad
            else if (keyData == Keys.F6)
            {
                btnDrJawad.PerformClick();
                return true;
            }
            // Check for F7 to Dr Hammad
            else if (keyData == Keys.F7)
            {
                btnDrHammad.PerformClick();
                return true;
            }
            // Check for F8 to Other
            else if (keyData == Keys.F8)
            {
                btnOtherReceipt.PerformClick();
                return true;
            }
            // Check for F9 to Records
            else if (keyData == Keys.F9)
            {
                btnHistory.PerformClick();
                return true;
            }
            // Check for F10 to Prices
            else if (keyData == Keys.F10)
            {
                btnAdminPrices.PerformClick();
                return true;
            }
            // Check for F11 to USG
            else if (keyData == Keys.F11)
            {
                btnReturnReceipt.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public MainForm()
        {
            InitializeComponent();
            // Ensure the database is created on startup
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Database.EnsureCreated(); // Creates DB if not exists
                    System.Diagnostics.Debug.WriteLine("[DEBUG] Database created successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Consider logging the exception details
            }
        }

        

        

        private void btnOPD_Click(object sender, EventArgs e)
        {
            // Open the ReceiptEntryForm with the selected token type "OPD"
            var receiptForm = new ReceiptEntryForm("OPD");
            receiptForm.ShowDialog(); // Show modally so that the user completes this form before returning.
        }

        private void btnUSG_Click(object sender, EventArgs e)
        {
            // Open the ReceiptEntryForm with the selected token type "OPD"
            var receiptForm = new ReceiptEntryForm("USG");
            receiptForm.ShowDialog(); // Show modally so that the user completes this form before returning.
        }

        private void btnECG_Click(object sender, EventArgs e)
        {
            // Open the ReceiptEntryForm with the selected token type "OPD"
            var receiptForm = new ReceiptEntryForm("ECG");
            receiptForm.ShowDialog(); // Show modally so that the user completes this form before returning.
        }

        private void btnDrZain_Click(object sender, EventArgs e)
        {
            // Open the ReceiptEntryForm with the selected token type "OPD"
            var receiptForm = new ReceiptEntryForm("Dr Zain");
            receiptForm.ShowDialog(); // Show modally so that the user completes this form before returning.
        }

        private void btnDrHammad_Click(object sender, EventArgs e)
        {
            // Open the ReceiptEntryForm with the selected token type "OPD"
            var receiptForm = new ReceiptEntryForm("Dr Hammad");
            receiptForm.ShowDialog(); // Show modally so that the user completes this form before returning.
        }

        private void btnDrJawad_Click(object sender, EventArgs e)
        {
            // Open the ReceiptEntryForm with the selected token type "OPD"
            var receiptForm = new ReceiptEntryForm("Dr Jawad");
            receiptForm.ShowDialog(); // Show modally so that the user completes this form before returning.
        }

        private void btnOtherReceipt_Click(object sender, EventArgs e)
        {
            // Open the ReceiptEntryForm with the selected token type "OPD"
            var receiptForm = new ReceiptEntryForm("Other");
            receiptForm.ShowDialog(); // Show modally so that the user completes this form before returning.
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var historyForm = new HistoryForm();
            historyForm.ShowDialog(); // Open history form modally.
        }

        private void btnAdminPrices_Click(object sender, EventArgs e)
        {
            var adminForm = new AdminPricesForm();
            adminForm.ShowDialog();
        }

        private void btnDrFizza_Click(object sender, EventArgs e)
        {
            // Open the ReceiptEntryForm using "Dr Fizza" as the token type.
            ReceiptEntryForm form = new ReceiptEntryForm("Dr Fizza");
            form.ShowDialog();
        }

        private void btnReturnReceipt_Click(object sender, EventArgs e)
        {
            // Open the ReturnReceiptForm modally.
            ReturnReceiptForm returnForm = new ReturnReceiptForm();
            returnForm.ShowDialog();
        }
    }
}
