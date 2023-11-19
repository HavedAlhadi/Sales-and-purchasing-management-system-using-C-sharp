namespace SuperSoft
{
    partial class FormMangImpo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMangImpo));
            this.btnUpdetImpo = new System.Windows.Forms.Button();
            this.btnDelateImpo = new System.Windows.Forms.Button();
            this.btnAddImpo = new System.Windows.Forms.Button();
            this.btnSearchImpo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmSearchImpo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnUpdateImpo = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.GrbCash = new System.Windows.Forms.GroupBox();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            this.Por = new System.Windows.Forms.RadioButton();
            this.GrbSex = new System.Windows.Forms.GroupBox();
            this.Famle = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.txtSearchImpo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labCloseFAddIt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvImpo = new System.Windows.Forms.DataGridView();
            this.Id_Cust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_cust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Cust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gander = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_impo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Cust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_Add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Add = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.GrbCash.SuspendLayout();
            this.GrbSex.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdetImpo
            // 
            this.btnUpdetImpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdetImpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnUpdetImpo.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdetImpo.ForeColor = System.Drawing.Color.White;
            this.btnUpdetImpo.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdetImpo.Image")));
            this.btnUpdetImpo.Location = new System.Drawing.Point(243, 7);
            this.btnUpdetImpo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdetImpo.Name = "btnUpdetImpo";
            this.btnUpdetImpo.Size = new System.Drawing.Size(128, 42);
            this.btnUpdetImpo.TabIndex = 24;
            this.btnUpdetImpo.Text = "تحديث";
            this.btnUpdetImpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdetImpo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdetImpo.UseCompatibleTextRendering = true;
            this.btnUpdetImpo.UseVisualStyleBackColor = false;
            this.btnUpdetImpo.Click += new System.EventHandler(this.btnUpdetImpo_Click);
            // 
            // btnDelateImpo
            // 
            this.btnDelateImpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelateImpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnDelateImpo.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelateImpo.ForeColor = System.Drawing.Color.White;
            this.btnDelateImpo.Image = ((System.Drawing.Image)(resources.GetObject("btnDelateImpo.Image")));
            this.btnDelateImpo.Location = new System.Drawing.Point(382, 7);
            this.btnDelateImpo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelateImpo.Name = "btnDelateImpo";
            this.btnDelateImpo.Size = new System.Drawing.Size(128, 42);
            this.btnDelateImpo.TabIndex = 23;
            this.btnDelateImpo.Text = "حذف";
            this.btnDelateImpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelateImpo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelateImpo.UseCompatibleTextRendering = true;
            this.btnDelateImpo.UseVisualStyleBackColor = false;
            this.btnDelateImpo.Click += new System.EventHandler(this.btnDelateImpo_Click);
            // 
            // btnAddImpo
            // 
            this.btnAddImpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddImpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnAddImpo.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImpo.ForeColor = System.Drawing.Color.White;
            this.btnAddImpo.Image = ((System.Drawing.Image)(resources.GetObject("btnAddImpo.Image")));
            this.btnAddImpo.Location = new System.Drawing.Point(663, 7);
            this.btnAddImpo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddImpo.Name = "btnAddImpo";
            this.btnAddImpo.Size = new System.Drawing.Size(128, 42);
            this.btnAddImpo.TabIndex = 21;
            this.btnAddImpo.Text = "إضافة";
            this.btnAddImpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddImpo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddImpo.UseCompatibleTextRendering = true;
            this.btnAddImpo.UseVisualStyleBackColor = false;
            this.btnAddImpo.Click += new System.EventHandler(this.btnAddIt_Click);
            // 
            // btnSearchImpo
            // 
            this.btnSearchImpo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchImpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnSearchImpo.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchImpo.ForeColor = System.Drawing.Color.White;
            this.btnSearchImpo.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchImpo.Image")));
            this.btnSearchImpo.Location = new System.Drawing.Point(74, 34);
            this.btnSearchImpo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchImpo.Name = "btnSearchImpo";
            this.btnSearchImpo.Size = new System.Drawing.Size(128, 37);
            this.btnSearchImpo.TabIndex = 106;
            this.btnSearchImpo.Text = "بحث";
            this.btnSearchImpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchImpo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchImpo.UseCompatibleTextRendering = true;
            this.btnSearchImpo.UseVisualStyleBackColor = false;
            this.btnSearchImpo.Click += new System.EventHandler(this.btnSearchImpo_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cairo", 8.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(389, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 104;
            this.label2.Text = "نص البحث:";
            // 
            // cmSearchImpo
            // 
            this.cmSearchImpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmSearchImpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(232)))), ((int)(((byte)(230)))));
            this.cmSearchImpo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmSearchImpo.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmSearchImpo.ForeColor = System.Drawing.Color.Black;
            this.cmSearchImpo.FormattingEnabled = true;
            this.cmSearchImpo.Items.AddRange(new object[] {
            "البحث بالاسم",
            "البحث برقم الهاتف",
            "البحث بالعنوان"});
            this.cmSearchImpo.Location = new System.Drawing.Point(515, 34);
            this.cmSearchImpo.Name = "cmSearchImpo";
            this.cmSearchImpo.Size = new System.Drawing.Size(269, 37);
            this.cmSearchImpo.TabIndex = 103;
            this.cmSearchImpo.SelectedIndexChanged += new System.EventHandler(this.cmSearchImpo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cairo", 8.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(693, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 102;
            this.label1.Text = "بحث بواسطة:";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1162, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 482);
            this.panel4.TabIndex = 46;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.btnUpdetImpo);
            this.panel5.Controls.Add(this.btnDelateImpo);
            this.panel5.Controls.Add(this.BtnUpdateImpo);
            this.panel5.Controls.Add(this.btnAddImpo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Font = new System.Drawing.Font("Cairo", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(19, 613);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1162, 57);
            this.panel5.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.button1.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(796, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 42);
            this.button1.TabIndex = 110;
            this.button1.Text = "إزالة التحديد";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnUpdateImpo
            // 
            this.BtnUpdateImpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnUpdateImpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.BtnUpdateImpo.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateImpo.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateImpo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdateImpo.Image")));
            this.BtnUpdateImpo.Location = new System.Drawing.Point(523, 7);
            this.BtnUpdateImpo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnUpdateImpo.Name = "BtnUpdateImpo";
            this.BtnUpdateImpo.Size = new System.Drawing.Size(128, 42);
            this.BtnUpdateImpo.TabIndex = 22;
            this.BtnUpdateImpo.Text = "تعديل";
            this.BtnUpdateImpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdateImpo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpdateImpo.UseCompatibleTextRendering = true;
            this.BtnUpdateImpo.UseVisualStyleBackColor = false;
            this.BtnUpdateImpo.Click += new System.EventHandler(this.BtnUpdateImpo_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Controls.Add(this.GrbCash);
            this.panel6.Controls.Add(this.GrbSex);
            this.panel6.Controls.Add(this.txtSearchImpo);
            this.panel6.Controls.Add(this.btnSearchImpo);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.cmSearchImpo);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.ForeColor = System.Drawing.Color.Coral;
            this.panel6.Location = new System.Drawing.Point(19, 39);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1162, 92);
            this.panel6.TabIndex = 43;
            // 
            // GrbCash
            // 
            this.GrbCash.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GrbCash.Controls.Add(this.rdoCash);
            this.GrbCash.Controls.Add(this.Por);
            this.GrbCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GrbCash.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCash.ForeColor = System.Drawing.Color.Black;
            this.GrbCash.Location = new System.Drawing.Point(980, 14);
            this.GrbCash.Name = "GrbCash";
            this.GrbCash.Size = new System.Drawing.Size(176, 64);
            this.GrbCash.TabIndex = 107;
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
            this.GrbSex.Location = new System.Drawing.Point(792, 14);
            this.GrbSex.Name = "GrbSex";
            this.GrbSex.Size = new System.Drawing.Size(176, 64);
            this.GrbSex.TabIndex = 108;
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
            // txtSearchImpo
            // 
            this.txtSearchImpo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchImpo.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtSearchImpo.Location = new System.Drawing.Point(233, 41);
            this.txtSearchImpo.Name = "txtSearchImpo";
            this.txtSearchImpo.Size = new System.Drawing.Size(246, 29);
            this.txtSearchImpo.TabIndex = 49;
            this.txtSearchImpo.TextChanged += new System.EventHandler(this.txtSearchImpo_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(19, 631);
            this.panel2.TabIndex = 45;
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
            this.panel1.TabIndex = 41;
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
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Cairo", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(534, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "سجل الموردين";
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
            this.panel3.TabIndex = 42;
            // 
            // dgvImpo
            // 
            this.dgvImpo.AllowUserToAddRows = false;
            this.dgvImpo.AllowUserToDeleteRows = false;
            this.dgvImpo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImpo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImpo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Cust,
            this.Name_cust,
            this.Phone_Cust,
            this.Balance,
            this.gander,
            this.type_impo,
            this.Date_Cust,
            this.Time_Add,
            this.Note,
            this.User_Add});
            this.dgvImpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImpo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.dgvImpo.Location = new System.Drawing.Point(19, 131);
            this.dgvImpo.Name = "dgvImpo";
            this.dgvImpo.ReadOnly = true;
            this.dgvImpo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvImpo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvImpo.RowTemplate.Height = 26;
            this.dgvImpo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImpo.Size = new System.Drawing.Size(1143, 482);
            this.dgvImpo.TabIndex = 48;
            this.dgvImpo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImpo_CellClick);
            // 
            // Id_Cust
            // 
            this.Id_Cust.DataPropertyName = "id_impo";
            this.Id_Cust.HeaderText = "رقم المورد";
            this.Id_Cust.MinimumWidth = 6;
            this.Id_Cust.Name = "Id_Cust";
            this.Id_Cust.ReadOnly = true;
            // 
            // Name_cust
            // 
            this.Name_cust.DataPropertyName = "name_impo";
            this.Name_cust.HeaderText = "اسم المورد";
            this.Name_cust.MinimumWidth = 6;
            this.Name_cust.Name = "Name_cust";
            this.Name_cust.ReadOnly = true;
            // 
            // Phone_Cust
            // 
            this.Phone_Cust.DataPropertyName = "phone_impo";
            this.Phone_Cust.HeaderText = "هاتف المورد";
            this.Phone_Cust.MinimumWidth = 6;
            this.Phone_Cust.Name = "Phone_Cust";
            this.Phone_Cust.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.DataPropertyName = "balance_impo";
            this.Balance.HeaderText = "الرصيد";
            this.Balance.MinimumWidth = 6;
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // gander
            // 
            this.gander.DataPropertyName = "gender_impo";
            this.gander.HeaderText = "الجنس";
            this.gander.MinimumWidth = 6;
            this.gander.Name = "gander";
            this.gander.ReadOnly = true;
            // 
            // type_impo
            // 
            this.type_impo.DataPropertyName = "type_impo";
            this.type_impo.HeaderText = "نوع التعامل";
            this.type_impo.MinimumWidth = 6;
            this.type_impo.Name = "type_impo";
            this.type_impo.ReadOnly = true;
            // 
            // Date_Cust
            // 
            this.Date_Cust.DataPropertyName = "date_impo";
            this.Date_Cust.HeaderText = "تاريخ الاضافة";
            this.Date_Cust.MinimumWidth = 6;
            this.Date_Cust.Name = "Date_Cust";
            this.Date_Cust.ReadOnly = true;
            // 
            // Time_Add
            // 
            this.Time_Add.DataPropertyName = "time_impo";
            this.Time_Add.HeaderText = "وقت الاضافه";
            this.Time_Add.MinimumWidth = 6;
            this.Time_Add.Name = "Time_Add";
            this.Time_Add.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "note_impo";
            this.Note.HeaderText = "ملاحظة";
            this.Note.MinimumWidth = 6;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // User_Add
            // 
            this.User_Add.DataPropertyName = "user_impo";
            this.User_Add.HeaderText = "المستخدم المضيف";
            this.User_Add.MinimumWidth = 6;
            this.User_Add.Name = "User_Add";
            this.User_Add.ReadOnly = true;
            // 
            // FormMangImpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 670);
            this.Controls.Add(this.dgvImpo);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMangImpo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FormMangImpo";
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.GrbCash.ResumeLayout(false);
            this.GrbCash.PerformLayout();
            this.GrbSex.ResumeLayout(false);
            this.GrbSex.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdetImpo;
        private System.Windows.Forms.Button btnDelateImpo;
        private System.Windows.Forms.Button btnAddImpo;
        private System.Windows.Forms.Button btnSearchImpo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmSearchImpo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnUpdateImpo;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labCloseFAddIt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvImpo;
        private System.Windows.Forms.TextBox txtSearchImpo;
        private System.Windows.Forms.GroupBox GrbCash;
        private System.Windows.Forms.RadioButton rdoCash;
        private System.Windows.Forms.RadioButton Por;
        private System.Windows.Forms.GroupBox GrbSex;
        private System.Windows.Forms.RadioButton Famle;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_cust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Cust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn gander;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_impo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Cust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Add;
    }
}