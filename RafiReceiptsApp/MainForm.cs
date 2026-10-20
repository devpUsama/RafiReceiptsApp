using RafiReceiptsApp.Models;
using RafiReceiptsApp.Services;
using Microsoft.EntityFrameworkCore;

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
            // Check for F8 to Dr Tehreem
            else if (keyData == Keys.F8)
            {
                btnDrTehreem.PerformClick();
                return true;
            }
            // Check for F9 to Dr Zuhaib
            else if (keyData == Keys.F9)
            {
                btnDrZuhaib.PerformClick();
                return true;
            }
            // Check for F10 to Others
            else if (keyData == Keys.F10)
            {
                btnOtherReceipt.PerformClick();
                return true;
            }
            // Check for F11 to Records
            else if (keyData == Keys.F11)
            {
                btnHistory.PerformClick();
                return true;
            }
            // Check for F12 to Prices
            else if (keyData == Keys.F12)
            {
                btnAdminPrices.PerformClick();
                return true;
            }
            else if (keyData == Keys.D1)
            {
                btnDrMinahil.PerformClick();
                return true;
            }
            else if (keyData == Keys.D2)
            {
                btnDrAyesha.PerformClick();
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
                    // Ensures the database and tables exist
                    context.Database.EnsureCreated();

                    // 1. Calculate the exact start of the current month
                    // Example: If today is Oct 1, 2026, 2:56 PM, this creates a timestamp of Oct 1, 2026, 00:00:00 (Midnight)
                    DateTime startOfCurrentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

                    // 2. Safely and instantly delete only records older than the exact start of this month
                    // Any record created on or after Oct 1, 00:00:00 is perfectly safe.
                    context.Receipts
                           .Where(r => r.CreatedAt < startOfCurrentMonth)
                           .ExecuteDelete();
                    System.Diagnostics.Debug.WriteLine("[DEBUG] Database created successfully.");

                    // 3. Inject CT Scan Pricing (runs once)
                    bool ctScanExists = context.PriceSettings.Any(p => p.Category == "CTScan");
                    if (!ctScanExists)
                    {
                        var ctTypes = new List<PriceSetting>
                        {
                            new PriceSetting { Category = "CTScan", SubType = "Head CT: CT Brain plain or Contrast", Price = 5000.00m },
                            new PriceSetting { Category = "CTScan", SubType = "Chest / Lung CT", Price = 5000.00m },
                            new PriceSetting { Category = "CTScan", SubType = "Abdomen / Pelvis CT", Price = 5000.00m },
                            new PriceSetting { Category = "CTScan", SubType = "Spine CT", Price = 5000.00m },
                            new PriceSetting { Category = "CTScan", SubType = "Bone / Musculoskeletal CT", Price = 5000.00m },
                            new PriceSetting { Category = "CTScan", SubType = "Neck CT", Price = 5000.00m },
                            new PriceSetting { Category = "CTScan", SubType = "CT Angiography (CTA)", Price = 5000.00m },
                            new PriceSetting { Category = "CTScan", SubType = "Cardiac CT / Calcium Scoring", Price = 5000.00m },
                            new PriceSetting { Category = "CTScan", SubType = "Contrast-Ct", Price = 5000.00m }
                        };
                        context.PriceSettings.AddRange(ctTypes);
                        context.SaveChanges();
                    }
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

        private void btnDrTehreem_Click(object sender, EventArgs e)
        {
            // Open the ReceiptEntryForm with the selected token type "OPD"
            var receiptForm = new ReceiptEntryForm("Dr Tehreem");
            receiptForm.ShowDialog(); // Show modally so that the user completes this form before returning.
        }

        private void btnDrZuhaib_Click(object sender, EventArgs e)
        {
            // Open the ReceiptEntryForm with the selected token type "OPD"
            var receiptForm = new ReceiptEntryForm("Dr Zuhaib");
            receiptForm.ShowDialog(); // Show modally so that the user completes this form before returning.
        }

        private void btnDrMinahil_Click(object sender, EventArgs e)
        {
            // Open the ReceiptEntryForm with the selected token type "OPD"
            var receiptForm = new ReceiptEntryForm("Dr Minahil");
            receiptForm.ShowDialog(); // Show modally so that the user completes this form before returning.
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDrAyesha_Click(object sender, EventArgs e)
        {
            // Open the ReceiptEntryForm with the selected token type "OPD"
            var receiptForm = new ReceiptEntryForm("Dr Ayesha");
            receiptForm.ShowDialog(); // Show modally so that the user completes this form before returning.
        }

        private void btnCTScan_Click(object sender, EventArgs e)
        {
            ReceiptEntryForm form = new ReceiptEntryForm("CTScan");
            form.ShowDialog();
        }
    }
}
