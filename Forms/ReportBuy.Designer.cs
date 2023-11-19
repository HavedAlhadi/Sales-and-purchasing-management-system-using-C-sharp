namespace SuperSoft
{
    partial class ReportBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportBuy));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddCost = new System.Windows.Forms.Button();
            this.btnSearchCust = new System.Windows.Forms.Button();
            this.btnUpdet = new System.Windows.Forms.Button();
            this.btnDelateICust = new System.Windows.Forms.Button();
            this.BtnEditCost = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgv_Buy = new System.Windows.Forms.DataGridView();
            this.buypill_Count = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtAP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DPDFPillBuy = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInv = new System.Windows.Forms.DataGridViewButtonColumn();
            this.numInv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_imp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_ivn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsfd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchImpo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Buy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 33);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(7, 4);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 21);
            this.label17.TabIndex = 15;
            this.label17.Text = "X";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cairo", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(480, -3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "سجل المشتريات ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Coral;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1146, 5);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSearchImpo);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.DPDFPillBuy);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.btnAddCost);
            this.panel5.Controls.Add(this.btnSearchCust);
            this.panel5.Controls.Add(this.btnUpdet);
            this.panel5.Controls.Add(this.btnDelateICust);
            this.panel5.Controls.Add(this.BtnEditCost);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Font = new System.Drawing.Font("Cairo", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 562);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1146, 95);
            this.panel5.TabIndex = 30;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btnAddCost
            // 
            this.btnAddCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnAddCost.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCost.ForeColor = System.Drawing.Color.White;
            this.btnAddCost.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCost.Image")));
            this.btnAddCost.Location = new System.Drawing.Point(965, 29);
            this.btnAddCost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddCost.Name = "btnAddCost";
            this.btnAddCost.Size = new System.Drawing.Size(113, 40);
            this.btnAddCost.TabIndex = 118;
            this.btnAddCost.Text = "جديد";
            this.btnAddCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCost.UseCompatibleTextRendering = true;
            this.btnAddCost.UseVisualStyleBackColor = false;
            this.btnAddCost.Click += new System.EventHandler(this.btnAddCost_Click);
            // 
            // btnSearchCust
            // 
            this.btnSearchCust.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnSearchCust.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCust.ForeColor = System.Drawing.Color.White;
            this.btnSearchCust.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCust.Image")));
            this.btnSearchCust.Location = new System.Drawing.Point(11, 27);
            this.btnSearchCust.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchCust.Name = "btnSearchCust";
            this.btnSearchCust.Size = new System.Drawing.Size(128, 42);
            this.btnSearchCust.TabIndex = 116;
            this.btnSearchCust.Text = "بحث";
            this.btnSearchCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCust.UseCompatibleTextRendering = true;
            this.btnSearchCust.UseVisualStyleBackColor = false;
            this.btnSearchCust.Click += new System.EventHandler(this.btnSearchCust_Click);
            // 
            // btnUpdet
            // 
            this.btnUpdet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnUpdet.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdet.ForeColor = System.Drawing.Color.White;
            this.btnUpdet.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdet.Image")));
            this.btnUpdet.Location = new System.Drawing.Point(596, 29);
            this.btnUpdet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdet.Name = "btnUpdet";
            this.btnUpdet.Size = new System.Drawing.Size(113, 40);
            this.btnUpdet.TabIndex = 113;
            this.btnUpdet.Text = "تحديث";
            this.btnUpdet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdet.UseCompatibleTextRendering = true;
            this.btnUpdet.UseVisualStyleBackColor = false;
            this.btnUpdet.Click += new System.EventHandler(this.btnUpdet_Click);
            // 
            // btnDelateICust
            // 
            this.btnDelateICust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelateICust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnDelateICust.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelateICust.ForeColor = System.Drawing.Color.White;
            this.btnDelateICust.Image = ((System.Drawing.Image)(resources.GetObject("btnDelateICust.Image")));
            this.btnDelateICust.Location = new System.Drawing.Point(718, 29);
            this.btnDelateICust.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelateICust.Name = "btnDelateICust";
            this.btnDelateICust.Size = new System.Drawing.Size(113, 40);
            this.btnDelateICust.TabIndex = 112;
            this.btnDelateICust.Text = "حذف";
            this.btnDelateICust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelateICust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelateICust.UseCompatibleTextRendering = true;
            this.btnDelateICust.UseVisualStyleBackColor = false;
            this.btnDelateICust.Click += new System.EventHandler(this.btnDelateICust_Click);
            // 
            // BtnEditCost
            // 
            this.BtnEditCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEditCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.BtnEditCost.Enabled = false;
            this.BtnEditCost.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditCost.ForeColor = System.Drawing.Color.White;
            this.BtnEditCost.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditCost.Image")));
            this.BtnEditCost.Location = new System.Drawing.Point(841, 29);
            this.BtnEditCost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnEditCost.Name = "BtnEditCost";
            this.BtnEditCost.Size = new System.Drawing.Size(113, 40);
            this.BtnEditCost.TabIndex = 111;
            this.BtnEditCost.Text = "تعديل";
            this.BtnEditCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditCost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditCost.UseCompatibleTextRendering = true;
            this.BtnEditCost.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1127, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 524);
            this.panel2.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 524);
            this.panel4.TabIndex = 32;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtAR);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtAP);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.buypill_Count);
            this.panel6.Controls.Add(this.Label11);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(19, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1108, 72);
            this.panel6.TabIndex = 33;
            // 
            // dgv_Buy
            // 
            this.dgv_Buy.AllowUserToAddRows = false;
            this.dgv_Buy.AllowUserToDeleteRows = false;
            this.dgv_Buy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Buy.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Buy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Buy.ColumnHeadersHeight = 30;
            this.dgv_Buy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Buy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnInv,
            this.numInv,
            this.Col_imp,
            this.type_ivn,
            this.Column3,
            this.Column1,
            this.total,
            this.Discount,
            this.Column4,
            this.dsfd,
            this.Column6,
            this.Column7,
            this.ColTime,
            this.Column2,
            this.Column5});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Buy.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Buy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Buy.EnableHeadersVisualStyles = false;
            this.dgv_Buy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.dgv_Buy.Location = new System.Drawing.Point(19, 110);
            this.dgv_Buy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Buy.Name = "dgv_Buy";
            this.dgv_Buy.ReadOnly = true;
            this.dgv_Buy.RowHeadersVisible = false;
            this.dgv_Buy.RowHeadersWidth = 51;
            this.dgv_Buy.RowTemplate.Height = 30;
            this.dgv_Buy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Buy.Size = new System.Drawing.Size(1108, 452);
            this.dgv_Buy.TabIndex = 41;
            this.dgv_Buy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Buy_CellClick);
            this.dgv_Buy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Buy_CellContentClick);
            this.dgv_Buy.DoubleClick += new System.EventHandler(this.dgv_Buy_DoubleClick);
            // 
            // buypill_Count
            // 
            this.buypill_Count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buypill_Count.BackColor = System.Drawing.Color.White;
            this.buypill_Count.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buypill_Count.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buypill_Count.Location = new System.Drawing.Point(729, 21);
            this.buypill_Count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buypill_Count.Name = "buypill_Count";
            this.buypill_Count.ReadOnly = true;
            this.buypill_Count.Size = new System.Drawing.Size(178, 32);
            this.buypill_Count.TabIndex = 52;
            this.buypill_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label11
            // 
            this.Label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(925, 21);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(101, 29);
            this.Label11.TabIndex = 51;
            this.Label11.Text = "عدد الفواتير :";
            // 
            // txtAP
            // 
            this.txtAP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAP.BackColor = System.Drawing.Color.White;
            this.txtAP.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAP.Location = new System.Drawing.Point(389, 21);
            this.txtAP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAP.Name = "txtAP";
            this.txtAP.ReadOnly = true;
            this.txtAP.Size = new System.Drawing.Size(178, 32);
            this.txtAP.TabIndex = 54;
            this.txtAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(582, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "المبالغ المدفوعة :";
            // 
            // txtAR
            // 
            this.txtAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAR.BackColor = System.Drawing.Color.White;
            this.txtAR.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAR.Location = new System.Drawing.Point(76, 21);
            this.txtAR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAR.Name = "txtAR";
            this.txtAR.ReadOnly = true;
            this.txtAR.Size = new System.Drawing.Size(178, 32);
            this.txtAR.TabIndex = 56;
            this.txtAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 29);
            this.label3.TabIndex = 55;
            this.label3.Text = "المبالغ المتبقية :";
            // 
            // DPDFPillBuy
            // 
            this.DPDFPillBuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DPDFPillBuy.CalendarFont = new System.Drawing.Font("Cairo", 9F);
            this.DPDFPillBuy.CustomFormat = "MM/dd/yyyy";
            this.DPDFPillBuy.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold);
            this.DPDFPillBuy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPDFPillBuy.Location = new System.Drawing.Point(208, 53);
            this.DPDFPillBuy.Name = "DPDFPillBuy";
            this.DPDFPillBuy.Size = new System.Drawing.Size(176, 32);
            this.DPDFPillBuy.TabIndex = 120;
            this.DPDFPillBuy.Value = new System.DateTime(2022, 10, 8, 0, 0, 0, 0);
            this.DPDFPillBuy.ValueChanged += new System.EventHandler(this.DPDFPillBuy_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cairo", 8.8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(392, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 29);
            this.label4.TabIndex = 119;
            this.label4.Text = "  البحث بتاريخ الفاتورة :";
            // 
            // btnInv
            // 
            this.btnInv.HeaderText = "التفاصيل";
            this.btnInv.MinimumWidth = 6;
            this.btnInv.Name = "btnInv";
            this.btnInv.ReadOnly = true;
            this.btnInv.Text = "التفاصيل";
            this.btnInv.ToolTipText = "التفاصيل";
            this.btnInv.UseColumnTextForButtonValue = true;
            // 
            // numInv
            // 
            this.numInv.DataPropertyName = "id_buy";
            this.numInv.FillWeight = 86.14754F;
            this.numInv.HeaderText = "رقم الفاتورة";
            this.numInv.MinimumWidth = 6;
            this.numInv.Name = "numInv";
            this.numInv.ReadOnly = true;
            // 
            // Col_imp
            // 
            this.Col_imp.DataPropertyName = "buy_impo";
            this.Col_imp.FillWeight = 75.27343F;
            this.Col_imp.HeaderText = "المورد";
            this.Col_imp.MinimumWidth = 6;
            this.Col_imp.Name = "Col_imp";
            this.Col_imp.ReadOnly = true;
            // 
            // type_ivn
            // 
            this.type_ivn.DataPropertyName = "type_buy";
            this.type_ivn.FillWeight = 78.38553F;
            this.type_ivn.HeaderText = "نوع الفاتورة";
            this.type_ivn.MinimumWidth = 6;
            this.type_ivn.Name = "type_ivn";
            this.type_ivn.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "buy_countitems";
            this.Column3.HeaderText = "عدد الأصناف";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "buy_totalG";
            this.Column1.HeaderText = "إجمالي الشراء";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "buy_totalB";
            this.total.FillWeight = 81.17106F;
            this.total.HeaderText = "اجمالي البيع";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "buy_discount";
            this.Discount.FillWeight = 66.93145F;
            this.Discount.HeaderText = "الخصم";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "buy_earn";
            this.Column4.HeaderText = "ربح الفاتورة";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dsfd
            // 
            this.dsfd.DataPropertyName = "buy_Amount_Piad";
            this.dsfd.HeaderText = "المبلغ المدفوع";
            this.dsfd.MinimumWidth = 6;
            this.dsfd.Name = "dsfd";
            this.dsfd.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "buy_Amount_Rem";
            this.Column6.HeaderText = "المبلغ المتبقي";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "buy_ExtsraDiscount";
            this.Column7.HeaderText = "الخصم الإضافي";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // ColTime
            // 
            this.ColTime.DataPropertyName = "date_buy";
            this.ColTime.FillWeight = 83.94543F;
            this.ColTime.HeaderText = "الوقت";
            this.ColTime.MinimumWidth = 6;
            this.ColTime.Name = "ColTime";
            this.ColTime.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "time_buy";
            this.Column2.FillWeight = 86.14754F;
            this.Column2.HeaderText = "التاريخ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "buy_user";
            this.Column5.HeaderText = "المستخدم";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cairo", 8.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(370, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 121;
            this.label2.Text = "البحث باسم المورد:";
            // 
            // txtSearchImpo
            // 
            this.txtSearchImpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchImpo.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtSearchImpo.Location = new System.Drawing.Point(208, 11);
            this.txtSearchImpo.Name = "txtSearchImpo";
            this.txtSearchImpo.Size = new System.Drawing.Size(176, 36);
            this.txtSearchImpo.TabIndex = 122;
            // 
            // ReportBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 657);
            this.Controls.Add(this.dgv_Buy);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportBuy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ReportBuy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Buy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnUpdet;
        private System.Windows.Forms.Button btnDelateICust;
        private System.Windows.Forms.Button BtnEditCost;
        private System.Windows.Forms.Button btnSearchCust;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAddCost;
        internal System.Windows.Forms.DataGridView dgv_Buy;
        internal System.Windows.Forms.TextBox buypill_Count;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtAR;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtAP;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DPDFPillBuy;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewButtonColumn btnInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn numInv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_imp;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_ivn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsfd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchImpo;
    }
}