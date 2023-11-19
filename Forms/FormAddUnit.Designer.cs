namespace SuperSoft
{
    partial class FormAddUnit
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
            this.btnSaveDataUnit = new System.Windows.Forms.Button();
            this.btnRegisterUnit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdUnit = new System.Windows.Forms.TextBox();
            this.panelRigUnit = new System.Windows.Forms.Panel();
            this.btnEditU = new System.Windows.Forms.Button();
            this.panelHeadUnit = new System.Windows.Forms.Panel();
            this.labVisUnit = new System.Windows.Forms.Label();
            this.panelBorderUnit = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsetAU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DPTUnit = new System.Windows.Forms.DateTimePicker();
            this.DPDUnit = new System.Windows.Forms.DateTimePicker();
            this.txtNameUnit = new System.Windows.Forms.TextBox();
            this.panelRigUnit.SuspendLayout();
            this.panelHeadUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveDataUnit
            // 
            this.btnSaveDataUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnSaveDataUnit.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDataUnit.ForeColor = System.Drawing.Color.White;
            this.btnSaveDataUnit.Location = new System.Drawing.Point(2, 3);
            this.btnSaveDataUnit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveDataUnit.Name = "btnSaveDataUnit";
            this.btnSaveDataUnit.Size = new System.Drawing.Size(140, 39);
            this.btnSaveDataUnit.TabIndex = 1;
            this.btnSaveDataUnit.Text = "حفظ البيانات";
            this.btnSaveDataUnit.UseVisualStyleBackColor = false;
            this.btnSaveDataUnit.Click += new System.EventHandler(this.btnSaveDataUnit_Click);
            // 
            // btnRegisterUnit
            // 
            this.btnRegisterUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnRegisterUnit.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUnit.ForeColor = System.Drawing.Color.White;
            this.btnRegisterUnit.Location = new System.Drawing.Point(238, 3);
            this.btnRegisterUnit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegisterUnit.Name = "btnRegisterUnit";
            this.btnRegisterUnit.Size = new System.Drawing.Size(140, 39);
            this.btnRegisterUnit.TabIndex = 0;
            this.btnRegisterUnit.Text = "سجل الوحدات";
            this.btnRegisterUnit.UseVisualStyleBackColor = false;
            this.btnRegisterUnit.Click += new System.EventHandler(this.btnRegisterUnit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 47;
            this.label4.Text = "اسم الوحدة:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(309, -1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "إضافة وحدة";
            // 
            // txtIdUnit
            // 
            this.txtIdUnit.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUnit.Location = new System.Drawing.Point(82, 78);
            this.txtIdUnit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtIdUnit.Name = "txtIdUnit";
            this.txtIdUnit.ReadOnly = true;
            this.txtIdUnit.Size = new System.Drawing.Size(249, 36);
            this.txtIdUnit.TabIndex = 51;
            // 
            // panelRigUnit
            // 
            this.panelRigUnit.Controls.Add(this.btnEditU);
            this.panelRigUnit.Controls.Add(this.btnSaveDataUnit);
            this.panelRigUnit.Controls.Add(this.btnRegisterUnit);
            this.panelRigUnit.Location = new System.Drawing.Point(15, 407);
            this.panelRigUnit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelRigUnit.Name = "panelRigUnit";
            this.panelRigUnit.Size = new System.Drawing.Size(386, 47);
            this.panelRigUnit.TabIndex = 45;
            this.panelRigUnit.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRigUnit_Paint);
            // 
            // btnEditU
            // 
            this.btnEditU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnEditU.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditU.ForeColor = System.Drawing.Color.White;
            this.btnEditU.Location = new System.Drawing.Point(2, 5);
            this.btnEditU.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEditU.Name = "btnEditU";
            this.btnEditU.Size = new System.Drawing.Size(140, 39);
            this.btnEditU.TabIndex = 2;
            this.btnEditU.Text = "تعديل";
            this.btnEditU.UseVisualStyleBackColor = false;
            this.btnEditU.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelHeadUnit
            // 
            this.panelHeadUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panelHeadUnit.Controls.Add(this.label2);
            this.panelHeadUnit.Controls.Add(this.labVisUnit);
            this.panelHeadUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeadUnit.Location = new System.Drawing.Point(0, 4);
            this.panelHeadUnit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelHeadUnit.Name = "panelHeadUnit";
            this.panelHeadUnit.Size = new System.Drawing.Size(412, 31);
            this.panelHeadUnit.TabIndex = 44;
            // 
            // labVisUnit
            // 
            this.labVisUnit.AutoSize = true;
            this.labVisUnit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVisUnit.ForeColor = System.Drawing.Color.White;
            this.labVisUnit.Location = new System.Drawing.Point(11, 7);
            this.labVisUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labVisUnit.Name = "labVisUnit";
            this.labVisUnit.Size = new System.Drawing.Size(18, 18);
            this.labVisUnit.TabIndex = 0;
            this.labVisUnit.Text = "X";
            this.labVisUnit.Click += new System.EventHandler(this.labVisUnit_Click);
            // 
            // panelBorderUnit
            // 
            this.panelBorderUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.panelBorderUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorderUnit.ForeColor = System.Drawing.Color.White;
            this.panelBorderUnit.Location = new System.Drawing.Point(0, 0);
            this.panelBorderUnit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelBorderUnit.Name = "panelBorderUnit";
            this.panelBorderUnit.Size = new System.Drawing.Size(412, 4);
            this.panelBorderUnit.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 46;
            this.label3.Text = "رقم الوحدة:";
            // 
            // txtUsetAU
            // 
            this.txtUsetAU.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsetAU.Location = new System.Drawing.Point(82, 348);
            this.txtUsetAU.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsetAU.Name = "txtUsetAU";
            this.txtUsetAU.ReadOnly = true;
            this.txtUsetAU.Size = new System.Drawing.Size(249, 36);
            this.txtUsetAU.TabIndex = 114;
            this.txtUsetAU.Text = "Haved";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 34);
            this.label8.TabIndex = 113;
            this.label8.Text = "وقت الإضافة:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(77, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 34);
            this.label9.TabIndex = 112;
            this.label9.Text = "تاريخ الإضافة :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 29);
            this.label7.TabIndex = 109;
            this.label7.Text = "المستخدم الحالي:";
            // 
            // DPTUnit
            // 
            this.DPTUnit.CalendarFont = new System.Drawing.Font("Cairo", 9F);
            this.DPTUnit.CustomFormat = "hh:mm:ss tt";
            this.DPTUnit.Enabled = false;
            this.DPTUnit.Font = new System.Drawing.Font("Cairo", 9F);
            this.DPTUnit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPTUnit.Location = new System.Drawing.Point(82, 277);
            this.DPTUnit.Name = "DPTUnit";
            this.DPTUnit.Size = new System.Drawing.Size(249, 36);
            this.DPTUnit.TabIndex = 115;
            this.DPTUnit.Value = new System.DateTime(2022, 10, 8, 21, 4, 0, 0);
            // 
            // DPDUnit
            // 
            this.DPDUnit.CalendarFont = new System.Drawing.Font("Cairo", 9F);
            this.DPDUnit.CustomFormat = "dd/MM/yyyy";
            this.DPDUnit.Enabled = false;
            this.DPDUnit.Font = new System.Drawing.Font("Cairo", 9F);
            this.DPDUnit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPDUnit.Location = new System.Drawing.Point(82, 210);
            this.DPDUnit.Name = "DPDUnit";
            this.DPDUnit.Size = new System.Drawing.Size(249, 36);
            this.DPDUnit.TabIndex = 116;
            this.DPDUnit.Value = new System.DateTime(2022, 10, 8, 0, 0, 0, 0);
            // 
            // txtNameUnit
            // 
            this.txtNameUnit.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameUnit.Location = new System.Drawing.Point(82, 142);
            this.txtNameUnit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNameUnit.Name = "txtNameUnit";
            this.txtNameUnit.Size = new System.Drawing.Size(249, 36);
            this.txtNameUnit.TabIndex = 117;
            this.txtNameUnit.TextChanged += new System.EventHandler(this.txtNameUnit_TextChanged);
            this.txtNameUnit.Leave += new System.EventHandler(this.txtNameUnit_Leave);
            // 
            // FormAddUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 461);
            this.Controls.Add(this.txtNameUnit);
            this.Controls.Add(this.DPDUnit);
            this.Controls.Add(this.DPTUnit);
            this.Controls.Add(this.txtUsetAU);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdUnit);
            this.Controls.Add(this.panelRigUnit);
            this.Controls.Add(this.panelHeadUnit);
            this.Controls.Add(this.panelBorderUnit);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddUnit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddUnit";
            this.Load += new System.EventHandler(this.FormAddUnit_Load);
            this.panelRigUnit.ResumeLayout(false);
            this.panelHeadUnit.ResumeLayout(false);
            this.panelHeadUnit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSaveDataUnit;
        private System.Windows.Forms.Button btnRegisterUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdUnit;
        private System.Windows.Forms.Panel panelRigUnit;
        private System.Windows.Forms.Panel panelHeadUnit;
        private System.Windows.Forms.Label labVisUnit;
        private System.Windows.Forms.Panel panelBorderUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsetAU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DPTUnit;
        private System.Windows.Forms.Button btnEditU;
        private System.Windows.Forms.DateTimePicker DPDUnit;
        private System.Windows.Forms.TextBox txtNameUnit;
    }
}