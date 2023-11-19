namespace SuperSoft
{
    partial class FormMangUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMangUser));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Head = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Border = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchU = new System.Windows.Forms.Button();
            this.btnUpdet = new System.Windows.Forms.Button();
            this.btnDelateIt = new System.Windows.Forms.Button();
            this.BtnUpdateIt = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCloseUser = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fillname_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pass_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Adduser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Head.SuspendLayout();
            this.panel_Border.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 15);
            this.panel2.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(517, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "سجل المستخدمين";
            // 
            // panel_Head
            // 
            this.panel_Head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel_Head.Controls.Add(this.label3);
            this.panel_Head.Controls.Add(this.label2);
            this.panel_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Head.Location = new System.Drawing.Point(0, 4);
            this.panel_Head.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel_Head.Name = "panel_Head";
            this.panel_Head.Size = new System.Drawing.Size(1181, 38);
            this.panel_Head.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // panel_Border
            // 
            this.panel_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(180)))));
            this.panel_Border.Controls.Add(this.label1);
            this.panel_Border.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Border.Location = new System.Drawing.Point(0, 0);
            this.panel_Border.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel_Border.Name = "panel_Border";
            this.panel_Border.Size = new System.Drawing.Size(1181, 4);
            this.panel_Border.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 652);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1181, 18);
            this.panel4.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSearchU);
            this.panel1.Controls.Add(this.btnUpdet);
            this.panel1.Controls.Add(this.btnDelateIt);
            this.panel1.Controls.Add(this.BtnUpdateIt);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnCloseUser);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 584);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 68);
            this.panel1.TabIndex = 23;
            // 
            // btnSearchU
            // 
            this.btnSearchU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnSearchU.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchU.ForeColor = System.Drawing.Color.White;
            this.btnSearchU.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchU.Image")));
            this.btnSearchU.Location = new System.Drawing.Point(98, 9);
            this.btnSearchU.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchU.Name = "btnSearchU";
            this.btnSearchU.Size = new System.Drawing.Size(107, 42);
            this.btnSearchU.TabIndex = 25;
            this.btnSearchU.Text = "بحث";
            this.btnSearchU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchU.UseCompatibleTextRendering = true;
            this.btnSearchU.UseVisualStyleBackColor = false;
            this.btnSearchU.Click += new System.EventHandler(this.btnSearchU_Click);
            // 
            // btnUpdet
            // 
            this.btnUpdet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnUpdet.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdet.ForeColor = System.Drawing.Color.White;
            this.btnUpdet.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdet.Image")));
            this.btnUpdet.Location = new System.Drawing.Point(735, 13);
            this.btnUpdet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdet.Name = "btnUpdet";
            this.btnUpdet.Size = new System.Drawing.Size(105, 42);
            this.btnUpdet.TabIndex = 24;
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
            this.btnDelateIt.Location = new System.Drawing.Point(844, 13);
            this.btnDelateIt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelateIt.Name = "btnDelateIt";
            this.btnDelateIt.Size = new System.Drawing.Size(105, 42);
            this.btnDelateIt.TabIndex = 23;
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
            this.BtnUpdateIt.Location = new System.Drawing.Point(955, 13);
            this.BtnUpdateIt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnUpdateIt.Name = "BtnUpdateIt";
            this.BtnUpdateIt.Size = new System.Drawing.Size(105, 42);
            this.BtnUpdateIt.TabIndex = 22;
            this.BtnUpdateIt.Text = "تعديل";
            this.BtnUpdateIt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdateIt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpdateIt.UseCompatibleTextRendering = true;
            this.BtnUpdateIt.UseVisualStyleBackColor = false;
            this.BtnUpdateIt.Click += new System.EventHandler(this.BtnUpdateIt_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnAddUser.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.Location = new System.Drawing.Point(1064, 13);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(105, 42);
            this.btnAddUser.TabIndex = 21;
            this.btnAddUser.Text = "إضافة";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseCompatibleTextRendering = true;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddIt_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "بحث بالاسم",
            "بحث برقم الهاتف"});
            this.comboBox1.Location = new System.Drawing.Point(478, 17);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 32);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "إختر نوع البحث";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCloseUser
            // 
            this.btnCloseUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnCloseUser.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseUser.ForeColor = System.Drawing.Color.White;
            this.btnCloseUser.Location = new System.Drawing.Point(2, 9);
            this.btnCloseUser.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnCloseUser.Name = "btnCloseUser";
            this.btnCloseUser.Size = new System.Drawing.Size(92, 42);
            this.btnCloseUser.TabIndex = 9;
            this.btnCloseUser.Text = "اغلاق";
            this.btnCloseUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCloseUser.UseCompatibleTextRendering = true;
            this.btnCloseUser.UseVisualStyleBackColor = false;
            this.btnCloseUser.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Search.Location = new System.Drawing.Point(289, 17);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(180, 32);
            this.txt_Search.TabIndex = 11;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_user,
            this.Fillname_user,
            this.Phone_user,
            this.UserName,
            this.Pass_user,
            this.Date_user,
            this.Time_user,
            this.User_Adduser});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(0, 57);
            this.dgvUser.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 29;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(1181, 527);
            this.dgvUser.TabIndex = 24;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            this.dgvUser.SelectionChanged += new System.EventHandler(this.dgvUser_SelectionChanged);
            this.dgvUser.DoubleClick += new System.EventHandler(this.dgvUser_DoubleClick);
            // 
            // Id_user
            // 
            this.Id_user.DataPropertyName = "Id_user";
            this.Id_user.HeaderText = "رقم المستخدم";
            this.Id_user.MinimumWidth = 6;
            this.Id_user.Name = "Id_user";
            this.Id_user.ReadOnly = true;
            // 
            // Fillname_user
            // 
            this.Fillname_user.DataPropertyName = "fillname_user";
            this.Fillname_user.HeaderText = "الاسم الثلاثي";
            this.Fillname_user.MinimumWidth = 6;
            this.Fillname_user.Name = "Fillname_user";
            this.Fillname_user.ReadOnly = true;
            // 
            // Phone_user
            // 
            this.Phone_user.DataPropertyName = "phone_user";
            this.Phone_user.HeaderText = "رقم التلفون";
            this.Phone_user.MinimumWidth = 6;
            this.Phone_user.Name = "Phone_user";
            this.Phone_user.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "username";
            this.UserName.HeaderText = "اسم المستخدم";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // Pass_user
            // 
            this.Pass_user.DataPropertyName = "pass_user";
            this.Pass_user.HeaderText = "كلمة السر";
            this.Pass_user.MinimumWidth = 6;
            this.Pass_user.Name = "Pass_user";
            this.Pass_user.ReadOnly = true;
            // 
            // Date_user
            // 
            this.Date_user.DataPropertyName = "date_user";
            this.Date_user.HeaderText = "تاريخ الإضافة ";
            this.Date_user.MinimumWidth = 6;
            this.Date_user.Name = "Date_user";
            this.Date_user.ReadOnly = true;
            // 
            // Time_user
            // 
            this.Time_user.DataPropertyName = "time_user";
            this.Time_user.HeaderText = "وقت إضافته";
            this.Time_user.MinimumWidth = 6;
            this.Time_user.Name = "Time_user";
            this.Time_user.ReadOnly = true;
            // 
            // User_Adduser
            // 
            this.User_Adduser.DataPropertyName = "user_adduser";
            this.User_Adduser.HeaderText = "المستخدم المضيف";
            this.User_Adduser.MinimumWidth = 6;
            this.User_Adduser.Name = "User_Adduser";
            this.User_Adduser.ReadOnly = true;
            // 
            // FormMangUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1181, 670);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_Head);
            this.Controls.Add(this.panel_Border);
            this.Font = new System.Drawing.Font("Cairo", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMangUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "FormMangUser";
            this.panel_Head.ResumeLayout(false);
            this.panel_Head.PerformLayout();
            this.panel_Border.ResumeLayout(false);
            this.panel_Border.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_Head;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Border;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseUser;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fillname_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pass_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Adduser;
        private System.Windows.Forms.Button btnUpdet;
        private System.Windows.Forms.Button btnDelateIt;
        private System.Windows.Forms.Button BtnUpdateIt;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnSearchU;
    }
}