namespace SuperSoft
{
    partial class FormAddCust
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Famle = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.txtPhoneCost = new System.Windows.Forms.TextBox();
            this.txtIdCost = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cash = new System.Windows.Forms.RadioButton();
            this.postpone = new System.Windows.Forms.RadioButton();
            this.txtNameCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_RegisterUser = new System.Windows.Forms.Button();
            this.btnSaveCost = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labCloseFAddIt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtMo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtUasrCost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DPDCost = new System.Windows.Forms.DateTimePicker();
            this.DPTCost = new System.Windows.Forms.DateTimePicker();
            this.txtbalanceCust = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdite = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Famle);
            this.groupBox2.Controls.Add(this.Male);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Font = new System.Drawing.Font("Cairo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.groupBox2.Location = new System.Drawing.Point(217, 513);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(172, 68);
            this.groupBox2.TabIndex = 91;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الجنس";
            // 
            // Famle
            // 
            this.Famle.AutoSize = true;
            this.Famle.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Famle.Location = new System.Drawing.Point(16, 29);
            this.Famle.Margin = new System.Windows.Forms.Padding(2);
            this.Famle.Name = "Famle";
            this.Famle.Size = new System.Drawing.Size(64, 33);
            this.Famle.TabIndex = 1;
            this.Famle.TabStop = true;
            this.Famle.Text = "انثئ";
            this.Famle.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Male.Location = new System.Drawing.Point(84, 29);
            this.Male.Margin = new System.Windows.Forms.Padding(2);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(62, 33);
            this.Male.TabIndex = 0;
            this.Male.TabStop = true;
            this.Male.Text = "ذكر ";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // txtPhoneCost
            // 
            this.txtPhoneCost.BackColor = System.Drawing.Color.White;
            this.txtPhoneCost.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtPhoneCost.Location = new System.Drawing.Point(31, 196);
            this.txtPhoneCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneCost.Name = "txtPhoneCost";
            this.txtPhoneCost.Size = new System.Drawing.Size(358, 36);
            this.txtPhoneCost.TabIndex = 95;
            this.txtPhoneCost.TextChanged += new System.EventHandler(this.txtPhoneCost_TextChanged);
            // 
            // txtIdCost
            // 
            this.txtIdCost.BackColor = System.Drawing.Color.White;
            this.txtIdCost.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtIdCost.Location = new System.Drawing.Point(31, 77);
            this.txtIdCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIdCost.Name = "txtIdCost";
            this.txtIdCost.ReadOnly = true;
            this.txtIdCost.Size = new System.Drawing.Size(358, 36);
            this.txtIdCost.TabIndex = 94;
            this.txtIdCost.TextChanged += new System.EventHandler(this.txtIdCost_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cash);
            this.groupBox1.Controls.Add(this.postpone);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.groupBox1.Location = new System.Drawing.Point(31, 513);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(172, 68);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نوع التعامل";
            // 
            // Cash
            // 
            this.Cash.AutoSize = true;
            this.Cash.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cash.Location = new System.Drawing.Point(21, 29);
            this.Cash.Margin = new System.Windows.Forms.Padding(2);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(61, 33);
            this.Cash.TabIndex = 1;
            this.Cash.TabStop = true;
            this.Cash.Text = "نقد ";
            this.Cash.UseVisualStyleBackColor = true;
            // 
            // postpone
            // 
            this.postpone.AutoSize = true;
            this.postpone.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postpone.Location = new System.Drawing.Point(86, 29);
            this.postpone.Margin = new System.Windows.Forms.Padding(2);
            this.postpone.Name = "postpone";
            this.postpone.Size = new System.Drawing.Size(59, 33);
            this.postpone.TabIndex = 0;
            this.postpone.TabStop = true;
            this.postpone.Text = "آجل";
            this.postpone.UseVisualStyleBackColor = true;
            // 
            // txtNameCost
            // 
            this.txtNameCost.BackColor = System.Drawing.Color.White;
            this.txtNameCost.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtNameCost.Location = new System.Drawing.Point(31, 137);
            this.txtNameCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameCost.Name = "txtNameCost";
            this.txtNameCost.Size = new System.Drawing.Size(358, 36);
            this.txtNameCost.TabIndex = 93;
            this.txtNameCost.TextChanged += new System.EventHandler(this.txtNameCost_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Cairo", 9F);
            this.label8.Location = new System.Drawing.Point(26, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 34);
            this.label8.TabIndex = 89;
            this.label8.Text = "وقت لاضافة";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cairo", 9F);
            this.label9.Location = new System.Drawing.Point(30, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 34);
            this.label9.TabIndex = 88;
            this.label9.Text = "تاريخ الاضافة :";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Cairo", 9F);
            this.label10.Location = new System.Drawing.Point(29, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 42);
            this.label10.TabIndex = 87;
            this.label10.Text = "العنوان :";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Cairo", 9F);
            this.label11.Location = new System.Drawing.Point(26, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 34);
            this.label11.TabIndex = 86;
            this.label11.Text = "رقم الهاتف :";
            // 
            // Btn_RegisterUser
            // 
            this.Btn_RegisterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.Btn_RegisterUser.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RegisterUser.ForeColor = System.Drawing.Color.White;
            this.Btn_RegisterUser.Location = new System.Drawing.Point(19, 650);
            this.Btn_RegisterUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Btn_RegisterUser.Name = "Btn_RegisterUser";
            this.Btn_RegisterUser.Size = new System.Drawing.Size(128, 42);
            this.Btn_RegisterUser.TabIndex = 85;
            this.Btn_RegisterUser.Text = "سجل العملاء";
            this.Btn_RegisterUser.UseVisualStyleBackColor = false;
            this.Btn_RegisterUser.Click += new System.EventHandler(this.Btn_RegisterUser_Click);
            // 
            // btnSaveCost
            // 
            this.btnSaveCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnSaveCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCost.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCost.ForeColor = System.Drawing.Color.Transparent;
            this.btnSaveCost.Location = new System.Drawing.Point(281, 650);
            this.btnSaveCost.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveCost.Name = "btnSaveCost";
            this.btnSaveCost.Size = new System.Drawing.Size(128, 42);
            this.btnSaveCost.TabIndex = 84;
            this.btnSaveCost.Text = "حفظ البيانات";
            this.btnSaveCost.UseVisualStyleBackColor = false;
            this.btnSaveCost.Click += new System.EventHandler(this.btnSaveCost_Click);
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
            this.panel1.Size = new System.Drawing.Size(421, 36);
            this.panel1.TabIndex = 80;
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
            this.label5.Location = new System.Drawing.Point(151, 4);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "اضافة عميل ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 83;
            this.label2.Text = "رقم العميل :";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 82;
            this.label1.Text = "اسم العميل :";
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
            this.panel3.Size = new System.Drawing.Size(421, 5);
            this.panel3.TabIndex = 81;
            // 
            // txtMo
            // 
            this.txtMo.BackColor = System.Drawing.Color.White;
            this.txtMo.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtMo.Location = new System.Drawing.Point(31, 436);
            this.txtMo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMo.Multiline = true;
            this.txtMo.Name = "txtMo";
            this.txtMo.Size = new System.Drawing.Size(358, 61);
            this.txtMo.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Cairo", 9F);
            this.label3.Location = new System.Drawing.Point(31, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 42);
            this.label3.TabIndex = 98;
            this.label3.Text = "ملاحظة:";
            // 
            // txtAdress
            // 
            this.txtAdress.BackColor = System.Drawing.Color.White;
            this.txtAdress.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtAdress.Location = new System.Drawing.Point(32, 376);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(171, 36);
            this.txtAdress.TabIndex = 100;
            // 
            // txtUasrCost
            // 
            this.txtUasrCost.BackColor = System.Drawing.Color.White;
            this.txtUasrCost.Enabled = false;
            this.txtUasrCost.Font = new System.Drawing.Font("Cairo", 8F);
            this.txtUasrCost.Location = new System.Drawing.Point(31, 607);
            this.txtUasrCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUasrCost.Name = "txtUasrCost";
            this.txtUasrCost.ReadOnly = true;
            this.txtUasrCost.Size = new System.Drawing.Size(358, 32);
            this.txtUasrCost.TabIndex = 119;
            this.txtUasrCost.Text = "HAVED";
            this.txtUasrCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 581);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 29);
            this.label13.TabIndex = 118;
            this.label13.Text = "المستخدم الحالي:";
            // 
            // DPDCost
            // 
            this.DPDCost.CalendarFont = new System.Drawing.Font("Cairo", 9F);
            this.DPDCost.CustomFormat = "dd/MM/yyyy";
            this.DPDCost.Enabled = false;
            this.DPDCost.Font = new System.Drawing.Font("Cairo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPDCost.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPDCost.Location = new System.Drawing.Point(34, 254);
            this.DPDCost.Name = "DPDCost";
            this.DPDCost.Size = new System.Drawing.Size(356, 32);
            this.DPDCost.TabIndex = 121;
            this.DPDCost.Value = new System.DateTime(2022, 10, 8, 0, 0, 0, 0);
            this.DPDCost.ValueChanged += new System.EventHandler(this.DPDCost_ValueChanged);
            // 
            // DPTCost
            // 
            this.DPTCost.CalendarFont = new System.Drawing.Font("Cairo", 9F);
            this.DPTCost.CustomFormat = "hh:mm:ss tt";
            this.DPTCost.Enabled = false;
            this.DPTCost.Font = new System.Drawing.Font("Cairo", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPTCost.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPTCost.Location = new System.Drawing.Point(32, 313);
            this.DPTCost.Name = "DPTCost";
            this.DPTCost.Size = new System.Drawing.Size(358, 32);
            this.DPTCost.TabIndex = 120;
            this.DPTCost.Value = new System.DateTime(2022, 10, 8, 21, 4, 0, 0);
            this.DPTCost.ValueChanged += new System.EventHandler(this.DPTCost_ValueChanged);
            // 
            // txtbalanceCust
            // 
            this.txtbalanceCust.BackColor = System.Drawing.Color.White;
            this.txtbalanceCust.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtbalanceCust.Location = new System.Drawing.Point(219, 376);
            this.txtbalanceCust.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbalanceCust.Name = "txtbalanceCust";
            this.txtbalanceCust.Size = new System.Drawing.Size(171, 36);
            this.txtbalanceCust.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Cairo", 9F);
            this.label4.Location = new System.Drawing.Point(216, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 42);
            this.label4.TabIndex = 122;
            this.label4.Text = "الرصيد:";
            // 
            // btnEdite
            // 
            this.btnEdite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.btnEdite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdite.Font = new System.Drawing.Font("Cairo", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdite.ForeColor = System.Drawing.Color.Transparent;
            this.btnEdite.Location = new System.Drawing.Point(281, 650);
            this.btnEdite.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdite.Name = "btnEdite";
            this.btnEdite.Size = new System.Drawing.Size(128, 42);
            this.btnEdite.TabIndex = 124;
            this.btnEdite.Text = "تعديل";
            this.btnEdite.UseVisualStyleBackColor = false;
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // FormAddCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 700);
            this.Controls.Add(this.btnEdite);
            this.Controls.Add(this.txtbalanceCust);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DPDCost);
            this.Controls.Add(this.DPTCost);
            this.Controls.Add(this.txtUasrCost);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtMo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtPhoneCost);
            this.Controls.Add(this.txtIdCost);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNameCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Btn_RegisterUser);
            this.Controls.Add(this.btnSaveCost);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddCust";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddCust";
            this.Load += new System.EventHandler(this.FormAddCust_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Famle;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.TextBox txtPhoneCost;
        private System.Windows.Forms.TextBox txtIdCost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Cash;
        private System.Windows.Forms.RadioButton postpone;
        private System.Windows.Forms.TextBox txtNameCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Btn_RegisterUser;
        private System.Windows.Forms.Button btnSaveCost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labCloseFAddIt;
        private System.Windows.Forms.TextBox txtMo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtUasrCost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker DPDCost;
        private System.Windows.Forms.DateTimePicker DPTCost;
        private System.Windows.Forms.TextBox txtbalanceCust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdite;
    }
}