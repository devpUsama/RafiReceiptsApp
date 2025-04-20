namespace RafiReceiptsApp
{
    partial class AdminPricesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPricesForm));
            panelPriceSet = new Panel();
            lblPriceUpdate = new Label();
            dataGridPrices = new DataGridView();
            btnSavePrices = new Button();
            panelPriceSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPrices).BeginInit();
            SuspendLayout();
            // 
            // panelPriceSet
            // 
            panelPriceSet.BackColor = Color.FromArgb(91, 42, 134);
            panelPriceSet.Controls.Add(lblPriceUpdate);
            panelPriceSet.Dock = DockStyle.Top;
            panelPriceSet.Location = new Point(0, 0);
            panelPriceSet.Name = "panelPriceSet";
            panelPriceSet.Size = new Size(782, 75);
            panelPriceSet.TabIndex = 0;
            // 
            // lblPriceUpdate
            // 
            lblPriceUpdate.Anchor = AnchorStyles.Top;
            lblPriceUpdate.AutoSize = true;
            lblPriceUpdate.Font = new Font("Montserrat", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceUpdate.ForeColor = SystemColors.ButtonHighlight;
            lblPriceUpdate.Location = new Point(259, 15);
            lblPriceUpdate.Name = "lblPriceUpdate";
            lblPriceUpdate.Size = new Size(227, 47);
            lblPriceUpdate.TabIndex = 1;
            lblPriceUpdate.Text = "Price Update";
            lblPriceUpdate.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridPrices
            // 
            dataGridPrices.Anchor = AnchorStyles.None;
            dataGridPrices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPrices.Location = new Point(25, 100);
            dataGridPrices.Name = "dataGridPrices";
            dataGridPrices.RowHeadersWidth = 51;
            dataGridPrices.Size = new Size(734, 367);
            dataGridPrices.TabIndex = 1;
            // 
            // btnSavePrices
            // 
            btnSavePrices.Anchor = AnchorStyles.None;
            btnSavePrices.BackColor = Color.FromArgb(91, 42, 134);
            btnSavePrices.FlatStyle = FlatStyle.Flat;
            btnSavePrices.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSavePrices.ForeColor = SystemColors.ButtonHighlight;
            btnSavePrices.Location = new Point(580, 491);
            btnSavePrices.Name = "btnSavePrices";
            btnSavePrices.Size = new Size(179, 50);
            btnSavePrices.TabIndex = 14;
            btnSavePrices.Text = "Save Prices [F2]";
            btnSavePrices.UseVisualStyleBackColor = false;
            btnSavePrices.Click += btnSavePrices_Click;
            // 
            // AdminPricesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(782, 553);
            Controls.Add(btnSavePrices);
            Controls.Add(dataGridPrices);
            Controls.Add(panelPriceSet);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximumSize = new Size(800, 600);
            MinimumSize = new Size(800, 600);
            Name = "AdminPricesForm";
            Text = "Price Update";
            Load += AdminPricesForm_Load;
            panelPriceSet.ResumeLayout(false);
            panelPriceSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPrices).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPriceSet;
        private Label lblPriceUpdate;
        private DataGridView dataGridPrices;
        private Button btnSavePrices;
    }
}