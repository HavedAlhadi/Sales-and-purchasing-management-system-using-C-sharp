namespace SuperSoft
{
    partial class FormSImpo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSImpo));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSelectImpo = new System.Windows.Forms.Button();
            this.txtSearchImpo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearchImpo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labCloseFAddIt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
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
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(333, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 40);
            this.label1.TabIndex = 128;
            this.label1.Text = "*جدول الموردين*";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // BtnSelectImpo
            // 
            this.BtnSelectImpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSelectImpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.BtnSelectImpo.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSelectImpo.ForeColor = System.Drawing.Color.White;
            this.BtnSelectImpo.Image = ((System.Drawing.Image)(resources.GetObject("BtnSelectImpo.Image")));
            this.BtnSelectImpo.Location = new System.Drawing.Point(117, 31);
            this.BtnSelectImpo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnSelectImpo.Name = "BtnSelectImpo";
            this.BtnSelectImpo.Size = new System.Drawing.Size(128, 42);
            this.BtnSelectImpo.TabIndex = 121;
            this.BtnSelectImpo.Text = "اختيار";
            this.BtnSelectImpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSelectImpo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSelectImpo.UseCompatibleTextRendering = true;
            this.BtnSelectImpo.UseVisualStyleBackColor = false;
            this.BtnSelectImpo.Click += new System.EventHandler(this.BtnEditCost_Click);
            // 
            // txtSearchImpo
            // 
            this.txtSearchImpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchImpo.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtSearchImpo.Location = new System.Drawing.Point(424, 35);
            this.txtSearchImpo.Name = "txtSearchImpo";
            this.txtSearchImpo.Size = new System.Drawing.Size(296, 36);
            this.txtSearchImpo.TabIndex = 119;
            this.txtSearchImpo.TextChanged += new System.EventHandler(this.txtSearchCust_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Cairo", 8.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(618, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 120;
            this.label2.Text = "نص البحث:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnSelectImpo);
            this.panel2.Controls.Add(this.txtSearchImpo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnSearchImpo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 94);
            this.panel2.TabIndex = 124;
            // 
            // btnSearchImpo
            // 
            this.btnSearchImpo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchImpo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnSearchImpo.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchImpo.ForeColor = System.Drawing.Color.White;
            this.btnSearchImpo.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchImpo.Image")));
            this.btnSearchImpo.Location = new System.Drawing.Point(258, 31);
            this.btnSearchImpo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchImpo.Name = "btnSearchImpo";
            this.btnSearchImpo.Size = new System.Drawing.Size(128, 42);
            this.btnSearchImpo.TabIndex = 118;
            this.btnSearchImpo.Text = "بحث";
            this.btnSearchImpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchImpo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchImpo.UseCompatibleTextRendering = true;
            this.btnSearchImpo.UseVisualStyleBackColor = false;
            this.btnSearchImpo.Click += new System.EventHandler(this.btnSearchCust_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Coral;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 5);
            this.panel3.TabIndex = 123;
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
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 36);
            this.panel1.TabIndex = 130;
            // 
            // labCloseFAddIt
            // 
            this.labCloseFAddIt.AutoSize = true;
            this.labCloseFAddIt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCloseFAddIt.ForeColor = System.Drawing.Color.White;
            this.labCloseFAddIt.Location = new System.Drawing.Point(11, 7);
            this.labCloseFAddIt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCloseFAddIt.Name = "labCloseFAddIt";
            this.labCloseFAddIt.Size = new System.Drawing.Size(22, 21);
            this.labCloseFAddIt.TabIndex = 98;
            this.labCloseFAddIt.Text = "X";
            this.labCloseFAddIt.Click += new System.EventHandler(this.labCloseFAddIt_Click_1);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(331, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "بحت عن مورد";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 315);
            this.panel4.TabIndex = 131;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(787, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 315);
            this.panel6.TabIndex = 132;
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
            this.dgvImpo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvImpo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.dgvImpo.Location = new System.Drawing.Point(13, 87);
            this.dgvImpo.Name = "dgvImpo";
            this.dgvImpo.ReadOnly = true;
            this.dgvImpo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvImpo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvImpo.RowTemplate.Height = 26;
            this.dgvImpo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImpo.Size = new System.Drawing.Size(774, 269);
            this.dgvImpo.TabIndex = 133;
            this.dgvImpo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImpo_CellClick_1);
            this.dgvImpo.SelectionChanged += new System.EventHandler(this.dgvImpo_SelectionChanged);
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
            // FormSImpo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvImpo);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSImpo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormSImpo_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSelectImpo;
        private System.Windows.Forms.TextBox txtSearchImpo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearchImpo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labCloseFAddIt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvImpo;
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