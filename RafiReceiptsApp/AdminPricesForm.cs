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
            if (keyData == Keys.F1)
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

        private void btnSavePrices_Click(object sender, EventArgs e)
        {
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
