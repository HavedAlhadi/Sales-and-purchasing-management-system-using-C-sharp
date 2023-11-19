namespace SuperSoft
{
    partial class FormSearchCust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchCust));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labCloseFAddIt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnEditCost = new System.Windows.Forms.Button();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchCust = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 100;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.labCloseFAddIt.Click += new System.EventHandler(this.labCloseFAddIt_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(333, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "بحت عن عميل";
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
            this.panel3.TabIndex = 101;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnEditCost);
            this.panel2.Controls.Add(this.txtSearchCust);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnSearchCust);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 94);
            this.panel2.TabIndex = 113;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // BtnEditCost
            // 
            this.BtnEditCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.BtnEditCost.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditCost.ForeColor = System.Drawing.Color.White;
            this.BtnEditCost.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditCost.Image")));
            this.BtnEditCost.Location = new System.Drawing.Point(117, 31);
            this.BtnEditCost.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnEditCost.Name = "BtnEditCost";
            this.BtnEditCost.Size = new System.Drawing.Size(128, 42);
            this.BtnEditCost.TabIndex = 121;
            this.BtnEditCost.Text = "اختيار";
            this.BtnEditCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditCost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditCost.UseCompatibleTextRendering = true;
            this.BtnEditCost.UseVisualStyleBackColor = false;
            this.BtnEditCost.Click += new System.EventHandler(this.BtnEditCost_Click);
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchCust.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtSearchCust.Location = new System.Drawing.Point(424, 35);
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.Size = new System.Drawing.Size(296, 36);
            this.txtSearchCust.TabIndex = 119;
            this.txtSearchCust.TextChanged += new System.EventHandler(this.txtSearchCust_TextChanged);
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
            // btnSearchCust
            // 
            this.btnSearchCust.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSearchCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnSearchCust.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCust.ForeColor = System.Drawing.Color.White;
            this.btnSearchCust.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCust.Image")));
            this.btnSearchCust.Location = new System.Drawing.Point(258, 31);
            this.btnSearchCust.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSearchCust.Name = "btnSearchCust";
            this.btnSearchCust.Size = new System.Drawing.Size(128, 42);
            this.btnSearchCust.TabIndex = 118;
            this.btnSearchCust.Text = "بحث";
            this.btnSearchCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCust.UseCompatibleTextRendering = true;
            this.btnSearchCust.UseVisualStyleBackColor = false;
            this.btnSearchCust.Click += new System.EventHandler(this.btnSearchCust_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(787, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 315);
            this.panel6.TabIndex = 115;
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
            this.dgvCust.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCust.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.dgvCust.Location = new System.Drawing.Point(13, 103);
            this.dgvCust.MultiSelect = false;
            this.dgvCust.Name = "dgvCust";
            this.dgvCust.ReadOnly = true;
            this.dgvCust.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCust.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCust.RowTemplate.Height = 26;
            this.dgvCust.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCust.Size = new System.Drawing.Size(774, 253);
            this.dgvCust.TabIndex = 116;
            this.dgvCust.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCust_CellClick);
            this.dgvCust.SelectionChanged += new System.EventHandler(this.dgvCust_SelectionChanged);
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
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 315);
            this.panel4.TabIndex = 114;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(284, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 40);
            this.label1.TabIndex = 121;
            this.label1.Text = "*جدول العملاء*";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // FormSearchCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCust);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSearchCust";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormSearchCust_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labCloseFAddIt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvCust;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnEditCost;
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchCust;
        private System.Windows.Forms.Label label1;
    }
}