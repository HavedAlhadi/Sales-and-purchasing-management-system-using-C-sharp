namespace SuperSoft
{
    partial class FormAddItemcs
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
            this.Btn_RegisterUser = new System.Windows.Forms.Button();
            this.BtnSaveItem = new System.Windows.Forms.Button();
            this.cmbUnitsItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGroubeItem = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPriceItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumPar = new System.Windows.Forms.TextBox();
            this.txtNameItem = new System.Windows.Forms.TextBox();
            this.txtIdItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labCloseFAddIt = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnIEdit = new System.Windows.Forms.Button();
            this.txtQItem = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_earn = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_UserAddItem = new System.Windows.Forms.TextBox();
            this.DPTItim = new System.Windows.Forms.DateTimePicker();
            this.DPDItem = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DPDEItem = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_RegisterUser
            // 
            this.Btn_RegisterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.Btn_RegisterUser.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RegisterUser.ForeColor = System.Drawing.Color.White;
            this.Btn_RegisterUser.Location = new System.Drawing.Point(24, 413);
            this.Btn_RegisterUser.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Btn_RegisterUser.Name = "Btn_RegisterUser";
            this.Btn_RegisterUser.Size = new System.Drawing.Size(189, 42);
            this.Btn_RegisterUser.TabIndex = 86;
            this.Btn_RegisterUser.Text = "سجل الاصناف";
            this.Btn_RegisterUser.UseVisualStyleBackColor = false;
            this.Btn_RegisterUser.Click += new System.EventHandler(this.Btn_RegisterUser_Click);
            // 
            // BtnSaveItem
            // 
            this.BtnSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnSaveItem.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveItem.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSaveItem.Location = new System.Drawing.Point(644, 413);
            this.BtnSaveItem.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSaveItem.Name = "BtnSaveItem";
            this.BtnSaveItem.Size = new System.Drawing.Size(189, 42);
            this.BtnSaveItem.TabIndex = 85;
            this.BtnSaveItem.Text = "حفظ البيانات";
            this.BtnSaveItem.UseVisualStyleBackColor = false;
            this.BtnSaveItem.Click += new System.EventHandler(this.BtnSaveItem_Click);
            // 
            // cmbUnitsItem
            // 
            this.cmbUnitsItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUnitsItem.Font = new System.Drawing.Font("Cairo", 9F);
            this.cmbUnitsItem.FormattingEnabled = true;
            this.cmbUnitsItem.Location = new System.Drawing.Point(570, 187);
            this.cmbUnitsItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUnitsItem.Name = "cmbUnitsItem";
            this.cmbUnitsItem.Size = new System.Drawing.Size(263, 37);
            this.cmbUnitsItem.TabIndex = 84;
            this.cmbUnitsItem.Text = "اختر وحدة الصنف";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(445, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 31);
            this.label4.TabIndex = 83;
            this.label4.Text = "وحدة الصنف :";
            // 
            // cmbGroubeItem
            // 
            this.cmbGroubeItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGroubeItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGroubeItem.Font = new System.Drawing.Font("Cairo", 9F);
            this.cmbGroubeItem.ForeColor = System.Drawing.Color.Black;
            this.cmbGroubeItem.FormattingEnabled = true;
            this.cmbGroubeItem.Location = new System.Drawing.Point(158, 185);
            this.cmbGroubeItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbGroubeItem.Name = "cmbGroubeItem";
            this.cmbGroubeItem.Size = new System.Drawing.Size(263, 37);
            this.cmbGroubeItem.TabIndex = 82;
            this.cmbGroubeItem.Text = "اختر مجموعة الصنف";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 191);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 31);
            this.label10.TabIndex = 79;
            this.label10.Text = "مجموعة الصنف :";
            // 
            // txtPriceItem
            // 
            this.txtPriceItem.BackColor = System.Drawing.Color.White;
            this.txtPriceItem.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtPriceItem.Location = new System.Drawing.Point(569, 132);
            this.txtPriceItem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPriceItem.Multiline = true;
            this.txtPriceItem.Name = "txtPriceItem";
            this.txtPriceItem.Size = new System.Drawing.Size(263, 38);
            this.txtPriceItem.TabIndex = 74;
            this.txtPriceItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(445, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 73;
            this.label1.Text = "سعر الصنف :";
            // 
            // txtNumPar
            // 
            this.txtNumPar.BackColor = System.Drawing.Color.White;
            this.txtNumPar.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtNumPar.Location = new System.Drawing.Point(159, 132);
            this.txtNumPar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNumPar.Multiline = true;
            this.txtNumPar.Name = "txtNumPar";
            this.txtNumPar.Size = new System.Drawing.Size(263, 38);
            this.txtNumPar.TabIndex = 72;
            this.txtNumPar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNameItem
            // 
            this.txtNameItem.BackColor = System.Drawing.Color.White;
            this.txtNameItem.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtNameItem.Location = new System.Drawing.Point(570, 80);
            this.txtNameItem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNameItem.Multiline = true;
            this.txtNameItem.Name = "txtNameItem";
            this.txtNameItem.Size = new System.Drawing.Size(263, 38);
            this.txtNameItem.TabIndex = 71;
            // 
            // txtIdItem
            // 
            this.txtIdItem.BackColor = System.Drawing.Color.White;
            this.txtIdItem.Enabled = false;
            this.txtIdItem.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtIdItem.Location = new System.Drawing.Point(160, 80);
            this.txtIdItem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtIdItem.Multiline = true;
            this.txtIdItem.Name = "txtIdItem";
            this.txtIdItem.ReadOnly = true;
            this.txtIdItem.Size = new System.Drawing.Size(263, 38);
            this.txtIdItem.TabIndex = 70;
            this.txtIdItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 31);
            this.label3.TabIndex = 69;
            this.label3.Text = "باراكود الصنف: ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 68;
            this.label2.Text = "رقم الصنف :";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(445, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 31);
            this.label8.TabIndex = 67;
            this.label8.Text = "اسم الصنف :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.labCloseFAddIt);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Coral;
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 33);
            this.panel1.TabIndex = 65;
            // 
            // labCloseFAddIt
            // 
            this.labCloseFAddIt.AutoSize = true;
            this.labCloseFAddIt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCloseFAddIt.ForeColor = System.Drawing.Color.White;
            this.labCloseFAddIt.Location = new System.Drawing.Point(8, 4);
            this.labCloseFAddIt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCloseFAddIt.Name = "labCloseFAddIt";
            this.labCloseFAddIt.Size = new System.Drawing.Size(22, 21);
            this.labCloseFAddIt.TabIndex = 87;
            this.labCloseFAddIt.Text = "X";
            this.labCloseFAddIt.Click += new System.EventHandler(this.labCloseFAddIt_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(351, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 39);
            this.label12.TabIndex = 64;
            this.label12.Text = "إضاقة صنف";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1422, -1);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "بيانات الاصناف";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cairo", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(992, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 41);
            this.label5.TabIndex = 12;
            this.label5.Text = "اضافة صنف";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.Coral;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(860, 5);
            this.panel3.TabIndex = 66;
            // 
            // BtnIEdit
            // 
            this.BtnIEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnIEdit.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIEdit.ForeColor = System.Drawing.Color.White;
            this.BtnIEdit.Location = new System.Drawing.Point(644, 413);
            this.BtnIEdit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnIEdit.Name = "BtnIEdit";
            this.BtnIEdit.Size = new System.Drawing.Size(189, 42);
            this.BtnIEdit.TabIndex = 105;
            this.BtnIEdit.Text = "تعديل";
            this.BtnIEdit.UseCompatibleTextRendering = true;
            this.BtnIEdit.UseVisualStyleBackColor = false;
            this.BtnIEdit.Visible = false;
            this.BtnIEdit.Click += new System.EventHandler(this.BtnIEdit_Click);
            // 
            // txtQItem
            // 
            this.txtQItem.BackColor = System.Drawing.Color.White;
            this.txtQItem.Font = new System.Drawing.Font("Cairo", 9F);
            this.txtQItem.Location = new System.Drawing.Point(570, 233);
            this.txtQItem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtQItem.Multiline = true;
            this.txtQItem.Name = "txtQItem";
            this.txtQItem.Size = new System.Drawing.Size(263, 38);
            this.txtQItem.TabIndex = 107;
            this.txtQItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(445, 240);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 31);
            this.label14.TabIndex = 106;
            this.label14.Text = "الكمية:";
            // 
            // txt_earn
            // 
            this.txt_earn.BackColor = System.Drawing.Color.White;
            this.txt_earn.Font = new System.Drawing.Font("Cairo", 9F);
            this.txt_earn.Location = new System.Drawing.Point(159, 232);
            this.txt_earn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_earn.Multiline = true;
            this.txt_earn.Name = "txt_earn";
            this.txt_earn.Size = new System.Drawing.Size(263, 38);
            this.txt_earn.TabIndex = 109;
            this.txt_earn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 237);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 31);
            this.label15.TabIndex = 108;
            this.label15.Text = "ربحية الصنف:";
            // 
            // txt_UserAddItem
            // 
            this.txt_UserAddItem.Enabled = false;
            this.txt_UserAddItem.Font = new System.Drawing.Font("Cairo", 9F);
            this.txt_UserAddItem.Location = new System.Drawing.Point(159, 326);
            this.txt_UserAddItem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_UserAddItem.Name = "txt_UserAddItem";
            this.txt_UserAddItem.Size = new System.Drawing.Size(263, 36);
            this.txt_UserAddItem.TabIndex = 117;
            this.txt_UserAddItem.Text = "HAVED";
            // 
            // DPTItim
            // 
            this.DPTItim.CalendarFont = new System.Drawing.Font("Cairo", 9F);
            this.DPTItim.CustomFormat = "hh:mm:ss tt";
            this.DPTItim.Enabled = false;
            this.DPTItim.Font = new System.Drawing.Font("Cairo", 9F);
            this.DPTItim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPTItim.Location = new System.Drawing.Point(569, 279);
            this.DPTItim.Name = "DPTItim";
            this.DPTItim.Size = new System.Drawing.Size(263, 36);
            this.DPTItim.TabIndex = 116;
            this.DPTItim.Value = new System.DateTime(2022, 10, 8, 21, 4, 0, 0);
            // 
            // DPDItem
            // 
            this.DPDItem.CalendarFont = new System.Drawing.Font("Cairo", 9F);
            this.DPDItem.CustomFormat = "dd/MM/yyyy";
            this.DPDItem.Enabled = false;
            this.DPDItem.Font = new System.Drawing.Font("Cairo", 9F);
            this.DPDItem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DPDItem.Location = new System.Drawing.Point(158, 280);
            this.DPDItem.Name = "DPDItem";
            this.DPDItem.Size = new System.Drawing.Size(263, 36);
            this.DPDItem.TabIndex = 115;
            this.DPDItem.Value = new System.DateTime(2022, 10, 8, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 333);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 29);
            this.label13.TabIndex = 114;
            this.label13.Text = "المستخدم الحالي:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(444, 331);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 31);
            this.label11.TabIndex = 113;
            this.label11.Text = "تاريخ الانتهاء:";
            // 
            // DPDEItem
            // 
            this.DPDEItem.Font = new System.Drawing.Font("Cairo", 9F);
            this.DPDEItem.Location = new System.Drawing.Point(569, 326);
            this.DPDEItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DPDEItem.Name = "DPDEItem";
            this.DPDEItem.Size = new System.Drawing.Size(263, 36);
            this.DPDEItem.TabIndex = 112;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(444, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 31);
            this.label7.TabIndex = 111;
            this.label7.Text = "وقت الاضافة :";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 284);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 31);
            this.label9.TabIndex = 110;
            this.label9.Text = "تاريخ الاضافة";
            // 
            // FormAddItemcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 465);
            this.Controls.Add(this.txt_UserAddItem);
            this.Controls.Add(this.DPTItim);
            this.Controls.Add(this.DPDItem);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DPDEItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_earn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtQItem);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BtnIEdit);
            this.Controls.Add(this.Btn_RegisterUser);
            this.Controls.Add(this.BtnSaveItem);
            this.Controls.Add(this.cmbUnitsItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbGroubeItem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPriceItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumPar);
            this.Controls.Add(this.txtNameItem);
            this.Controls.Add(this.txtIdItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddItemcs";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddItemcs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_RegisterUser;
        private System.Windows.Forms.Button BtnSaveItem;
        private System.Windows.Forms.ComboBox cmbUnitsItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGroubeItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPriceItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumPar;
        private System.Windows.Forms.TextBox txtNameItem;
        private System.Windows.Forms.TextBox txtIdItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labCloseFAddIt;
        private System.Windows.Forms.Button BtnIEdit;
        private System.Windows.Forms.TextBox txtQItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_earn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_UserAddItem;
        private System.Windows.Forms.DateTimePicker DPTItim;
        private System.Windows.Forms.DateTimePicker DPDItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DPDEItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}