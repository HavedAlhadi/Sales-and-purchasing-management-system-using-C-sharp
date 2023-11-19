namespace SuperSoft
{
    partial class FormMangCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMangCust));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdet = new System.Windows.Forms.Button();
            this.btnDelateICust = new System.Windows.Forms.Button();
            this.BtnEditCost = new System.Windows.Forms.Button();
            this.btnAddCost = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchCust = new System.Windows.Forms.Button();
            this.cmbSearchCust = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrbCash = new System.Windows.Forms.GroupBox();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.Por = new System.Windows.Forms.RadioButton();
            this.GrbSex = new System.Windows.Forms.GroupBox();
            this.Famle = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labCloseFAddIt = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvCust = new System.Windows.Forms.DataGridView();
            this.Id_Cust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_cust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Cust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress_Cust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gander = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Cust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.GrbCash.SuspendLayout();
            this.GrbSex.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1162, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 482);
            this.panel4.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.btnUpdet);
            this.panel5.Controls.Add(this.btnDelateICust);
            this.panel5.Controls.Add(this.BtnEditCost);
            this.panel5.Controls.Add(this.btnAddCost);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Font = new System.Drawing.Font("Cairo", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(19, 613);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1162, 57);
            this.panel5.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.button1.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(824, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 42);
            this.button1.TabIndex = 109;
            this.button1.Text = "إزالة التحديد";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdet
            // 
            this.btnUpdet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnUpdet.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdet.ForeColor = System.Drawing.Color.White;
            this.btnUpdet.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdet.Image")));
            this.btnUpdet.Location = new System.Drawing.Point(261, 8);
            this.btnUpdet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdet.Name = "btnUpdet";
            this.btnUpdet.Size = new System.Drawing.Size(128, 42);
            this.btnUpdet.TabIndex = 24;
            this.btnUpdet.Text = "تحديث";
            this.btnUpdet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdet.UseCompatibleTextRendering = true;
            this.btnUpdet.UseVisualStyleBackColor = false;
            this.btnUpdet.Click += new System.EventHandler(this.btnUpdet_Click);
            // 
            // btnDelateICust
            // 
            this.btnDelateICust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelateICust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnDelateICust.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelateICust.ForeColor = System.Drawing.Color.White;
            this.btnDelateICust.Image = ((System.Drawing.Image)(resources.GetObject("btnDelateICust.Image")));
            this.btnDelateICust.Location = new System.Drawing.Point(400, 8);
            this.btnDelateICust.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelateICust.Name = "btnDelateICust";
            this.btnDelateICust.Size = new System.Drawing.Size(128, 42);
            this.btnDelateICust.TabIndex = 23;
            this.btnDelateICust.Text = "حذف";
            this.btnDelateICust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelateICust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelateICust.UseCompatibleTextRendering = true;
            this.btnDelateICust.UseVisualStyleBackColor = false;
            this.btnDelateICust.Click += new System.EventHandler(this.btnDelateICust_Click);
            // 
            // BtnEditCost
            // 
            this.BtnEditCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.BtnEditCost.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditCost.ForeColor = System.Drawing.Color.White;
            this.BtnEditCost.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditCost.Image")));
            this.BtnEditCost.Location = new System.Drawing.Point(541, 8);
            this.BtnEditCost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnEditCost.Name = "BtnEditCost";
            this.BtnEditCost.Size = new System.Drawing.Size(128, 42);
            this.BtnEditCost.TabIndex = 22;
            this.BtnEditCost.Text = "تعديل";
            this.BtnEditCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditCost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditCost.UseCompatibleTextRendering = true;
            this.BtnEditCost.UseVisualStyleBackColor = false;
            this.BtnEditCost.Click += new System.EventHandler(this.BtnEditCost_Click);
            // 
            // btnAddCost
            // 
            this.btnAddCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnAddCost.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCost.ForeColor = System.Drawing.Color.White;
            this.btnAddCost.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCost.Image")));
            this.btnAddCost.Location = new System.Drawing.Point(681, 8);
            this.btnAddCost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddCost.Name = "btnAddCost";
            this.btnAddCost.Size = new System.Drawing.Size(128, 42);
            this.btnAddCost.TabIndex = 21;
            this.btnAddCost.Text = "إضافة";
            this.btnAddCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCost.UseCompatibleTextRendering = true;
            this.btnAddCost.UseVisualStyleBackColor = false;
            this.btnAddCost.Click += new System.EventHandler(this.btnAddIt_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Controls.Add(this.txtSearchCust);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.btnSearchCust);
            this.panel6.Controls.Add(this.cmbSearchCust);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.GrbCash);
            this.panel6.Controls.Add(this.GrbSex);
            this.panel6.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.ForeColor = System.Drawing.Color.Coral;
            this.panel6.Location = new System.Drawing.Point(19, 39);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1162, 92);
            this.panel6.TabIndex = 35;
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchCust.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtSearchCust.Location = new System.Drawing.Point(275, 35);
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.Size = new System.Drawing.Size(201, 36);
            this.txtSearchCust.TabIndex = 107;
            this.txtSearchCust.TextChanged += new System.EventHandler(this.txtSearchCust_TextChanged);
            this.txtSearchCust.Leave += new System.EventHandler(this.txtSearchCust_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Cairo", 8.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(384, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 108;
            this.label2.Text = "نص البحث:";
            // 
            // btnSearchCust
            // 
            this.btnSearchCust.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnSearchCust.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCust.ForeColor = System.Drawing.Color.White;
            this.btnSearchCust.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCust.Image")));
            this.btnSearchCust.Location = new System.Drawing.Point(42, 32);
            this.btnSearchCust.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchCust.Name = "btnSearchCust";
            this.btnSearchCust.Size = new System.Drawing.Size(128, 42);
            this.btnSearchCust.TabIndex = 106;
            this.btnSearchCust.Text = "بحث";
            this.btnSearchCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCust.UseCompatibleTextRendering = true;
            this.btnSearchCust.UseVisualStyleBackColor = false;
            this.btnSearchCust.Click += new System.EventHandler(this.btnSearchG_Click);
            // 
            // cmbSearchCust
            // 
            this.cmbSearchCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSearchCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.cmbSearchCust.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSearchCust.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchCust.ForeColor = System.Drawing.Color.Black;
            this.cmbSearchCust.FormattingEnabled = true;
            this.cmbSearchCust.Items.AddRange(new object[] {
            "البحث بالاسم",
            "البحث برقم الهاتف",
            "البحث بالعنوان"});
            this.cmbSearchCust.Location = new System.Drawing.Point(516, 34);
            this.cmbSearchCust.Name = "cmbSearchCust";
            this.cmbSearchCust.Size = new System.Drawing.Size(201, 37);
            this.cmbSearchCust.TabIndex = 103;
            this.cmbSearchCust.SelectedIndexChanged += new System.EventHandler(this.cmbSearchCust_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cairo", 8.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(622, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 102;
            this.label1.Text = "بحث بواسطة:";
            // 
            // GrbCash
            // 
            this.GrbCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GrbCash.Controls.Add(this.rdoCash);
            this.GrbCash.Controls.Add(this.Por);
            this.GrbCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrbCash.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCash.ForeColor = System.Drawing.Color.Black;
            this.GrbCash.Location = new System.Drawing.Point(917, 10);
            this.GrbCash.Name = "GrbCash";
            this.GrbCash.Size = new System.Drawing.Size(176, 64);
            this.GrbCash.TabIndex = 43;
            this.GrbCash.TabStop = false;
            this.GrbCash.Text = "نوع التعامل";
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(12, 25);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(56, 33);
            this.rdoCash.TabIndex = 1;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "نقد";
            this.rdoCash.UseVisualStyleBackColor = true;
            this.rdoCash.CheckedChanged += new System.EventHandler(this.rdoCash_CheckedChanged);
            // 
            // Por
            // 
            this.Por.AutoSize = true;
            this.Por.Location = new System.Drawing.Point(91, 24);
            this.Por.Name = "Por";
            this.Por.Size = new System.Drawing.Size(56, 33);
            this.Por.TabIndex = 0;
            this.Por.TabStop = true;
            this.Por.Text = "آجل";
            this.Por.UseVisualStyleBackColor = true;
            this.Por.CheckedChanged += new System.EventHandler(this.Por_CheckedChanged);
            // 
            // GrbSex
            // 
            this.GrbSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GrbSex.Controls.Add(this.Famle);
            this.GrbSex.Controls.Add(this.Male);
            this.GrbSex.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.GrbSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrbSex.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbSex.ForeColor = System.Drawing.Color.Black;
            this.GrbSex.Location = new System.Drawing.Point(729, 10);
            this.GrbSex.Name = "GrbSex";
            this.GrbSex.Size = new System.Drawing.Size(176, 64);
            this.GrbSex.TabIndex = 44;
            this.GrbSex.TabStop = false;
            this.GrbSex.Text = "الجنس";
            // 
            // Famle
            // 
            this.Famle.AutoSize = true;
            this.Famle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Famle.Location = new System.Drawing.Point(6, 25);
            this.Famle.Name = "Famle";
            this.Famle.Size = new System.Drawing.Size(71, 34);
            this.Famle.TabIndex = 1;
            this.Famle.TabStop = true;
            this.Famle.Text = "انثئ";
            this.Famle.UseVisualStyleBackColor = true;
            this.Famle.CheckedChanged += new System.EventHandler(this.Famle_CheckedChanged);
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Male.Location = new System.Drawing.Point(83, 26);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(65, 34);
            this.Male.TabIndex = 0;
            this.Male.TabStop = true;
            this.Male.Text = "ذكر";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Cairo", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(534, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "سجل العملاء";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 631);
            this.panel2.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.labCloseFAddIt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 35);
            this.panel1.TabIndex = 33;
            // 
            // labCloseFAddIt
            // 
            this.labCloseFAddIt.AutoSize = true;
            this.labCloseFAddIt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCloseFAddIt.ForeColor = System.Drawing.Color.White;
            this.labCloseFAddIt.Location = new System.Drawing.Point(7, 6);
            this.labCloseFAddIt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCloseFAddIt.Name = "labCloseFAddIt";
            this.labCloseFAddIt.Size = new System.Drawing.Size(22, 21);
            this.labCloseFAddIt.TabIndex = 99;
            this.labCloseFAddIt.Text = "X";
            this.labCloseFAddIt.Click += new System.EventHandler(this.labCloseFAddIt_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Coral;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1181, 4);
            this.panel3.TabIndex = 34;
            // 
            // dgvCust
            // 
            this.dgvCust.AllowUserToAddRows = false;
            this.dgvCust.AllowUserToDeleteRows = false;
            this.dgvCust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCust.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cust,
            this.Name_cust,
            this.Phone_Cust,
            this.Adress_Cust,
            this.Balance,
            this.Gander,
            this.Type_cost,
            this.Time_Add,
            this.Date_Cust,
            this.Note,
            this.User_Add});
            this.dgvCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCust.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.dgvCust.Location = new System.Drawing.Point(19, 131);
            this.dgvCust.Name = "dgvCust";
            this.dgvCust.ReadOnly = true;
            this.dgvCust.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCust.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCust.RowTemplate.Height = 26;
            this.dgvCust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCust.Size = new System.Drawing.Size(1143, 482);
            this.dgvCust.TabIndex = 40;
            this.dgvCust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCust_CellClick);
            // 
            // Id_Cust
            // 
            this.Id_Cust.DataPropertyName = "id_cust";
            this.Id_Cust.HeaderText = "رقم العميل ";
            this.Id_Cust.MinimumWidth = 6;
            this.Id_Cust.Name = "Id_Cust";
            this.Id_Cust.ReadOnly = true;
            // 
            // Name_cust
            // 
            this.Name_cust.DataPropertyName = "name_cust";
            this.Name_cust.HeaderText = "اسم العميل";
            this.Name_cust.MinimumWidth = 6;
            this.Name_cust.Name = "Name_cust";
            this.Name_cust.ReadOnly = true;
            // 
            // Phone_Cust
            // 
            this.Phone_Cust.DataPropertyName = "phon_cust";
            this.Phone_Cust.HeaderText = "هاتف العميل";
            this.Phone_Cust.MinimumWidth = 6;
            this.Phone_Cust.Name = "Phone_Cust";
            this.Phone_Cust.ReadOnly = true;
            // 
            // Adress_Cust
            // 
            this.Adress_Cust.DataPropertyName = "addres_cust";
            this.Adress_Cust.HeaderText = "العنوان";
            this.Adress_Cust.MinimumWidth = 6;
            this.Adress_Cust.Name = "Adress_Cust";
            this.Adress_Cust.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "balance_cust";
            this.Balance.HeaderText = "الرصيد ";
            this.Balance.MinimumWidth = 6;
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // Gander
            // 
            this.Gander.DataPropertyName = "gender_cust";
            this.Gander.HeaderText = "الجنس";
            this.Gander.MinimumWidth = 6;
            this.Gander.Name = "Gander";
            this.Gander.ReadOnly = true;
            // 
            // Type_cost
            // 
            this.Type_cost.DataPropertyName = "type_cust";
            this.Type_cost.HeaderText = "نوع التعامل";
            this.Type_cost.MinimumWidth = 6;
            this.Type_cost.Name = "Type_cost";
            this.Type_cost.ReadOnly = true;
            // 
            // Time_Add
            // 
            this.Time_Add.DataPropertyName = "date_cust";
            this.Time_Add.HeaderText = "وقت الاضافه";
            this.Time_Add.MinimumWidth = 6;
            this.Time_Add.Name = "Time_Add";
            this.Time_Add.ReadOnly = true;
            // 
            // Date_Cust
            // 
            this.Date_Cust.DataPropertyName = "time_cust";
            this.Date_Cust.HeaderText = "تاريخ الاضافة";
            this.Date_Cust.MinimumWidth = 6;
            this.Date_Cust.Name = "Date_Cust";
            this.Date_Cust.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "note_cust";
            this.Note.HeaderText = "ملاحظة";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // User_Add
            // 
            this.User_Add.DataPropertyName = "uesr_cust";
            this.User_Add.HeaderText = "المستخدم";
            this.User_Add.MinimumWidth = 6;
            this.User_Add.Name = "User_Add";
            this.User_Add.ReadOnly = true;
            // 
            // FormMangCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 670);
            this.Controls.Add(this.dgvCust);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMangCust";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Form2";
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.GrbCash.ResumeLayout(false);
            this.GrbCash.PerformLayout();
            this.GrbSex.ResumeLayout(false);
            this.GrbSex.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox GrbCash;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.RadioButton Por;
        private System.Windows.Forms.GroupBox GrbSex;
        private System.Windows.Forms.RadioButton Famle;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Label labCloseFAddIt;
        private System.Windows.Forms.DataGridView dgvCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSearchCust;
        private System.Windows.Forms.Button btnSearchCust;
        private System.Windows.Forms.Button btnUpdet;
        private System.Windows.Forms.Button btnDelateICust;
        private System.Windows.Forms.Button BtnEditCost;
        private System.Windows.Forms.Button btnAddCost;
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_cust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Cust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress_Cust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gander;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Cust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Add;
    }
}