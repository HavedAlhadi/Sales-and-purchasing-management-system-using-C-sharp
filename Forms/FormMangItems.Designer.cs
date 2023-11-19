namespace SuperSoft
{
    partial class FormMangItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMangItems));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdet = new System.Windows.Forms.Button();
            this.btnDelateIt = new System.Windows.Forms.Button();
            this.BtnUpdateIt = new System.Windows.Forms.Button();
            this.btnAddIt = new System.Windows.Forms.Button();
            this.btnSearchI = new System.Windows.Forms.Button();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.txtSearchIt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_Border = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Head = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labRe = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.User_Adduser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GropNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumPar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fillname_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel_Border.SuspendLayout();
            this.panel_Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUpdet);
            this.panel1.Controls.Add(this.btnDelateIt);
            this.panel1.Controls.Add(this.BtnUpdateIt);
            this.panel1.Controls.Add(this.btnAddIt);
            this.panel1.Controls.Add(this.btnSearchI);
            this.panel1.Controls.Add(this.cmbItem);
            this.panel1.Controls.Add(this.txtSearchIt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 560);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 76);
            this.panel1.TabIndex = 29;
            // 
            // btnUpdet
            // 
            this.btnUpdet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnUpdet.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdet.ForeColor = System.Drawing.Color.White;
            this.btnUpdet.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdet.Image")));
            this.btnUpdet.Location = new System.Drawing.Point(718, 18);
            this.btnUpdet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdet.Name = "btnUpdet";
            this.btnUpdet.Size = new System.Drawing.Size(106, 42);
            this.btnUpdet.TabIndex = 20;
            this.btnUpdet.Text = "تحديث";
            this.btnUpdet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdet.UseCompatibleTextRendering = true;
            this.btnUpdet.UseVisualStyleBackColor = false;
            this.btnUpdet.Click += new System.EventHandler(this.btnUpdet_Click);
            // 
            // btnDelateIt
            // 
            this.btnDelateIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelateIt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnDelateIt.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelateIt.ForeColor = System.Drawing.Color.White;
            this.btnDelateIt.Image = ((System.Drawing.Image)(resources.GetObject("btnDelateIt.Image")));
            this.btnDelateIt.Location = new System.Drawing.Point(834, 18);
            this.btnDelateIt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelateIt.Name = "btnDelateIt";
            this.btnDelateIt.Size = new System.Drawing.Size(106, 42);
            this.btnDelateIt.TabIndex = 19;
            this.btnDelateIt.Text = "حذف";
            this.btnDelateIt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelateIt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelateIt.UseCompatibleTextRendering = true;
            this.btnDelateIt.UseVisualStyleBackColor = false;
            this.btnDelateIt.Click += new System.EventHandler(this.btnDelateIt_Click);
            // 
            // BtnUpdateIt
            // 
            this.BtnUpdateIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateIt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.BtnUpdateIt.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateIt.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateIt.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdateIt.Image")));
            this.BtnUpdateIt.Location = new System.Drawing.Point(948, 18);
            this.BtnUpdateIt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnUpdateIt.Name = "BtnUpdateIt";
            this.BtnUpdateIt.Size = new System.Drawing.Size(106, 42);
            this.BtnUpdateIt.TabIndex = 18;
            this.BtnUpdateIt.Text = "تعديل";
            this.BtnUpdateIt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdateIt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpdateIt.UseCompatibleTextRendering = true;
            this.BtnUpdateIt.UseVisualStyleBackColor = false;
            this.BtnUpdateIt.Click += new System.EventHandler(this.BtnUpdateIt_Click);
            // 
            // btnAddIt
            // 
            this.btnAddIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddIt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnAddIt.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddIt.ForeColor = System.Drawing.Color.White;
            this.btnAddIt.Image = ((System.Drawing.Image)(resources.GetObject("btnAddIt.Image")));
            this.btnAddIt.Location = new System.Drawing.Point(1061, 18);
            this.btnAddIt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddIt.Name = "btnAddIt";
            this.btnAddIt.Size = new System.Drawing.Size(106, 42);
            this.btnAddIt.TabIndex = 17;
            this.btnAddIt.Text = "إضافة";
            this.btnAddIt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddIt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddIt.UseCompatibleTextRendering = true;
            this.btnAddIt.UseVisualStyleBackColor = false;
            this.btnAddIt.Click += new System.EventHandler(this.btnAddIt_Click);
            // 
            // btnSearchI
            // 
            this.btnSearchI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearchI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnSearchI.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchI.ForeColor = System.Drawing.Color.White;
            this.btnSearchI.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchI.Image")));
            this.btnSearchI.Location = new System.Drawing.Point(19, 18);
            this.btnSearchI.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchI.Name = "btnSearchI";
            this.btnSearchI.Size = new System.Drawing.Size(106, 42);
            this.btnSearchI.TabIndex = 16;
            this.btnSearchI.Text = "بحث";
            this.btnSearchI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchI.UseCompatibleTextRendering = true;
            this.btnSearchI.UseVisualStyleBackColor = false;
            this.btnSearchI.Click += new System.EventHandler(this.btnSearchI_Click);
            // 
            // cmbItem
            // 
            this.cmbItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Items.AddRange(new object[] {
            "بحث باسم الصنف",
            "بحث برقم الصنف",
            "بحت بالمجموعة",
            "بحث بالوحدة"});
            this.cmbItem.Location = new System.Drawing.Point(413, 25);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(210, 32);
            this.cmbItem.TabIndex = 12;
            this.cmbItem.Text = "إختر نوع البحث";
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // txtSearchIt
            // 
            this.txtSearchIt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearchIt.Location = new System.Drawing.Point(211, 25);
            this.txtSearchIt.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtSearchIt.Name = "txtSearchIt";
            this.txtSearchIt.Size = new System.Drawing.Size(195, 32);
            this.txtSearchIt.TabIndex = 11;
            this.txtSearchIt.TextChanged += new System.EventHandler(this.txtSearchIt_TextChanged);
            this.txtSearchIt.Leave += new System.EventHandler(this.txtSearchIt_Leave);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 636);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1181, 34);
            this.panel4.TabIndex = 28;
            // 
            // panel_Border
            // 
            this.panel_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            this.panel_Border.Controls.Add(this.label1);
            this.panel_Border.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Border.Location = new System.Drawing.Point(0, 0);
            this.panel_Border.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel_Border.Name = "panel_Border";
            this.panel_Border.Size = new System.Drawing.Size(1181, 4);
            this.panel_Border.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1014, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "سجل المستخدمين";
            // 
            // panel_Head
            // 
            this.panel_Head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel_Head.Controls.Add(this.label3);
            this.panel_Head.Controls.Add(this.labRe);
            this.panel_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Head.Location = new System.Drawing.Point(0, 4);
            this.panel_Head.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel_Head.Name = "panel_Head";
            this.panel_Head.Size = new System.Drawing.Size(1181, 38);
            this.panel_Head.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // labRe
            // 
            this.labRe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labRe.AutoSize = true;
            this.labRe.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRe.ForeColor = System.Drawing.Color.White;
            this.labRe.Location = new System.Drawing.Point(545, 7);
            this.labRe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labRe.Name = "labRe";
            this.labRe.Size = new System.Drawing.Size(113, 32);
            this.labRe.TabIndex = 0;
            this.labRe.Text = "سجل الأصناف";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 38);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 480);
            this.panel3.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1171, 80);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 480);
            this.panel5.TabIndex = 35;
            // 
            // User_Adduser
            // 
            this.User_Adduser.DataPropertyName = "user_item";
            this.User_Adduser.HeaderText = "المستخدم المضيف";
            this.User_Adduser.MinimumWidth = 6;
            this.User_Adduser.Name = "User_Adduser";
            this.User_Adduser.ReadOnly = true;
            // 
            // DateEnd
            // 
            this.DateEnd.DataPropertyName = "dateEnd_item";
            this.DateEnd.HeaderText = "تاريخ الإنتهاء";
            this.DateEnd.MinimumWidth = 6;
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.ReadOnly = true;
            // 
            // Time_user
            // 
            this.Time_user.DataPropertyName = "time_item";
            this.Time_user.HeaderText = "وقت إضافته";
            this.Time_user.MinimumWidth = 6;
            this.Time_user.Name = "Time_user";
            this.Time_user.ReadOnly = true;
            // 
            // Date_user
            // 
            this.Date_user.DataPropertyName = "date_item";
            this.Date_user.HeaderText = "تاريخ الإضافة ";
            this.Date_user.MinimumWidth = 6;
            this.Date_user.Name = "Date_user";
            this.Date_user.ReadOnly = true;
            // 
            // Phone_user
            // 
            this.Phone_user.DataPropertyName = "quantity_item";
            this.Phone_user.HeaderText = "الكمية";
            this.Phone_user.MinimumWidth = 6;
            this.Phone_user.Name = "Phone_user";
            this.Phone_user.ReadOnly = true;
            // 
            // ErnItem
            // 
            this.ErnItem.DataPropertyName = "earn_item";
            this.ErnItem.HeaderText = "ربحية الصنف";
            this.ErnItem.MinimumWidth = 6;
            this.ErnItem.Name = "ErnItem";
            this.ErnItem.ReadOnly = true;
            // 
            // UnitItem
            // 
            this.UnitItem.DataPropertyName = "name_unit_item";
            this.UnitItem.HeaderText = "وحدة الصنف";
            this.UnitItem.MinimumWidth = 6;
            this.UnitItem.Name = "UnitItem";
            this.UnitItem.ReadOnly = true;
            // 
            // GropNumber
            // 
            this.GropNumber.DataPropertyName = "nameGrop_item";
            this.GropNumber.HeaderText = "مجموعة الصنف";
            this.GropNumber.MinimumWidth = 6;
            this.GropNumber.Name = "GropNumber";
            this.GropNumber.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "price_item";
            this.UserName.HeaderText = "السعر";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // NumPar
            // 
            this.NumPar.DataPropertyName = "numpar_item";
            this.NumPar.HeaderText = "باركود الصنف";
            this.NumPar.MinimumWidth = 6;
            this.NumPar.Name = "NumPar";
            this.NumPar.ReadOnly = true;
            // 
            // Fillname_user
            // 
            this.Fillname_user.DataPropertyName = "name_item";
            this.Fillname_user.HeaderText = "اسم الصنف";
            this.Fillname_user.MinimumWidth = 6;
            this.Fillname_user.Name = "Fillname_user";
            this.Fillname_user.ReadOnly = true;
            // 
            // Id_user
            // 
            this.Id_user.DataPropertyName = "iD_item";
            this.Id_user.HeaderText = "رقم الصنف";
            this.Id_user.MinimumWidth = 6;
            this.Id_user.Name = "Id_user";
            this.Id_user.ReadOnly = true;
            // 
            // dgvItem
            // 
            this.dgvItem.AllowUserToAddRows = false;
            this.dgvItem.AllowUserToDeleteRows = false;
            this.dgvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_user,
            this.Fillname_user,
            this.NumPar,
            this.UserName,
            this.GropNumber,
            this.UnitItem,
            this.ErnItem,
            this.Phone_user,
            this.Date_user,
            this.Time_user,
            this.DateEnd,
            this.User_Adduser});
            this.dgvItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItem.Location = new System.Drawing.Point(10, 80);
            this.dgvItem.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.ReadOnly = true;
            this.dgvItem.RowHeadersWidth = 51;
            this.dgvItem.RowTemplate.Height = 29;
            this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem.Size = new System.Drawing.Size(1161, 480);
            this.dgvItem.TabIndex = 36;
            this.dgvItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItem_CellClick);
            this.dgvItem.SelectionChanged += new System.EventHandler(this.dgvItem_SelectionChanged);
            // 
            // FormMangItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 670);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_Head);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel_Border);
            this.Font = new System.Drawing.Font("Cairo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMangItems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FormMangItems";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Border.ResumeLayout(false);
            this.panel_Border.PerformLayout();
            this.panel_Head.ResumeLayout(false);
            this.panel_Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_Border;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Head;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labRe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnUpdet;
        private System.Windows.Forms.Button btnDelateIt;
        private System.Windows.Forms.Button BtnUpdateIt;
        private System.Windows.Forms.Button btnAddIt;
        private System.Windows.Forms.Button btnSearchI;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.TextBox txtSearchIt;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Adduser;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn GropNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumPar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fillname_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_user;
        private System.Windows.Forms.DataGridView dgvItem;
    }
}