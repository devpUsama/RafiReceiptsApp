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
    public partial class EditReceiptForm : Form
    {

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check for F2 to submit
            if (keyData == Keys.F2)
            {
                // Perform the click for the save/generate button.
                btnSave.PerformClick();
                return true;
            }
            // Check for F3 to cancel
            else if (keyData == Keys.Escape)
            {
                btnCancel.PerformClick();
                return true;
            }
            // Check for del to cancel
            else if (keyData == Keys.Delete)
            {
                btnDelete.PerformClick();
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

        private Receipt _receipt;

        public EditReceiptForm(Receipt receipt)
        {
            InitializeComponent();
            _receipt = receipt;

            // Prepopulate fields with _receipt values.
            txtPatientName.Text = _receipt.PatientName;
            txtAddress.Text = _receipt.Address;
            // Since we previously hid Mobile for all, skip it.
            txtTemperature.Text = _receipt.Temperature;
            txtBP.Text = _receipt.BloodPressure;
            txtFee.Text = _receipt.Fee.ToString("F2");
            txtDoctorName.Text = _receipt.DoctorName;

            // If the receipt type is USG, load and display the USG combobox.
            if (_receipt.TokenType == "USG")
            {
                cmbUSGType.Visible = true;
                lblUSGType.Visible = true;
                using (var context = new ApplicationDbContext())
                {
                    var usgTypes = context.PriceSettings
                                          .Where(p => p.Category == "USG")
                                          .OrderBy(p => p.Id)
                                          .Select(p => p.SubType)
                                          .ToList();
                    cmbUSGType.Items.Clear();
                    foreach (var type in usgTypes)
                        cmbUSGType.Items.Add(type);
                }
                // Optionally select based on stored data if you added a property for USG type.
                // cmbUSGType.SelectedItem = _receipt.USGType;
            }
        }

        private bool ConfirmUpdate()
        {
            string password = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the Updation password:", "Confirm Update", "");
            // Hardcode your password here (for example: "admin123")
            if (password == "rmc@890")
                return true;
            else
            {
                MessageBox.Show("Incorrect password. Update aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!ConfirmUpdate())
                return;

            // Validate and update _receipt with new values.
            _receipt.PatientName = txtPatientName.Text.Trim();
            _receipt.Address = txtAddress.Text.Trim();
            _receipt.Temperature = txtTemperature.Text.Trim();
            _receipt.BloodPressure = txtBP.Text.Trim();
            _receipt.DoctorName = txtDoctorName.Text.Trim();
            _receipt.Fee = decimal.Parse(txtFee.Text);

            // If USG, you might update _receipt.USGType accordingly.

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    // Attach and mark the entity as modified.
                    context.Receipts.Update(_receipt);
                    context.SaveChanges();
                }
                MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool ConfirmDeletion()
        {
            string password = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter the deletion password:", "Confirm Deletion", "");
            // Hardcode your password here (for example: "admin123")
            if (password == "Ghost@rmc")
                return true;
            else
            {
                MessageBox.Show("Incorrect password. Deletion aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!ConfirmDeletion())
                return;

            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Receipts.Remove(_receipt);
                    context.SaveChanges();
                }
                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
