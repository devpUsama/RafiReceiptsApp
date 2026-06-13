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
    public partial class AdminPricesForm : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            // Check for F1 to close
            if (keyData == Keys.Escape)
            {
                // close the form.
                this.Close();
                return true;
            }
            // Check for F2 to save
            if (keyData == Keys.F2)
            {
                // close the form.
                btnSavePrices.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        public AdminPricesForm()
        {
            InitializeComponent();
        }

        private void AdminPricesForm_Load(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var priceList = context.PriceSettings.OrderBy(p => p.Category).ThenBy(p => p.SubType).ToList();
                dataGridPrices.DataSource = priceList;
            }
        }

        private bool ConfirmSave()
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
                prompt.Text = "Confirm Update";

                Label textLabel = new Label() { Left = 12, Top = 12, Width = 340, Text = "Enter the Updation password:" };
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
                    if (string.Equals(password, "321321", StringComparison.Ordinal))
                        return true;

                    MessageBox.Show("Incorrect password. Update aborted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    // Cancel pressed
                    return false;
                }
            }
        }


        private void btnSavePrices_Click(object sender, EventArgs e)
        {

            if (!ConfirmSave())
                return;
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    // Since the DataSource is a List<PriceSetting>, we need to update each item.
                    var updatedPrices = dataGridPrices.DataSource as List<PriceSetting>;
                    if (updatedPrices != null)
                    {
                        foreach (var item in updatedPrices)
                        {
                            // Attach and mark as modified
                            context.PriceSettings.Update(item);
                        }
                        context.SaveChanges();
                    }
                }
                MessageBox.Show("Prices updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating prices: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
