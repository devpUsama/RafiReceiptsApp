namespace RafiReceiptsApp
{
    partial class HistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            dataGridHistory = new DataGridView();
            panelHistory = new Panel();
            labelHistory = new Label();
            labelHistoryPatient = new Label();
            grpTodaySummary = new GroupBox();
            lblDrFizzaSummary = new Label();
            btnPrintDaily = new Button();
            lblOthersSummary = new Label();
            lblDrJawadSummary = new Label();
            lblDrHammadSummary = new Label();
            lblDrZainSummary = new Label();
            lblTodayTotal = new Label();
            lblEcgSummary = new Label();
            lblUsgSummary = new Label();
            lblOpdSummary = new Label();
            grpMonthSummary = new GroupBox();
            btnPrintMonthly = new Button();
            lblMonthTotal = new Label();
            btnCancel = new Button();
            btnReprint = new Button();
            gbIndividualRecords = new GroupBox();
            btnDailyOther = new Button();
            btnDailyDrJawad = new Button();
            btnDailyDrHammad = new Button();
            btnDailyDrFizza = new Button();
            btnDailyDrZain = new Button();
            btnDailyUSG = new Button();
            btnDailyECG = new Button();
            btnDailyOPD = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridHistory).BeginInit();
            panelHistory.SuspendLayout();
            grpTodaySummary.SuspendLayout();
            grpMonthSummary.SuspendLayout();
            gbIndividualRecords.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridHistory
            // 
            dataGridHistory.Anchor = AnchorStyles.None;
            dataGridHistory.BackgroundColor = SystemColors.Control;
            dataGridHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHistory.Location = new Point(26, 659);
            dataGridHistory.Name = "dataGridHistory";
            dataGridHistory.RowHeadersWidth = 51;
            dataGridHistory.Size = new Size(1203, 203);
            dataGridHistory.TabIndex = 0;
            dataGridHistory.CellDoubleClick += dataGridHistory_CellDoubleClick;
            // 
            // panelHistory
            // 
            panelHistory.BackColor = Color.FromArgb(91, 42, 134);
            panelHistory.Controls.Add(labelHistory);
            panelHistory.Dock = DockStyle.Top;
            panelHistory.Location = new Point(0, 0);
            panelHistory.Name = "panelHistory";
            panelHistory.Size = new Size(1262, 75);
            panelHistory.TabIndex = 1;
            // 
            // labelHistory
            // 
            labelHistory.Anchor = AnchorStyles.Top;
            labelHistory.AutoSize = true;
            labelHistory.Font = new Font("Montserrat", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHistory.ForeColor = SystemColors.ButtonHighlight;
            labelHistory.Location = new Point(533, 9);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(183, 58);
            labelHistory.TabIndex = 1;
            labelHistory.Text = "Records";
            // 
            // labelHistoryPatient
            // 
            labelHistoryPatient.Anchor = AnchorStyles.None;
            labelHistoryPatient.AutoSize = true;
            labelHistoryPatient.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHistoryPatient.ForeColor = Color.FromArgb(91, 42, 134);
            labelHistoryPatient.Location = new Point(59, 80);
            labelHistoryPatient.Name = "labelHistoryPatient";
            labelHistoryPatient.Size = new Size(195, 30);
            labelHistoryPatient.TabIndex = 6;
            labelHistoryPatient.Text = "Records of Patients";
            // 
            // grpTodaySummary
            // 
            grpTodaySummary.Anchor = AnchorStyles.None;
            grpTodaySummary.Controls.Add(lblDrFizzaSummary);
            grpTodaySummary.Controls.Add(btnPrintDaily);
            grpTodaySummary.Controls.Add(lblOthersSummary);
            grpTodaySummary.Controls.Add(lblDrJawadSummary);
            grpTodaySummary.Controls.Add(lblDrHammadSummary);
            grpTodaySummary.Controls.Add(lblDrZainSummary);
            grpTodaySummary.Controls.Add(lblTodayTotal);
            grpTodaySummary.Controls.Add(lblEcgSummary);
            grpTodaySummary.Controls.Add(lblUsgSummary);
            grpTodaySummary.Controls.Add(lblOpdSummary);
            grpTodaySummary.Location = new Point(59, 124);
            grpTodaySummary.Name = "grpTodaySummary";
            grpTodaySummary.Size = new Size(552, 326);
            grpTodaySummary.TabIndex = 7;
            grpTodaySummary.TabStop = false;
            grpTodaySummary.Text = "Today's Summary";
            // 
            // lblDrFizzaSummary
            // 
            lblDrFizzaSummary.Anchor = AnchorStyles.Top;
            lblDrFizzaSummary.AutoSize = true;
            lblDrFizzaSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrFizzaSummary.Location = new Point(42, 122);
            lblDrFizzaSummary.Name = "lblDrFizzaSummary";
            lblDrFizzaSummary.Size = new Size(181, 30);
            lblDrFizzaSummary.TabIndex = 28;
            lblDrFizzaSummary.Text = "Dr Fizza Summary";
            // 
            // btnPrintDaily
            // 
            btnPrintDaily.Anchor = AnchorStyles.Top;
            btnPrintDaily.BackColor = Color.WhiteSmoke;
            btnPrintDaily.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnPrintDaily.FlatAppearance.BorderSize = 2;
            btnPrintDaily.FlatStyle = FlatStyle.Flat;
            btnPrintDaily.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintDaily.ForeColor = Color.FromArgb(91, 42, 134);
            btnPrintDaily.Location = new Point(390, 260);
            btnPrintDaily.Name = "btnPrintDaily";
            btnPrintDaily.Size = new Size(150, 50);
            btnPrintDaily.TabIndex = 27;
            btnPrintDaily.Text = "Print Today's";
            btnPrintDaily.UseVisualStyleBackColor = false;
            btnPrintDaily.Click += btnPrintDaily_Click;
            // 
            // lblOthersSummary
            // 
            lblOthersSummary.Anchor = AnchorStyles.Top;
            lblOthersSummary.AutoSize = true;
            lblOthersSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOthersSummary.Location = new Point(42, 198);
            lblOthersSummary.Name = "lblOthersSummary";
            lblOthersSummary.Size = new Size(143, 30);
            lblOthersSummary.TabIndex = 26;
            lblOthersSummary.Text = "Other Doctors";
            // 
            // lblDrJawadSummary
            // 
            lblDrJawadSummary.Anchor = AnchorStyles.Top;
            lblDrJawadSummary.AutoSize = true;
            lblDrJawadSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrJawadSummary.Location = new Point(42, 172);
            lblDrJawadSummary.Name = "lblDrJawadSummary";
            lblDrJawadSummary.Size = new Size(197, 30);
            lblDrJawadSummary.TabIndex = 25;
            lblDrJawadSummary.Text = "Dr Jawad Summary";
            // 
            // lblDrHammadSummary
            // 
            lblDrHammadSummary.Anchor = AnchorStyles.Top;
            lblDrHammadSummary.AutoSize = true;
            lblDrHammadSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrHammadSummary.Location = new Point(42, 148);
            lblDrHammadSummary.Name = "lblDrHammadSummary";
            lblDrHammadSummary.Size = new Size(223, 30);
            lblDrHammadSummary.TabIndex = 24;
            lblDrHammadSummary.Text = "Dr Hammad Summary";
            // 
            // lblDrZainSummary
            // 
            lblDrZainSummary.Anchor = AnchorStyles.Top;
            lblDrZainSummary.AutoSize = true;
            lblDrZainSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrZainSummary.Location = new Point(42, 98);
            lblDrZainSummary.Name = "lblDrZainSummary";
            lblDrZainSummary.Size = new Size(175, 30);
            lblDrZainSummary.TabIndex = 23;
            lblDrZainSummary.Text = "Dr Zain Summary";
            // 
            // lblTodayTotal
            // 
            lblTodayTotal.Anchor = AnchorStyles.Top;
            lblTodayTotal.AutoSize = true;
            lblTodayTotal.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayTotal.ForeColor = Color.Red;
            lblTodayTotal.Location = new Point(42, 221);
            lblTodayTotal.Name = "lblTodayTotal";
            lblTodayTotal.Size = new Size(142, 30);
            lblTodayTotal.TabIndex = 22;
            lblTodayTotal.Text = "Overall Today";
            // 
            // lblEcgSummary
            // 
            lblEcgSummary.Anchor = AnchorStyles.Top;
            lblEcgSummary.AutoSize = true;
            lblEcgSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEcgSummary.Location = new Point(42, 49);
            lblEcgSummary.Name = "lblEcgSummary";
            lblEcgSummary.Size = new Size(148, 30);
            lblEcgSummary.TabIndex = 21;
            lblEcgSummary.Text = "ECG Summary";
            // 
            // lblUsgSummary
            // 
            lblUsgSummary.Anchor = AnchorStyles.Top;
            lblUsgSummary.AutoSize = true;
            lblUsgSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsgSummary.Location = new Point(42, 74);
            lblUsgSummary.Name = "lblUsgSummary";
            lblUsgSummary.Size = new Size(147, 30);
            lblUsgSummary.TabIndex = 20;
            lblUsgSummary.Text = "USG Summary";
            // 
            // lblOpdSummary
            // 
            lblOpdSummary.Anchor = AnchorStyles.Top;
            lblOpdSummary.AutoSize = true;
            lblOpdSummary.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpdSummary.Location = new Point(42, 23);
            lblOpdSummary.Name = "lblOpdSummary";
            lblOpdSummary.Size = new Size(148, 30);
            lblOpdSummary.TabIndex = 19;
            lblOpdSummary.Text = "OPD Summary";
            // 
            // grpMonthSummary
            // 
            grpMonthSummary.Anchor = AnchorStyles.None;
            grpMonthSummary.Controls.Add(btnPrintMonthly);
            grpMonthSummary.Controls.Add(lblMonthTotal);
            grpMonthSummary.Location = new Point(624, 124);
            grpMonthSummary.Name = "grpMonthSummary";
            grpMonthSummary.Size = new Size(548, 174);
            grpMonthSummary.TabIndex = 8;
            grpMonthSummary.TabStop = false;
            grpMonthSummary.Text = "Monthly Summary";
            // 
            // btnPrintMonthly
            // 
            btnPrintMonthly.Anchor = AnchorStyles.Top;
            btnPrintMonthly.BackColor = Color.WhiteSmoke;
            btnPrintMonthly.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnPrintMonthly.FlatAppearance.BorderSize = 2;
            btnPrintMonthly.FlatStyle = FlatStyle.Flat;
            btnPrintMonthly.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintMonthly.ForeColor = Color.FromArgb(91, 42, 134);
            btnPrintMonthly.Location = new Point(392, 113);
            btnPrintMonthly.Name = "btnPrintMonthly";
            btnPrintMonthly.Size = new Size(150, 50);
            btnPrintMonthly.TabIndex = 24;
            btnPrintMonthly.Text = "Print Monthly";
            btnPrintMonthly.UseVisualStyleBackColor = false;
            btnPrintMonthly.Click += btnPrintMonthly_Click;
            // 
            // lblMonthTotal
            // 
            lblMonthTotal.Anchor = AnchorStyles.Top;
            lblMonthTotal.AutoSize = true;
            lblMonthTotal.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthTotal.ForeColor = Color.Red;
            lblMonthTotal.Location = new Point(6, 37);
            lblMonthTotal.Name = "lblMonthTotal";
            lblMonthTotal.Size = new Size(376, 30);
            lblMonthTotal.TabIndex = 23;
            lblMonthTotal.Text = "This Month’s Total Tokens and Amount";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(91, 42, 134);
            btnCancel.Location = new Point(1078, 882);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 50);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel [Esc]";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnReprint
            // 
            btnReprint.Anchor = AnchorStyles.None;
            btnReprint.BackColor = Color.FromArgb(91, 42, 134);
            btnReprint.FlatStyle = FlatStyle.Flat;
            btnReprint.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReprint.ForeColor = SystemColors.ButtonHighlight;
            btnReprint.Location = new Point(909, 882);
            btnReprint.Name = "btnReprint";
            btnReprint.Size = new Size(150, 50);
            btnReprint.TabIndex = 10;
            btnReprint.Text = "Re-Print [F4]";
            btnReprint.UseVisualStyleBackColor = false;
            btnReprint.Click += btnReprint_Click;
            // 
            // gbIndividualRecords
            // 
            gbIndividualRecords.Anchor = AnchorStyles.None;
            gbIndividualRecords.Controls.Add(btnDailyOther);
            gbIndividualRecords.Controls.Add(btnDailyDrJawad);
            gbIndividualRecords.Controls.Add(btnDailyDrHammad);
            gbIndividualRecords.Controls.Add(btnDailyDrFizza);
            gbIndividualRecords.Controls.Add(btnDailyDrZain);
            gbIndividualRecords.Controls.Add(btnDailyUSG);
            gbIndividualRecords.Controls.Add(btnDailyECG);
            gbIndividualRecords.Controls.Add(btnDailyOPD);
            gbIndividualRecords.Location = new Point(59, 466);
            gbIndividualRecords.Name = "gbIndividualRecords";
            gbIndividualRecords.Size = new Size(1113, 164);
            gbIndividualRecords.TabIndex = 12;
            gbIndividualRecords.TabStop = false;
            gbIndividualRecords.Text = "Individual Records";
            // 
            // btnDailyOther
            // 
            btnDailyOther.Anchor = AnchorStyles.Top;
            btnDailyOther.BackColor = Color.WhiteSmoke;
            btnDailyOther.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyOther.FlatAppearance.BorderSize = 2;
            btnDailyOther.FlatStyle = FlatStyle.Flat;
            btnDailyOther.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyOther.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyOther.Location = new Point(605, 94);
            btnDailyOther.Name = "btnDailyOther";
            btnDailyOther.Size = new Size(150, 50);
            btnDailyOther.TabIndex = 35;
            btnDailyOther.Text = "Others";
            btnDailyOther.UseVisualStyleBackColor = false;
            btnDailyOther.Click += btnDailyOther_Click;
            // 
            // btnDailyDrJawad
            // 
            btnDailyDrJawad.Anchor = AnchorStyles.Top;
            btnDailyDrJawad.BackColor = Color.WhiteSmoke;
            btnDailyDrJawad.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrJawad.FlatAppearance.BorderSize = 2;
            btnDailyDrJawad.FlatStyle = FlatStyle.Flat;
            btnDailyDrJawad.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrJawad.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrJawad.Location = new Point(380, 94);
            btnDailyDrJawad.Name = "btnDailyDrJawad";
            btnDailyDrJawad.Size = new Size(150, 50);
            btnDailyDrJawad.TabIndex = 34;
            btnDailyDrJawad.Text = "Dr Jawad";
            btnDailyDrJawad.UseVisualStyleBackColor = false;
            btnDailyDrJawad.Click += btnDailyDrJawad_Click;
            // 
            // btnDailyDrHammad
            // 
            btnDailyDrHammad.Anchor = AnchorStyles.Top;
            btnDailyDrHammad.BackColor = Color.WhiteSmoke;
            btnDailyDrHammad.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrHammad.FlatAppearance.BorderSize = 2;
            btnDailyDrHammad.FlatStyle = FlatStyle.Flat;
            btnDailyDrHammad.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrHammad.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrHammad.Location = new Point(943, 26);
            btnDailyDrHammad.Name = "btnDailyDrHammad";
            btnDailyDrHammad.Size = new Size(150, 50);
            btnDailyDrHammad.TabIndex = 33;
            btnDailyDrHammad.Text = "Dr Hammad";
            btnDailyDrHammad.UseVisualStyleBackColor = false;
            btnDailyDrHammad.Click += btnDailyDrHammad_Click;
            // 
            // btnDailyDrFizza
            // 
            btnDailyDrFizza.Anchor = AnchorStyles.Top;
            btnDailyDrFizza.BackColor = Color.WhiteSmoke;
            btnDailyDrFizza.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrFizza.FlatAppearance.BorderSize = 2;
            btnDailyDrFizza.FlatStyle = FlatStyle.Flat;
            btnDailyDrFizza.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrFizza.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrFizza.Location = new Point(761, 26);
            btnDailyDrFizza.Name = "btnDailyDrFizza";
            btnDailyDrFizza.Size = new Size(150, 50);
            btnDailyDrFizza.TabIndex = 32;
            btnDailyDrFizza.Text = "Dr Fizza";
            btnDailyDrFizza.UseVisualStyleBackColor = false;
            btnDailyDrFizza.Click += btnDailyDrFizza_Click;
            // 
            // btnDailyDrZain
            // 
            btnDailyDrZain.Anchor = AnchorStyles.Top;
            btnDailyDrZain.BackColor = Color.WhiteSmoke;
            btnDailyDrZain.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrZain.FlatAppearance.BorderSize = 2;
            btnDailyDrZain.FlatStyle = FlatStyle.Flat;
            btnDailyDrZain.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrZain.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrZain.Location = new Point(580, 26);
            btnDailyDrZain.Name = "btnDailyDrZain";
            btnDailyDrZain.Size = new Size(150, 50);
            btnDailyDrZain.TabIndex = 31;
            btnDailyDrZain.Text = "Dr Zain";
            btnDailyDrZain.UseVisualStyleBackColor = false;
            btnDailyDrZain.Click += btnDailyDrZain_Click;
            // 
            // btnDailyUSG
            // 
            btnDailyUSG.Anchor = AnchorStyles.Top;
            btnDailyUSG.BackColor = Color.WhiteSmoke;
            btnDailyUSG.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyUSG.FlatAppearance.BorderSize = 2;
            btnDailyUSG.FlatStyle = FlatStyle.Flat;
            btnDailyUSG.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyUSG.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyUSG.Location = new Point(399, 26);
            btnDailyUSG.Name = "btnDailyUSG";
            btnDailyUSG.Size = new Size(150, 50);
            btnDailyUSG.TabIndex = 30;
            btnDailyUSG.Text = "USG";
            btnDailyUSG.UseVisualStyleBackColor = false;
            btnDailyUSG.Click += btnDailyUSG_Click;
            // 
            // btnDailyECG
            // 
            btnDailyECG.Anchor = AnchorStyles.Top;
            btnDailyECG.BackColor = Color.WhiteSmoke;
            btnDailyECG.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyECG.FlatAppearance.BorderSize = 2;
            btnDailyECG.FlatStyle = FlatStyle.Flat;
            btnDailyECG.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyECG.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyECG.Location = new Point(216, 26);
            btnDailyECG.Name = "btnDailyECG";
            btnDailyECG.Size = new Size(150, 50);
            btnDailyECG.TabIndex = 29;
            btnDailyECG.Text = "ECG";
            btnDailyECG.UseVisualStyleBackColor = false;
            btnDailyECG.Click += btnDailyECG_Click;
            // 
            // btnDailyOPD
            // 
            btnDailyOPD.Anchor = AnchorStyles.Top;
            btnDailyOPD.BackColor = Color.WhiteSmoke;
            btnDailyOPD.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyOPD.FlatAppearance.BorderSize = 2;
            btnDailyOPD.FlatStyle = FlatStyle.Flat;
            btnDailyOPD.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyOPD.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyOPD.Location = new Point(34, 26);
            btnDailyOPD.Name = "btnDailyOPD";
            btnDailyOPD.Size = new Size(150, 50);
            btnDailyOPD.TabIndex = 28;
            btnDailyOPD.Text = "OPD";
            btnDailyOPD.UseVisualStyleBackColor = false;
            btnDailyOPD.Click += btnDailyOPD_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1262, 953);
            Controls.Add(gbIndividualRecords);
            Controls.Add(btnCancel);
            Controls.Add(btnReprint);
            Controls.Add(grpMonthSummary);
            Controls.Add(grpTodaySummary);
            Controls.Add(labelHistoryPatient);
            Controls.Add(panelHistory);
            Controls.Add(dataGridHistory);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MinimumSize = new Size(1280, 720);
            Name = "HistoryForm";
            Text = "Records";
            Load += HistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridHistory).EndInit();
            panelHistory.ResumeLayout(false);
            panelHistory.PerformLayout();
            grpTodaySummary.ResumeLayout(false);
            grpTodaySummary.PerformLayout();
            grpMonthSummary.ResumeLayout(false);
            grpMonthSummary.PerformLayout();
            gbIndividualRecords.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridHistory;
        private Panel panelHistory;
        private Label labelHistory;
        private Label labelHistoryPatient;
        private GroupBox grpTodaySummary;
        private Label lblTodayTotal;
        private Label lblEcgSummary;
        private Label lblUsgSummary;
        private Label lblOpdSummary;
        private GroupBox grpMonthSummary;
        private Label lblMonthTotal;
        private Label lblOthersSummary;
        private Label lblDrJawadSummary;
        private Label lblDrHammadSummary;
        private Label lblDrZainSummary;
        private Button btnPrintDaily;
        private Button btnPrintMonthly;
        private Label lblDrFizzaSummary;
        private Button btnCancel;
        private Button btnReprint;
        private GroupBox gbIndividualRecords;
        private Button btnDailyOther;
        private Button btnDailyDrJawad;
        private Button btnDailyDrHammad;
        private Button btnDailyDrFizza;
        private Button btnDailyDrZain;
        private Button btnDailyUSG;
        private Button btnDailyECG;
        private Button btnDailyOPD;
    }
}