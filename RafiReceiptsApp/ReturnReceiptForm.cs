using RafiReceiptsApp.Models;
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

    public partial class ReturnReceiptForm : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            // Check for F2 to submit
            if (keyData == Keys.F2)
            {
                // Perform the click for the save/generate button.
                btnLoadReceipt.PerformClick();
                return true;
            }
            // Check for F3 to submit
            if (keyData == Keys.F3)
            {
                // Perform the click for the save/generate button.
                btnSubmitReturn.PerformClick();
                return true;
            }
            // Check for F1 to cancel
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

        private Receipt? _loadedReceipt;

        public ReturnReceiptForm()
        {
            InitializeComponent();
        }

        private void btnLoadReceipt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtReceiptId.Text.Trim(), out int receiptId))
            {
                using (var context = new ApplicationDbContext())
                {
                    if (_loadedReceipt == null)
                    {
                        MessageBox.Show("No receipt loaded. Please enter an ID and load a receipt first.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    _loadedReceipt = context.Receipts.Find(receiptId);
                }

                if (_loadedReceipt != null)
                {
                    // Populate the controls with the loaded receipt details.
                    txtPatientName.Text = _loadedReceipt.PatientName;
                    txtAddress.Text = _loadedReceipt.Address;
                    txtFee.Text = _loadedReceipt.Fee.ToString("F2");

                    // Optionally, disable editing of fields that are not allowed to change:
                    txtPatientName.ReadOnly = true;
                    txtAddress.ReadOnly = true;

                    MessageBox.Show("Receipt loaded successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Receipt not found. Please check the ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter a valid numeric Receipt ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ConfirmReturn()
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
                prompt.Text = "Confirm Return";

                Label textLabel = new Label() { Left = 12, Top = 12, Width = 340, Text = "Enter the Return password:" };
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
                    if (string.Equals(password, "rmc786!", StringComparison.Ordinal))
                        return true;

                    MessageBox.Show("Incorrect password. Return aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    // Cancel pressed
                    return false;
                }
            }
        }


        private void btnSubmitReturn_Click(object sender, EventArgs e)
        {

            if (!ConfirmReturn())
                return;

            // Ensure a receipt is loaded.
            if (_loadedReceipt == null)
            {
                MessageBox.Show("No receipt loaded. Please load a receipt first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the fee input.
            if (!decimal.TryParse(txtFee.Text.Trim(), out decimal updatedFee))
            {
                MessageBox.Show("Invalid fee. Please enter a valid decimal number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the fee in the receipt.
            _loadedReceipt.Fee = updatedFee;

            // Optionally, record that this receipt has been refunded partially or fully.

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    // Attach and update the receipt.
                    context.Receipts.Update(_loadedReceipt);
                    context.SaveChanges();
                }

                MessageBox.Show("Receipt updated successfully (Return processed).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
