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
            lblDrMinahilSummary = new Label();
            lblDrZuhaibSummary = new Label();
            lblDrTehreemSummary = new Label();
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
            lblDrMinahilSummaryMonth = new Label();
            lblDrZuhaibSummaryMonth = new Label();
            lblDrTehreemSummaryMonth = new Label();
            lblDrFizzaSummaryMonth = new Label();
            lblOthersSummaryMonth = new Label();
            lblDrJawadSummaryMonth = new Label();
            lblDrHammadSummaryMonth = new Label();
            lblDrZainSummaryMonth = new Label();
            lblEcgSummaryMonth = new Label();
            lblUsgSummaryMonth = new Label();
            lblOpdSummaryMonth = new Label();
            btnPrintMonthly = new Button();
            lblMonthTotal = new Label();
            btnCancel = new Button();
            btnReprint = new Button();
            gbIndividualRecords = new GroupBox();
            btnDailyDrZuhaib = new Button();
            btnDailyDrTehreem = new Button();
            btnDailyOther = new Button();
            btnDailyDrJawad = new Button();
            btnDailyDrHammad = new Button();
            btnDailyDrFizza = new Button();
            btnDailyDrZain = new Button();
            btnDailyUSG = new Button();
            btnDailyECG = new Button();
            btnDailyOPD = new Button();
            btnDailyDrMinahil = new Button();
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
            dataGridHistory.Location = new Point(56, 1487);
            dataGridHistory.Margin = new Padding(7, 5, 7, 5);
            dataGridHistory.Name = "dataGridHistory";
            dataGridHistory.RowHeadersWidth = 51;
            dataGridHistory.Size = new Size(2557, 415);
            dataGridHistory.TabIndex = 0;
            dataGridHistory.CellDoubleClick += dataGridHistory_CellDoubleClick;
            // 
            // panelHistory
            // 
            panelHistory.BackColor = Color.FromArgb(91, 42, 134);
            panelHistory.Controls.Add(labelHistory);
            panelHistory.Dock = DockStyle.Top;
            panelHistory.Location = new Point(0, 0);
            panelHistory.Margin = new Padding(7, 5, 7, 5);
            panelHistory.Name = "panelHistory";
            panelHistory.Size = new Size(2686, 153);
            panelHistory.TabIndex = 1;
            // 
            // labelHistory
            // 
            labelHistory.Anchor = AnchorStyles.Top;
            labelHistory.AutoSize = true;
            labelHistory.Font = new Font("Microsoft Sans Serif", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHistory.ForeColor = SystemColors.ButtonHighlight;
            labelHistory.Location = new Point(1134, 19);
            labelHistory.Margin = new Padding(7, 0, 7, 0);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(319, 85);
            labelHistory.TabIndex = 1;
            labelHistory.Text = "Records";
            // 
            // labelHistoryPatient
            // 
            labelHistoryPatient.Anchor = AnchorStyles.None;
            labelHistoryPatient.AutoSize = true;
            labelHistoryPatient.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHistoryPatient.ForeColor = Color.FromArgb(91, 42, 134);
            labelHistoryPatient.Location = new Point(126, 194);
            labelHistoryPatient.Margin = new Padding(7, 0, 7, 0);
            labelHistoryPatient.Name = "labelHistoryPatient";
            labelHistoryPatient.Size = new Size(332, 39);
            labelHistoryPatient.TabIndex = 6;
            labelHistoryPatient.Text = "Records of Patients";
            // 
            // grpTodaySummary
            // 
            grpTodaySummary.Anchor = AnchorStyles.None;
            grpTodaySummary.Controls.Add(lblDrMinahilSummary);
            grpTodaySummary.Controls.Add(lblDrZuhaibSummary);
            grpTodaySummary.Controls.Add(lblDrTehreemSummary);
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
            grpTodaySummary.Location = new Point(126, 261);
            grpTodaySummary.Margin = new Padding(7, 5, 7, 5);
            grpTodaySummary.Name = "grpTodaySummary";
            grpTodaySummary.Padding = new Padding(7, 5, 7, 5);
            grpTodaySummary.Size = new Size(1173, 783);
            grpTodaySummary.TabIndex = 7;
            grpTodaySummary.TabStop = false;
            grpTodaySummary.Text = "Today's Summary";
            // 
            // lblDrMinahilSummary
            // 
            lblDrMinahilSummary.Anchor = AnchorStyles.Top;
            lblDrMinahilSummary.AutoSize = true;
            lblDrMinahilSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrMinahilSummary.Location = new Point(90, 507);
            lblDrMinahilSummary.Margin = new Padding(7, 0, 7, 0);
            lblDrMinahilSummary.Name = "lblDrMinahilSummary";
            lblDrMinahilSummary.Size = new Size(343, 39);
            lblDrMinahilSummary.TabIndex = 31;
            lblDrMinahilSummary.Text = "Dr Minahil Summary";
            // 
            // lblDrZuhaibSummary
            // 
            lblDrZuhaibSummary.Anchor = AnchorStyles.Top;
            lblDrZuhaibSummary.AutoSize = true;
            lblDrZuhaibSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrZuhaibSummary.Location = new Point(90, 456);
            lblDrZuhaibSummary.Margin = new Padding(7, 0, 7, 0);
            lblDrZuhaibSummary.Name = "lblDrZuhaibSummary";
            lblDrZuhaibSummary.Size = new Size(338, 39);
            lblDrZuhaibSummary.TabIndex = 30;
            lblDrZuhaibSummary.Text = "Dr Zuhaib Summary";
            // 
            // lblDrTehreemSummary
            // 
            lblDrTehreemSummary.Anchor = AnchorStyles.Top;
            lblDrTehreemSummary.AutoSize = true;
            lblDrTehreemSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrTehreemSummary.Location = new Point(90, 407);
            lblDrTehreemSummary.Margin = new Padding(7, 0, 7, 0);
            lblDrTehreemSummary.Name = "lblDrTehreemSummary";
            lblDrTehreemSummary.Size = new Size(370, 39);
            lblDrTehreemSummary.TabIndex = 29;
            lblDrTehreemSummary.Text = "Dr Tehreem Summary";
            // 
            // lblDrFizzaSummary
            // 
            lblDrFizzaSummary.Anchor = AnchorStyles.Top;
            lblDrFizzaSummary.AutoSize = true;
            lblDrFizzaSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrFizzaSummary.Location = new Point(90, 251);
            lblDrFizzaSummary.Margin = new Padding(7, 0, 7, 0);
            lblDrFizzaSummary.Name = "lblDrFizzaSummary";
            lblDrFizzaSummary.Size = new Size(314, 39);
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
            btnPrintDaily.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintDaily.ForeColor = Color.FromArgb(91, 42, 134);
            btnPrintDaily.Location = new Point(828, 669);
            btnPrintDaily.Margin = new Padding(7, 5, 7, 5);
            btnPrintDaily.Name = "btnPrintDaily";
            btnPrintDaily.Size = new Size(318, 104);
            btnPrintDaily.TabIndex = 27;
            btnPrintDaily.Text = "Print Today's";
            btnPrintDaily.UseVisualStyleBackColor = false;
            btnPrintDaily.Click += btnPrintDaily_Click;
            // 
            // lblOthersSummary
            // 
            lblOthersSummary.Anchor = AnchorStyles.Top;
            lblOthersSummary.AutoSize = true;
            lblOthersSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOthersSummary.Location = new Point(90, 555);
            lblOthersSummary.Margin = new Padding(7, 0, 7, 0);
            lblOthersSummary.Name = "lblOthersSummary";
            lblOthersSummary.Size = new Size(240, 39);
            lblOthersSummary.TabIndex = 26;
            lblOthersSummary.Text = "Other Doctors";
            // 
            // lblDrJawadSummary
            // 
            lblDrJawadSummary.Anchor = AnchorStyles.Top;
            lblDrJawadSummary.AutoSize = true;
            lblDrJawadSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrJawadSummary.Location = new Point(90, 353);
            lblDrJawadSummary.Margin = new Padding(7, 0, 7, 0);
            lblDrJawadSummary.Name = "lblDrJawadSummary";
            lblDrJawadSummary.Size = new Size(331, 39);
            lblDrJawadSummary.TabIndex = 25;
            lblDrJawadSummary.Text = "Dr Jawad Summary";
            // 
            // lblDrHammadSummary
            // 
            lblDrHammadSummary.Anchor = AnchorStyles.Top;
            lblDrHammadSummary.AutoSize = true;
            lblDrHammadSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrHammadSummary.Location = new Point(90, 303);
            lblDrHammadSummary.Margin = new Padding(7, 0, 7, 0);
            lblDrHammadSummary.Name = "lblDrHammadSummary";
            lblDrHammadSummary.Size = new Size(371, 39);
            lblDrHammadSummary.TabIndex = 24;
            lblDrHammadSummary.Text = "Dr Hammad Summary";
            // 
            // lblDrZainSummary
            // 
            lblDrZainSummary.Anchor = AnchorStyles.Top;
            lblDrZainSummary.AutoSize = true;
            lblDrZainSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrZainSummary.Location = new Point(90, 202);
            lblDrZainSummary.Margin = new Padding(7, 0, 7, 0);
            lblDrZainSummary.Name = "lblDrZainSummary";
            lblDrZainSummary.Size = new Size(298, 39);
            lblDrZainSummary.TabIndex = 23;
            lblDrZainSummary.Text = "Dr Zain Summary";
            // 
            // lblTodayTotal
            // 
            lblTodayTotal.Anchor = AnchorStyles.Top;
            lblTodayTotal.AutoSize = true;
            lblTodayTotal.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayTotal.ForeColor = Color.Red;
            lblTodayTotal.Location = new Point(90, 603);
            lblTodayTotal.Margin = new Padding(7, 0, 7, 0);
            lblTodayTotal.Name = "lblTodayTotal";
            lblTodayTotal.Size = new Size(242, 39);
            lblTodayTotal.TabIndex = 22;
            lblTodayTotal.Text = "Overall Today";
            // 
            // lblEcgSummary
            // 
            lblEcgSummary.Anchor = AnchorStyles.Top;
            lblEcgSummary.AutoSize = true;
            lblEcgSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEcgSummary.Location = new Point(90, 101);
            lblEcgSummary.Margin = new Padding(7, 0, 7, 0);
            lblEcgSummary.Name = "lblEcgSummary";
            lblEcgSummary.Size = new Size(256, 39);
            lblEcgSummary.TabIndex = 21;
            lblEcgSummary.Text = "ECG Summary";
            // 
            // lblUsgSummary
            // 
            lblUsgSummary.Anchor = AnchorStyles.Top;
            lblUsgSummary.AutoSize = true;
            lblUsgSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsgSummary.Location = new Point(90, 153);
            lblUsgSummary.Margin = new Padding(7, 0, 7, 0);
            lblUsgSummary.Name = "lblUsgSummary";
            lblUsgSummary.Size = new Size(256, 39);
            lblUsgSummary.TabIndex = 20;
            lblUsgSummary.Text = "USG Summary";
            // 
            // lblOpdSummary
            // 
            lblOpdSummary.Anchor = AnchorStyles.Top;
            lblOpdSummary.AutoSize = true;
            lblOpdSummary.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpdSummary.Location = new Point(90, 46);
            lblOpdSummary.Margin = new Padding(7, 0, 7, 0);
            lblOpdSummary.Name = "lblOpdSummary";
            lblOpdSummary.Size = new Size(256, 39);
            lblOpdSummary.TabIndex = 19;
            lblOpdSummary.Text = "OPD Summary";
            // 
            // grpMonthSummary
            // 
            grpMonthSummary.Anchor = AnchorStyles.None;
            grpMonthSummary.Controls.Add(lblDrMinahilSummaryMonth);
            grpMonthSummary.Controls.Add(lblDrZuhaibSummaryMonth);
            grpMonthSummary.Controls.Add(lblDrTehreemSummaryMonth);
            grpMonthSummary.Controls.Add(lblDrFizzaSummaryMonth);
            grpMonthSummary.Controls.Add(lblOthersSummaryMonth);
            grpMonthSummary.Controls.Add(lblDrJawadSummaryMonth);
            grpMonthSummary.Controls.Add(lblDrHammadSummaryMonth);
            grpMonthSummary.Controls.Add(lblDrZainSummaryMonth);
            grpMonthSummary.Controls.Add(lblEcgSummaryMonth);
            grpMonthSummary.Controls.Add(lblUsgSummaryMonth);
            grpMonthSummary.Controls.Add(lblOpdSummaryMonth);
            grpMonthSummary.Controls.Add(btnPrintMonthly);
            grpMonthSummary.Controls.Add(lblMonthTotal);
            grpMonthSummary.Location = new Point(1326, 261);
            grpMonthSummary.Margin = new Padding(7, 5, 7, 5);
            grpMonthSummary.Name = "grpMonthSummary";
            grpMonthSummary.Padding = new Padding(7, 5, 7, 5);
            grpMonthSummary.Size = new Size(1166, 783);
            grpMonthSummary.TabIndex = 8;
            grpMonthSummary.TabStop = false;
            grpMonthSummary.Text = "Monthly Summary";
            // 
            // lblDrMinahilSummaryMonth
            // 
            lblDrMinahilSummaryMonth.Anchor = AnchorStyles.Top;
            lblDrMinahilSummaryMonth.AutoSize = true;
            lblDrMinahilSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrMinahilSummaryMonth.Location = new Point(17, 508);
            lblDrMinahilSummaryMonth.Margin = new Padding(7, 0, 7, 0);
            lblDrMinahilSummaryMonth.Name = "lblDrMinahilSummaryMonth";
            lblDrMinahilSummaryMonth.Size = new Size(343, 39);
            lblDrMinahilSummaryMonth.TabIndex = 41;
            lblDrMinahilSummaryMonth.Text = "Dr Minahil Summary";
            // 
            // lblDrZuhaibSummaryMonth
            // 
            lblDrZuhaibSummaryMonth.Anchor = AnchorStyles.Top;
            lblDrZuhaibSummaryMonth.AutoSize = true;
            lblDrZuhaibSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrZuhaibSummaryMonth.Location = new Point(17, 465);
            lblDrZuhaibSummaryMonth.Margin = new Padding(7, 0, 7, 0);
            lblDrZuhaibSummaryMonth.Name = "lblDrZuhaibSummaryMonth";
            lblDrZuhaibSummaryMonth.Size = new Size(338, 39);
            lblDrZuhaibSummaryMonth.TabIndex = 40;
            lblDrZuhaibSummaryMonth.Text = "Dr Zuhaib Summary";
            // 
            // lblDrTehreemSummaryMonth
            // 
            lblDrTehreemSummaryMonth.Anchor = AnchorStyles.Top;
            lblDrTehreemSummaryMonth.AutoSize = true;
            lblDrTehreemSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrTehreemSummaryMonth.Location = new Point(17, 415);
            lblDrTehreemSummaryMonth.Margin = new Padding(7, 0, 7, 0);
            lblDrTehreemSummaryMonth.Name = "lblDrTehreemSummaryMonth";
            lblDrTehreemSummaryMonth.Size = new Size(370, 39);
            lblDrTehreemSummaryMonth.TabIndex = 39;
            lblDrTehreemSummaryMonth.Text = "Dr Tehreem Summary";
            // 
            // lblDrFizzaSummaryMonth
            // 
            lblDrFizzaSummaryMonth.Anchor = AnchorStyles.Top;
            lblDrFizzaSummaryMonth.AutoSize = true;
            lblDrFizzaSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrFizzaSummaryMonth.Location = new Point(17, 260);
            lblDrFizzaSummaryMonth.Margin = new Padding(7, 0, 7, 0);
            lblDrFizzaSummaryMonth.Name = "lblDrFizzaSummaryMonth";
            lblDrFizzaSummaryMonth.Size = new Size(314, 39);
            lblDrFizzaSummaryMonth.TabIndex = 38;
            lblDrFizzaSummaryMonth.Text = "Dr Fizza Summary";
            // 
            // lblOthersSummaryMonth
            // 
            lblOthersSummaryMonth.Anchor = AnchorStyles.Top;
            lblOthersSummaryMonth.AutoSize = true;
            lblOthersSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOthersSummaryMonth.Location = new Point(14, 555);
            lblOthersSummaryMonth.Margin = new Padding(7, 0, 7, 0);
            lblOthersSummaryMonth.Name = "lblOthersSummaryMonth";
            lblOthersSummaryMonth.Size = new Size(240, 39);
            lblOthersSummaryMonth.TabIndex = 37;
            lblOthersSummaryMonth.Text = "Other Doctors";
            // 
            // lblDrJawadSummaryMonth
            // 
            lblDrJawadSummaryMonth.Anchor = AnchorStyles.Top;
            lblDrJawadSummaryMonth.AutoSize = true;
            lblDrJawadSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrJawadSummaryMonth.Location = new Point(17, 361);
            lblDrJawadSummaryMonth.Margin = new Padding(7, 0, 7, 0);
            lblDrJawadSummaryMonth.Name = "lblDrJawadSummaryMonth";
            lblDrJawadSummaryMonth.Size = new Size(331, 39);
            lblDrJawadSummaryMonth.TabIndex = 36;
            lblDrJawadSummaryMonth.Text = "Dr Jawad Summary";
            lblDrJawadSummaryMonth.Click += label5_Click;
            // 
            // lblDrHammadSummaryMonth
            // 
            lblDrHammadSummaryMonth.Anchor = AnchorStyles.Top;
            lblDrHammadSummaryMonth.AutoSize = true;
            lblDrHammadSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrHammadSummaryMonth.Location = new Point(17, 312);
            lblDrHammadSummaryMonth.Margin = new Padding(7, 0, 7, 0);
            lblDrHammadSummaryMonth.Name = "lblDrHammadSummaryMonth";
            lblDrHammadSummaryMonth.Size = new Size(371, 39);
            lblDrHammadSummaryMonth.TabIndex = 35;
            lblDrHammadSummaryMonth.Text = "Dr Hammad Summary";
            // 
            // lblDrZainSummaryMonth
            // 
            lblDrZainSummaryMonth.Anchor = AnchorStyles.Top;
            lblDrZainSummaryMonth.AutoSize = true;
            lblDrZainSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDrZainSummaryMonth.Location = new Point(17, 210);
            lblDrZainSummaryMonth.Margin = new Padding(7, 0, 7, 0);
            lblDrZainSummaryMonth.Name = "lblDrZainSummaryMonth";
            lblDrZainSummaryMonth.Size = new Size(298, 39);
            lblDrZainSummaryMonth.TabIndex = 34;
            lblDrZainSummaryMonth.Text = "Dr Zain Summary";
            // 
            // lblEcgSummaryMonth
            // 
            lblEcgSummaryMonth.Anchor = AnchorStyles.Top;
            lblEcgSummaryMonth.AutoSize = true;
            lblEcgSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEcgSummaryMonth.Location = new Point(17, 109);
            lblEcgSummaryMonth.Margin = new Padding(7, 0, 7, 0);
            lblEcgSummaryMonth.Name = "lblEcgSummaryMonth";
            lblEcgSummaryMonth.Size = new Size(256, 39);
            lblEcgSummaryMonth.TabIndex = 33;
            lblEcgSummaryMonth.Text = "ECG Summary";
            // 
            // lblUsgSummaryMonth
            // 
            lblUsgSummaryMonth.Anchor = AnchorStyles.Top;
            lblUsgSummaryMonth.AutoSize = true;
            lblUsgSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsgSummaryMonth.Location = new Point(17, 161);
            lblUsgSummaryMonth.Margin = new Padding(7, 0, 7, 0);
            lblUsgSummaryMonth.Name = "lblUsgSummaryMonth";
            lblUsgSummaryMonth.Size = new Size(256, 39);
            lblUsgSummaryMonth.TabIndex = 32;
            lblUsgSummaryMonth.Text = "USG Summary";
            // 
            // lblOpdSummaryMonth
            // 
            lblOpdSummaryMonth.Anchor = AnchorStyles.Top;
            lblOpdSummaryMonth.AutoSize = true;
            lblOpdSummaryMonth.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpdSummaryMonth.Location = new Point(17, 55);
            lblOpdSummaryMonth.Margin = new Padding(7, 0, 7, 0);
            lblOpdSummaryMonth.Name = "lblOpdSummaryMonth";
            lblOpdSummaryMonth.Size = new Size(256, 39);
            lblOpdSummaryMonth.TabIndex = 31;
            lblOpdSummaryMonth.Text = "OPD Summary";
            // 
            // btnPrintMonthly
            // 
            btnPrintMonthly.Anchor = AnchorStyles.Top;
            btnPrintMonthly.BackColor = Color.WhiteSmoke;
            btnPrintMonthly.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnPrintMonthly.FlatAppearance.BorderSize = 2;
            btnPrintMonthly.FlatStyle = FlatStyle.Flat;
            btnPrintMonthly.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintMonthly.ForeColor = Color.FromArgb(91, 42, 134);
            btnPrintMonthly.Location = new Point(834, 669);
            btnPrintMonthly.Margin = new Padding(7, 5, 7, 5);
            btnPrintMonthly.Name = "btnPrintMonthly";
            btnPrintMonthly.Size = new Size(318, 104);
            btnPrintMonthly.TabIndex = 24;
            btnPrintMonthly.Text = "Print Monthly";
            btnPrintMonthly.UseVisualStyleBackColor = false;
            btnPrintMonthly.Click += btnPrintMonthly_Click;
            // 
            // lblMonthTotal
            // 
            lblMonthTotal.Anchor = AnchorStyles.Top;
            lblMonthTotal.AutoSize = true;
            lblMonthTotal.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonthTotal.ForeColor = Color.Red;
            lblMonthTotal.Location = new Point(14, 603);
            lblMonthTotal.Margin = new Padding(7, 0, 7, 0);
            lblMonthTotal.Name = "lblMonthTotal";
            lblMonthTotal.Size = new Size(644, 39);
            lblMonthTotal.TabIndex = 23;
            lblMonthTotal.Text = "This Month’s Total Tokens and Amount";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.BackColor = Color.WhiteSmoke;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(91, 42, 134);
            btnCancel.Location = new Point(2290, 1946);
            btnCancel.Margin = new Padding(7, 5, 7, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(318, 104);
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
            btnReprint.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReprint.ForeColor = SystemColors.ButtonHighlight;
            btnReprint.Location = new Point(1931, 1946);
            btnReprint.Margin = new Padding(7, 5, 7, 5);
            btnReprint.Name = "btnReprint";
            btnReprint.Size = new Size(318, 104);
            btnReprint.TabIndex = 10;
            btnReprint.Text = "Re-Print [F4]";
            btnReprint.UseVisualStyleBackColor = false;
            btnReprint.Click += btnReprint_Click;
            // 
            // gbIndividualRecords
            // 
            gbIndividualRecords.Anchor = AnchorStyles.None;
            gbIndividualRecords.Controls.Add(btnDailyDrMinahil);
            gbIndividualRecords.Controls.Add(btnDailyDrZuhaib);
            gbIndividualRecords.Controls.Add(btnDailyDrTehreem);
            gbIndividualRecords.Controls.Add(btnDailyOther);
            gbIndividualRecords.Controls.Add(btnDailyDrJawad);
            gbIndividualRecords.Controls.Add(btnDailyDrHammad);
            gbIndividualRecords.Controls.Add(btnDailyDrFizza);
            gbIndividualRecords.Controls.Add(btnDailyDrZain);
            gbIndividualRecords.Controls.Add(btnDailyUSG);
            gbIndividualRecords.Controls.Add(btnDailyECG);
            gbIndividualRecords.Controls.Add(btnDailyOPD);
            gbIndividualRecords.Location = new Point(126, 1093);
            gbIndividualRecords.Margin = new Padding(7, 5, 7, 5);
            gbIndividualRecords.Name = "gbIndividualRecords";
            gbIndividualRecords.Padding = new Padding(7, 5, 7, 5);
            gbIndividualRecords.Size = new Size(2365, 336);
            gbIndividualRecords.TabIndex = 12;
            gbIndividualRecords.TabStop = false;
            gbIndividualRecords.Text = "Individual Records";
            // 
            // btnDailyDrZuhaib
            // 
            btnDailyDrZuhaib.Anchor = AnchorStyles.Top;
            btnDailyDrZuhaib.BackColor = Color.WhiteSmoke;
            btnDailyDrZuhaib.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrZuhaib.FlatAppearance.BorderSize = 2;
            btnDailyDrZuhaib.FlatStyle = FlatStyle.Flat;
            btnDailyDrZuhaib.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrZuhaib.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrZuhaib.Location = new Point(848, 186);
            btnDailyDrZuhaib.Margin = new Padding(7, 5, 7, 5);
            btnDailyDrZuhaib.Name = "btnDailyDrZuhaib";
            btnDailyDrZuhaib.Size = new Size(318, 104);
            btnDailyDrZuhaib.TabIndex = 37;
            btnDailyDrZuhaib.Text = "Dr Zuhaib";
            btnDailyDrZuhaib.UseVisualStyleBackColor = false;
            btnDailyDrZuhaib.Click += btnDailyDrZuhaib_Click;
            // 
            // btnDailyDrTehreem
            // 
            btnDailyDrTehreem.Anchor = AnchorStyles.Top;
            btnDailyDrTehreem.BackColor = Color.WhiteSmoke;
            btnDailyDrTehreem.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrTehreem.FlatAppearance.BorderSize = 2;
            btnDailyDrTehreem.FlatStyle = FlatStyle.Flat;
            btnDailyDrTehreem.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrTehreem.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrTehreem.Location = new Point(462, 186);
            btnDailyDrTehreem.Margin = new Padding(7, 5, 7, 5);
            btnDailyDrTehreem.Name = "btnDailyDrTehreem";
            btnDailyDrTehreem.Size = new Size(318, 104);
            btnDailyDrTehreem.TabIndex = 36;
            btnDailyDrTehreem.Text = "Dr Tehreem";
            btnDailyDrTehreem.UseVisualStyleBackColor = false;
            btnDailyDrTehreem.Click += btnDailyDrTehreem_Click;
            // 
            // btnDailyOther
            // 
            btnDailyOther.Anchor = AnchorStyles.Top;
            btnDailyOther.BackColor = Color.WhiteSmoke;
            btnDailyOther.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyOther.FlatAppearance.BorderSize = 2;
            btnDailyOther.FlatStyle = FlatStyle.Flat;
            btnDailyOther.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyOther.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyOther.Location = new Point(1617, 186);
            btnDailyOther.Margin = new Padding(7, 5, 7, 5);
            btnDailyOther.Name = "btnDailyOther";
            btnDailyOther.Size = new Size(318, 104);
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
            btnDailyDrJawad.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrJawad.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrJawad.Location = new Point(73, 186);
            btnDailyDrJawad.Margin = new Padding(7, 5, 7, 5);
            btnDailyDrJawad.Name = "btnDailyDrJawad";
            btnDailyDrJawad.Size = new Size(318, 104);
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
            btnDailyDrHammad.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrHammad.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrHammad.Location = new Point(2004, 55);
            btnDailyDrHammad.Margin = new Padding(7, 5, 7, 5);
            btnDailyDrHammad.Name = "btnDailyDrHammad";
            btnDailyDrHammad.Size = new Size(318, 104);
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
            btnDailyDrFizza.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrFizza.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrFizza.Location = new Point(1617, 55);
            btnDailyDrFizza.Margin = new Padding(7, 5, 7, 5);
            btnDailyDrFizza.Name = "btnDailyDrFizza";
            btnDailyDrFizza.Size = new Size(318, 104);
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
            btnDailyDrZain.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrZain.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrZain.Location = new Point(1234, 55);
            btnDailyDrZain.Margin = new Padding(7, 5, 7, 5);
            btnDailyDrZain.Name = "btnDailyDrZain";
            btnDailyDrZain.Size = new Size(318, 104);
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
            btnDailyUSG.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyUSG.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyUSG.Location = new Point(848, 55);
            btnDailyUSG.Margin = new Padding(7, 5, 7, 5);
            btnDailyUSG.Name = "btnDailyUSG";
            btnDailyUSG.Size = new Size(318, 104);
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
            btnDailyECG.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyECG.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyECG.Location = new Point(459, 55);
            btnDailyECG.Margin = new Padding(7, 5, 7, 5);
            btnDailyECG.Name = "btnDailyECG";
            btnDailyECG.Size = new Size(318, 104);
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
            btnDailyOPD.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyOPD.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyOPD.Location = new Point(73, 55);
            btnDailyOPD.Margin = new Padding(7, 5, 7, 5);
            btnDailyOPD.Name = "btnDailyOPD";
            btnDailyOPD.Size = new Size(318, 104);
            btnDailyOPD.TabIndex = 28;
            btnDailyOPD.Text = "OPD";
            btnDailyOPD.UseVisualStyleBackColor = false;
            btnDailyOPD.Click += btnDailyOPD_Click;
            // 
            // btnDailyDrMinahil
            // 
            btnDailyDrMinahil.Anchor = AnchorStyles.Top;
            btnDailyDrMinahil.BackColor = Color.WhiteSmoke;
            btnDailyDrMinahil.FlatAppearance.BorderColor = Color.FromArgb(91, 42, 134);
            btnDailyDrMinahil.FlatAppearance.BorderSize = 2;
            btnDailyDrMinahil.FlatStyle = FlatStyle.Flat;
            btnDailyDrMinahil.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyDrMinahil.ForeColor = Color.FromArgb(91, 42, 134);
            btnDailyDrMinahil.Location = new Point(1237, 186);
            btnDailyDrMinahil.Margin = new Padding(7, 5, 7, 5);
            btnDailyDrMinahil.Name = "btnDailyDrMinahil";
            btnDailyDrMinahil.Size = new Size(318, 104);
            btnDailyDrMinahil.TabIndex = 38;
            btnDailyDrMinahil.Text = "Dr Minahil";
            btnDailyDrMinahil.UseVisualStyleBackColor = false;
            btnDailyDrMinahil.Click += btnDailyDrMinahil_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(2686, 2080);
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
            Margin = new Padding(7, 5, 7, 5);
            MinimumSize = new Size(2679, 1720);
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
        private Label lblDrZuhaibSummary;
        private Label lblDrTehreemSummary;
        private Button btnDailyDrZuhaib;
        private Button btnDailyDrTehreem;
        private Label lblDrZuhaibSummaryMonth;
        private Label lblDrTehreemSummaryMonth;
        private Label lblDrFizzaSummaryMonth;
        private Label lblOthersSummaryMonth;
        private Label lblDrJawadSummaryMonth;
        private Label lblDrHammadSummaryMonth;
        private Label lblDrZainSummaryMonth;
        private Label lblEcgSummaryMonth;
        private Label lblUsgSummaryMonth;
        private Label lblOpdSummaryMonth;
        private Label lblDrMinahilSummary;
        private Label lblDrMinahilSummaryMonth;
        private Button btnDailyDrMinahil;
    }
}