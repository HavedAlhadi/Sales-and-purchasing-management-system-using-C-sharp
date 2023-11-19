namespace SuperSoft
{
    partial class Form_AddGroup
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
            this.labVisUnit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveDataGroup = new System.Windows.Forms.Button();
            this.txtNameGroup = new System.Windows.Forms.TextBox();
            this.txtIdGroup = new System.Windows.Forms.TextBox();
            this.panelRegGroup = new System.Windows.Forms.Panel();
            this.btnEditG = new System.Windows.Forms.Button();
            this.btnRegisterGroup = new System.Windows.Forms.Button();
            this.panelHeadGroup = new System.Windows.Forms.Panel();
            this.panelBorderGroup = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DPTGroupI = new System.Windows.Forms.DateTimePicker();
            this.DPDGroupI = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsetAG = new System.Windows.Forms.TextBox();
            this.panelRegGroup.SuspendLayout();
            this.panelHeadGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "إضافة  مجموعة";
            // 
            // labVisUnit
            // 
            this.labVisUnit.AutoSize = true;
            this.labVisUnit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVisUnit.ForeColor = System.Drawing.Color.White;
            this.labVisUnit.Location = new System.Drawing.Point(8, 5);
            this.labVisUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labVisUnit.Name = "labVisUnit";
            this.labVisUnit.Size = new System.Drawing.Size(22, 21);
            this.labVisUnit.TabIndex = 0;
            this.labVisUnit.Text = "X";
            this.labVisUnit.Click += new System.EventHandler(this.labVisUnit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 343);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 29);
            this.label7.TabIndex = 37;
            this.label7.Text = "المستخدم الحالي:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "اسم المجموعة:";
            // 
            // btnSaveDataGroup
            // 
            this.btnSaveDataGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnSaveDataGroup.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDataGroup.ForeColor = System.Drawing.Color.White;
            this.btnSaveDataGroup.Location = new System.Drawing.Point(3, 3);
            this.btnSaveDataGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSaveDataGroup.Name = "btnSaveDataGroup";
            this.btnSaveDataGroup.Size = new System.Drawing.Size(136, 39);
            this.btnSaveDataGroup.TabIndex = 1;
            this.btnSaveDataGroup.Text = "حفظ البيانات";
            this.btnSaveDataGroup.UseCompatibleTextRendering = true;
            this.btnSaveDataGroup.UseVisualStyleBackColor = false;
            this.btnSaveDataGroup.Click += new System.EventHandler(this.btnSaveDataGroup_Click);
            // 
            // txtNameGroup
            // 
            this.txtNameGroup.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameGroup.Location = new System.Drawing.Point(77, 158);
            this.txtNameGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNameGroup.Name = "txtNameGroup";
            this.txtNameGroup.Size = new System.Drawing.Size(286, 36);
            this.txtNameGroup.TabIndex = 39;
            this.txtNameGroup.Leave += new System.EventHandler(this.txtNameGroup_Leave);
            // 
            // txtIdGroup
            // 
            this.txtIdGroup.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdGroup.Location = new System.Drawing.Point(79, 87);
            this.txtIdGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtIdGroup.Name = "txtIdGroup";
            this.txtIdGroup.ReadOnly = true;
            this.txtIdGroup.Size = new System.Drawing.Size(286, 36);
            this.txtIdGroup.TabIndex = 38;
            // 
            // panelRegGroup
            // 
            this.panelRegGroup.Controls.Add(this.btnEditG);
            this.panelRegGroup.Controls.Add(this.btnSaveDataGroup);
            this.panelRegGroup.Controls.Add(this.btnRegisterGroup);
            this.panelRegGroup.Location = new System.Drawing.Point(22, 419);
            this.panelRegGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelRegGroup.Name = "panelRegGroup";
            this.panelRegGroup.Size = new System.Drawing.Size(401, 47);
            this.panelRegGroup.TabIndex = 32;
            // 
            // btnEditG
            // 
            this.btnEditG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnEditG.Font = new System.Drawing.Font("Cairo SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditG.ForeColor = System.Drawing.Color.White;
            this.btnEditG.Location = new System.Drawing.Point(3, 3);
            this.btnEditG.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEditG.Name = "btnEditG";
            this.btnEditG.Size = new System.Drawing.Size(136, 39);
            this.btnEditG.TabIndex = 2;
            this.btnEditG.Text = "تعديل";
            this.btnEditG.UseCompatibleTextRendering = true;
            this.btnEditG.UseVisualStyleBackColor = false;
            this.btnEditG.Click += new System.EventHandler(this.btnEditG_Click);
            // 
            // btnRegisterGroup
            // 
            this.btnRegisterGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.btnRegisterGroup.Font = new System.Drawing.Font("Cairo SemiBold", 9.2F, System.Drawing.FontStyle.Bold);
            this.btnRegisterGroup.ForeColor = System.Drawing.Color.White;
            this.btnRegisterGroup.Location = new System.Drawing.Point(259, 3);
            this.btnRegisterGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegisterGroup.Name = "btnRegisterGroup";
            this.btnRegisterGroup.Size = new System.Drawing.Size(140, 39);
            this.btnRegisterGroup.TabIndex = 0;
            this.btnRegisterGroup.Text = "سجل المجموعات";
            this.btnRegisterGroup.UseCompatibleTextRendering = true;
            this.btnRegisterGroup.UseVisualStyleBackColor = false;
            this.btnRegisterGroup.Click += new System.EventHandler(this.btnRegisterGroup_Click);
            // 
            // panelHeadGroup
            // 
            this.panelHeadGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panelHeadGroup.Controls.Add(this.label2);
            this.panelHeadGroup.Controls.Add(this.labVisUnit);
            this.panelHeadGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeadGroup.Location = new System.Drawing.Point(0, 4);
            this.panelHeadGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelHeadGroup.Name = "panelHeadGroup";
            this.panelHeadGroup.Size = new System.Drawing.Size(431, 31);
            this.panelHeadGroup.TabIndex = 31;
            // 
            // panelBorderGroup
            // 
            this.panelBorderGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.panelBorderGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBorderGroup.ForeColor = System.Drawing.Color.White;
            this.panelBorderGroup.Location = new System.Drawing.Point(0, 0);
            this.panelBorderGroup.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelBorderGroup.Name = "panelBorderGroup";
            this.panelBorderGroup.Size = new System.Drawing.Size(431, 4);
            this.panelBorderGroup.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "رقم المجموعة :";
            // 
            // DPTGroupI
            // 
            this.DPTGroupI.CalendarFont = new System.Drawing.Font("Cairo", 9F);
            this.DPTGroupI.CustomFormat = "hh:mm:ss tt";
            this.DPTGroupI.Enabled = false;
            this.DPTGroupI.Font = new System.Drawing.Font("Cairo", 9F);
            this.DPTGroupI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPTGroupI.Location = new System.Drawing.Point(79, 307);
            this.DPTGroupI.Name = "DPTGroupI";
            this.DPTGroupI.Size = new System.Drawing.Size(286, 36);
            this.DPTGroupI.TabIndex = 105;
            this.DPTGroupI.Value = new System.DateTime(2022, 10, 8, 21, 4, 0, 0);
            // 
            // DPDGroupI
            // 
            this.DPDGroupI.CalendarFont = new System.Drawing.Font("Cairo", 9F);
            this.DPDGroupI.CustomFormat = "dd/MM/yyyy";
            this.DPDGroupI.Enabled = false;
            this.DPDGroupI.Font = new System.Drawing.Font("Cairo", 9F);
            this.DPDGroupI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPDGroupI.Location = new System.Drawing.Point(77, 234);
            this.DPDGroupI.Name = "DPDGroupI";
            this.DPDGroupI.Size = new System.Drawing.Size(286, 36);
            this.DPDGroupI.TabIndex = 104;
            this.DPDGroupI.Value = new System.DateTime(2022, 10, 8, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 34);
            this.label8.TabIndex = 107;
            this.label8.Text = "وقت الإضافة:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 34);
            this.label9.TabIndex = 106;
            this.label9.Text = "تاريخ الإضافة :";
            // 
            // txtUsetAG
            // 
            this.txtUsetAG.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsetAG.Location = new System.Drawing.Point(79, 373);
            this.txtUsetAG.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUsetAG.Name = "txtUsetAG";
            this.txtUsetAG.ReadOnly = true;
            this.txtUsetAG.Size = new System.Drawing.Size(286, 36);
            this.txtUsetAG.TabIndex = 108;
            this.txtUsetAG.Text = "Haved";
            // 
            // Form_AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 476);
            this.Controls.Add(this.txtUsetAG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DPTGroupI);
            this.Controls.Add(this.DPDGroupI);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNameGroup);
            this.Controls.Add(this.txtIdGroup);
            this.Controls.Add(this.panelRegGroup);
            this.Controls.Add(this.panelHeadGroup);
            this.Controls.Add(this.panelBorderGroup);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddGroup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2_AddGroup";
            this.Load += new System.EventHandler(this.Form2_AddGroup_Load);
            this.panelRegGroup.ResumeLayout(false);
            this.panelHeadGroup.ResumeLayout(false);
            this.panelHeadGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labVisUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveDataGroup;
        private System.Windows.Forms.TextBox txtNameGroup;
        private System.Windows.Forms.TextBox txtIdGroup;
        private System.Windows.Forms.Panel panelRegGroup;
        private System.Windows.Forms.Button btnRegisterGroup;
        private System.Windows.Forms.Panel panelHeadGroup;
        private System.Windows.Forms.Panel panelBorderGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DPTGroupI;
        private System.Windows.Forms.DateTimePicker DPDGroupI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUsetAG;
        private System.Windows.Forms.Button btnEditG;
    }
}