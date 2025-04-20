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
    public partial class ReceiptEntryForm : Form
    {

        //private static readonly Dictionary<string, decimal> DefaultUSGPrices = new Dictionary<string, decimal>
        //{
        //    { "Abdominal and Pelvis", 700.00m },
        //    { "Scrotal", 1000.00m },
        //    { "Breast", 1200.00m },
        //    { "Mass", 2000.00m },
        //    { "TVS", 1800.00m },
        //    { "Anomaly", 2200.00m }
        //};

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            // Check for F2 to submit
            if (keyData == Keys.F2)
            {
                // Perform the click for the save/generate button.
                btnGenerate.PerformClick();
                return true;
            }
            // Check for F3 to cancel
            else if (keyData == Keys.Escape)
            {
                btnCancel.PerformClick();
                return true;
            }
            // Check if Enter is pressed (ignore if it's a multiline textbox)
            if (keyData == Keys.Enter && !(this.ActiveControl is TextBox tb && tb.Multiline))
            {
                // Move focus to the next control.
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private string _tokenType;

        // Returns null if validation passes; otherwise, returns an error message.
        private string? ValidateFormInputs()
        {
            // Check required fields – you can adjust according to your requirements.
            if (string.IsNullOrWhiteSpace(txtPatientName.Text))
                return "Patient Name is required.";
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
                return "Address is required.";
            if (string.IsNullOrWhiteSpace(txtFee.Text))
                return "Fee is required.";

            // Validate fee is a decimal number.
            if (!decimal.TryParse(txtFee.Text, out decimal fee))
                return "Fee must be a valid decimal number.";

            // Add any other validations as necessary.
            return null;
        }


        // Constructor accepting the token type
        public ReceiptEntryForm(string tokenType)
        {
            InitializeComponent();
            _tokenType = tokenType;
            lblTitle.Text = $"Generate Receipt for {_tokenType}";
            // If needed, conditionally enable/disable the DoctorName field.
            // Set up the DoctorName field based on the token type.
            // If the token is one that requires user input (like "OPD", "USG", or "ECG"):
            if (_tokenType == "USG")
            {
                cmbUSGType.Visible = true;
                lblUSGType.Visible = true;
                cmbUSGType.Items.Clear();

                // Load USG types from the database
                using (var context = new ApplicationDbContext())
                {
                    var usgTypes = context.PriceSettings
                                          .Where(p => p.Category == "USG")
                                          .OrderBy(p => p.Id)
                                          .ToList();

                    foreach (var type in usgTypes)
                    {
                        cmbUSGType.Items.Add(type.SubType);
                    }
                }
                cmbUSGType.SelectedIndex = 0;
                UpdateUSGPrice();  // a helper method to update the fee
            }


            if (_tokenType == "ECG")
            {
                // Hide Doctor Name, Temperature, and BP controls
                txtDoctorName.Visible = false;
                lblDoctorName.Visible = false;
                txtTemperature.Visible = false;
                lblTemperature.Visible = false;
                txtBP.Visible = false;
                lblBP.Visible = false;
            }
            else if (_tokenType == "OPD" || _tokenType == "USG")
            {
                // Hide doctor name field for OPD and USG as well (as specified)
                txtDoctorName.Visible = false;
                lblDoctorName.Visible = false;
            }
            else if (_tokenType == "Dr Zain" || _tokenType == "Dr Hammad" || _tokenType == "Dr Jawad" || _tokenType == "Dr Fizza")
            {
                // For these, show a non-editable field populated with the corresponding doctor's name.
                txtDoctorName.Visible = true;
                txtDoctorName.ReadOnly = true;
                txtDoctorName.Text = _tokenType;
                lblDoctorName.Visible = true;
            }
            else if (_tokenType == "Others")
            {
                txtDoctorName.Visible = true;
                txtDoctorName.ReadOnly = false;
                txtDoctorName.Text = "";
                lblDoctorName.Visible = true;
            }

            if (_tokenType == "OPD")
            {
                using (var context = new ApplicationDbContext())
                {
                    var setting = context.PriceSettings.FirstOrDefault(p => p.Category == "OPD" && p.SubType == "");
                    if (setting != null)
                    {
                        txtFee.Text = setting.Price.ToString("F2");
                    }
                }
            }
            else if (_tokenType == "ECG")
            {
                using (var context = new ApplicationDbContext())
                {
                    var setting = context.PriceSettings.FirstOrDefault(p => p.Category == "ECG" && p.SubType == "");
                    if (setting != null)
                    {
                        txtFee.Text = setting.Price.ToString("F2");
                    }
                }
            }
            else if (_tokenType == "Dr Zain" || _tokenType == "Dr Hammad" || _tokenType == "Dr Jawad" || _tokenType == "Dr Fizza")
            {
                // For these, load the doctor's price
                using (var context = new ApplicationDbContext())
                {
                    var setting = context.PriceSettings.FirstOrDefault(p => p.Category == "Dr" && p.SubType == _tokenType);
                    if (setting != null)
                    {
                        txtFee.Text = setting.Price.ToString("F2");
                    }
                }
            }

        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Validate form inputs
            string? validationError = ValidateFormInputs();
            if (validationError != null)
            {
                MessageBox.Show(validationError, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // In btnGenerate_Click (after validations):
                var receipt = new Receipt
                {
                    TokenType = _tokenType,
                    PatientName = txtPatientName.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    // For controls that might be hidden, check their visibility.
                    Temperature = txtTemperature.Visible ? txtTemperature.Text.Trim() : "",
                    BloodPressure = txtBP.Visible ? txtBP.Text.Trim() : "",
                    DoctorName = txtDoctorName.Visible ? txtDoctorName.Text.Trim() : "",
                    // Fee should be parsed from the textbox (ensure txtFee has a default value for non-USG types)
                    Fee = decimal.TryParse(txtFee.Text, out decimal fee) ? fee : 0m,
                    CreatedAt = DateTime.Now
                };

                // If USG, optionally assign the selected USG type to a new property
                if (_tokenType == "USG")
                {
                    // 1a) Ensure something is selected
                    if (cmbUSGType.SelectedItem is not string selectedType)
                    {
                        MessageBox.Show(
                            "Please select a valid USG type.",
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 1b) Now we know selectedType is non-null
                    receipt.USGType = selectedType;
                }

                // Instantiate the ReceiptService and generate the receipt
                var service = new ReceiptService();
                var savedReceipt = service.GenerateAndSaveReceipt(receipt);

                // Inform user and optionally trigger printing later
                MessageBox.Show(
                    $"Receipt generated successfully!\nToken: {savedReceipt.TokenNumber}\nQueue: {savedReceipt.QueueNumber}",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Trigger printing
                var printer = new ReceiptPrinter(savedReceipt);
                try
                {
                    printer.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Printing Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Optionally, close the form after generation.
                // Instead of closing the form, clear the fields for a new entry.
                txtPatientName.Text = "";
                txtAddress.Text = "";
                if (txtTemperature.Visible)
                    txtTemperature.Text = "";
                if (txtBP.Visible)
                    txtBP.Text = "";

                // Optionally reset focus to the first field.
                txtPatientName.Focus();
                //this.Close();
            }
            catch (Exception ex)
            {
                // Display both the outer and inner exception messages.
                string message = "Error: " + ex.Message;
                if (ex.InnerException != null)
                {
                    message += "\nInner Exception: " + ex.InnerException.Message;
                }
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cmbUSGType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUSGPrice();
        }


        private void UpdateUSGPrice()
        {
            if (cmbUSGType.SelectedItem != null)
            {
                // Safely get the selected type, defaulting to empty if nothing is selected:
                string selectedType = cmbUSGType.SelectedItem?.ToString() ?? string.Empty;

                if (string.IsNullOrEmpty(selectedType))
                {
                    // Nothing selected—clear fee or bail out
                    txtFee.Text = "";
                    return;
                }
                using (var context = new ApplicationDbContext())
                {
                    var setting = context.PriceSettings
                                         .FirstOrDefault(p => p.Category == "USG" && p.SubType == selectedType);
                    if (setting != null)
                    {
                        txtFee.Text = setting.Price.ToString("F2");
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        // … other code
    }
}
