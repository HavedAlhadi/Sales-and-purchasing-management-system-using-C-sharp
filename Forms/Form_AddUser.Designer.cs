namespace SuperSoft
{
    partial class Form_AddUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DPTUser = new System.Windows.Forms.DateTimePicker();
            this.DPDUser = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_Fillname = new System.Windows.Forms.TextBox();
            this.txt_IdUser = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkBUser = new System.Windows.Forms.CheckBox();
            this.panelkeys = new System.Windows.Forms.Panel();
            this.UserPass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.txt_NameUser = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_UserAddUser = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_SaveDataUser = new System.Windows.Forms.Button();
            this.Btn_RegisterUser = new System.Windows.Forms.Button();
            this.BtnUEdit = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelkeys.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(356, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "إضافة مستخدم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(480, 31);
            this.panel3.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 4);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DPTUser);
            this.panel2.Controls.Add(this.DPDUser);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_PhoneNumber);
            this.panel2.Controls.Add(this.txt_Fillname);
            this.panel2.Controls.Add(this.txt_IdUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(480, 227);
            this.panel2.TabIndex = 32;
            // 
            // DPTUser
            // 
            this.DPTUser.CalendarFont = new System.Drawing.Font("Cairo", 9F);
            this.DPTUser.CustomFormat = "hh:mm:ss tt";
            this.DPTUser.Enabled = false;
            this.DPTUser.Font = new System.Drawing.Font("Cairo", 9F);
            this.DPTUser.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPTUser.Location = new System.Drawing.Point(57, 181);
            this.DPTUser.Name = "DPTUser";
            this.DPTUser.Size = new System.Drawing.Size(235, 36);
            this.DPTUser.TabIndex = 101;
            this.DPTUser.Value = new System.DateTime(2022, 10, 8, 21, 4, 0, 0);
            // 
            // DPDUser
            // 
            this.DPDUser.CalendarFont = new System.Drawing.Font("Cairo", 9F);
            this.DPDUser.CustomFormat = "dd/MM/yyyy";
            this.DPDUser.Enabled = false;
            this.DPDUser.Font = new System.Drawing.Font("Cairo", 9F);
            this.DPDUser.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPDUser.Location = new System.Drawing.Point(57, 140);
            this.DPDUser.Name = "DPDUser";
            this.DPDUser.Size = new System.Drawing.Size(235, 36);
            this.DPDUser.TabIndex = 100;
            this.DPDUser.Value = new System.DateTime(2022, 10, 8, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Cairo", 9F);
            this.label8.Location = new System.Drawing.Point(315, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 34);
            this.label8.TabIndex = 99;
            this.label8.Text = "وقت لاضافة";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cairo", 9F);
            this.label9.Location = new System.Drawing.Point(315, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 34);
            this.label9.TabIndex = 98;
            this.label9.Text = "تاريخ الاضافة :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 36;
            this.label5.Text = "رقم التلفون:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = " رقم المستخدم:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(329, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "الاسم الثلاثي:";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Cairo", 9F);
            this.txt_PhoneNumber.Location = new System.Drawing.Point(57, 97);
            this.txt_PhoneNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(235, 36);
            this.txt_PhoneNumber.TabIndex = 32;
            // 
            // txt_Fillname
            // 
            this.txt_Fillname.Font = new System.Drawing.Font("Cairo", 9F);
            this.txt_Fillname.Location = new System.Drawing.Point(57, 55);
            this.txt_Fillname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Fillname.Name = "txt_Fillname";
            this.txt_Fillname.Size = new System.Drawing.Size(235, 36);
            this.txt_Fillname.TabIndex = 31;
            // 
            // txt_IdUser
            // 
            this.txt_IdUser.Font = new System.Drawing.Font("Cairo", 9F);
            this.txt_IdUser.Location = new System.Drawing.Point(57, 13);
            this.txt_IdUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_IdUser.Name = "txt_IdUser";
            this.txt_IdUser.ReadOnly = true;
            this.txt_IdUser.Size = new System.Drawing.Size(235, 36);
            this.txt_IdUser.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkBUser);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 262);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(480, 41);
            this.panel5.TabIndex = 33;
            // 
            // checkBUser
            // 
            this.checkBUser.AutoSize = true;
            this.checkBUser.Font = new System.Drawing.Font("Cairo", 9F);
            this.checkBUser.Location = new System.Drawing.Point(169, 5);
            this.checkBUser.Name = "checkBUser";
            this.checkBUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBUser.Size = new System.Drawing.Size(136, 33);
            this.checkBUser.TabIndex = 0;
            this.checkBUser.Text = "يستخدم البرنامج";
            this.checkBUser.UseVisualStyleBackColor = true;
            this.checkBUser.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panelkeys
            // 
            this.panelkeys.Controls.Add(this.UserPass);
            this.panelkeys.Controls.Add(this.label6);
            this.panelkeys.Controls.Add(this.txtUserPass);
            this.panelkeys.Controls.Add(this.txt_NameUser);
            this.panelkeys.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelkeys.Location = new System.Drawing.Point(0, 303);
            this.panelkeys.Name = "panelkeys";
            this.panelkeys.Size = new System.Drawing.Size(480, 101);
            this.panelkeys.TabIndex = 34;
            this.panelkeys.Visible = false;
            // 
            // UserPass
            // 
            this.UserPass.AutoSize = true;
            this.UserPass.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPass.Location = new System.Drawing.Point(346, 61);
            this.UserPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserPass.Name = "UserPass";
            this.UserPass.Size = new System.Drawing.Size(79, 29);
            this.UserPass.TabIndex = 37;
            this.UserPass.Text = "كلمة السر:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(317, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "اسم المستخدم:";
            // 
            // txtUserPass
            // 
            this.txtUserPass.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtUserPass.Location = new System.Drawing.Point(57, 58);
            this.txtUserPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.PasswordChar = '*';
            this.txtUserPass.Size = new System.Drawing.Size(235, 36);
            this.txtUserPass.TabIndex = 34;
            // 
            // txt_NameUser
            // 
            this.txt_NameUser.Font = new System.Drawing.Font("Cairo", 9F);
            this.txt_NameUser.Location = new System.Drawing.Point(57, 14);
            this.txt_NameUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_NameUser.Name = "txt_NameUser";
            this.txt_NameUser.Size = new System.Drawing.Size(235, 36);
            this.txt_NameUser.TabIndex = 33;
            this.txt_NameUser.Leave += new System.EventHandler(this.txt_NameUser_Leave);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.txt_UserAddUser);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 404);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(480, 58);
            this.panel7.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(316, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = " المستخدم الحالي:";
            // 
            // txt_UserAddUser
            // 
            this.txt_UserAddUser.Enabled = false;
            this.txt_UserAddUser.Font = new System.Drawing.Font("Cairo", 9F);
            this.txt_UserAddUser.Location = new System.Drawing.Point(57, 7);
            this.txt_UserAddUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_UserAddUser.Name = "txt_UserAddUser";
            this.txt_UserAddUser.Size = new System.Drawing.Size(235, 36);
            this.txt_UserAddUser.TabIndex = 35;
            this.txt_UserAddUser.Text = "HAVED";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnUEdit);
            this.panel4.Controls.Add(this.Btn_SaveDataUser);
            this.panel4.Controls.Add(this.Btn_RegisterUser);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 462);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 50);
            this.panel4.TabIndex = 36;
            // 
            // Btn_SaveDataUser
            // 
            this.Btn_SaveDataUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.Btn_SaveDataUser.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveDataUser.ForeColor = System.Drawing.Color.White;
            this.Btn_SaveDataUser.Location = new System.Drawing.Point(24, 6);
            this.Btn_SaveDataUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_SaveDataUser.Name = "Btn_SaveDataUser";
            this.Btn_SaveDataUser.Size = new System.Drawing.Size(140, 39);
            this.Btn_SaveDataUser.TabIndex = 1;
            this.Btn_SaveDataUser.Text = "حفظ البيانات";
            this.Btn_SaveDataUser.UseVisualStyleBackColor = false;
            this.Btn_SaveDataUser.Click += new System.EventHandler(this.Btn_SaveDataUser_Click);
            // 
            // Btn_RegisterUser
            // 
            this.Btn_RegisterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.Btn_RegisterUser.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RegisterUser.ForeColor = System.Drawing.Color.White;
            this.Btn_RegisterUser.Location = new System.Drawing.Point(316, 6);
            this.Btn_RegisterUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_RegisterUser.Name = "Btn_RegisterUser";
            this.Btn_RegisterUser.Size = new System.Drawing.Size(140, 39);
            this.Btn_RegisterUser.TabIndex = 0;
            this.Btn_RegisterUser.Text = "سجل المستخدمين";
            this.Btn_RegisterUser.UseVisualStyleBackColor = false;
            this.Btn_RegisterUser.Click += new System.EventHandler(this.Btn_RegisterUser_Click);
            // 
            // BtnUEdit
            // 
            this.BtnUEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnUEdit.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUEdit.ForeColor = System.Drawing.Color.White;
            this.BtnUEdit.Location = new System.Drawing.Point(24, 6);
            this.BtnUEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnUEdit.Name = "BtnUEdit";
            this.BtnUEdit.Size = new System.Drawing.Size(140, 39);
            this.BtnUEdit.TabIndex = 2;
            this.BtnUEdit.Text = "تعديل";
            this.BtnUEdit.UseVisualStyleBackColor = false;
            this.BtnUEdit.Visible = false;
            this.BtnUEdit.Click += new System.EventHandler(this.BtnUEdit_Click);
            // 
            // Form_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 512);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panelkeys);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddUser";
            this.Load += new System.EventHandler(this.Form_AddUser_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelkeys.ResumeLayout(false);
            this.panelkeys.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_Fillname;
        private System.Windows.Forms.TextBox txt_IdUser;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelkeys;
        private System.Windows.Forms.Label UserPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.TextBox txt_NameUser;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_UserAddUser;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_SaveDataUser;
        private System.Windows.Forms.Button Btn_RegisterUser;
        private System.Windows.Forms.CheckBox checkBUser;
        private System.Windows.Forms.DateTimePicker DPTUser;
        private System.Windows.Forms.DateTimePicker DPDUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnUEdit;
    }
}