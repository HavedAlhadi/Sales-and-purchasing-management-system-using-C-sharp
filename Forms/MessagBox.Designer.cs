namespace SuperSoft
{
    partial class MessagBoxH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagBoxH));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MesTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMesAdd = new System.Windows.Forms.Panel();
            this.MesClose = new Haved7Controls.AlhadiButton();
            this.MesText = new System.Windows.Forms.Label();
            this.MesIcon = new System.Windows.Forms.PictureBox();
            this.panelMesCloseP = new System.Windows.Forms.Panel();
            this.Yes = new Haved7Controls.AlhadiButton();
            this.No = new Haved7Controls.AlhadiButton();
            this.labelCloseP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelErorr = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.alhadiButton1 = new Haved7Controls.AlhadiButton();
            this.labelError = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panelMesAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesIcon)).BeginInit();
            this.panelMesCloseP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelErorr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.MesTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 31);
            this.panel3.TabIndex = 20;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MesTitle
            // 
            this.MesTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MesTitle.AutoSize = true;
            this.MesTitle.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesTitle.ForeColor = System.Drawing.Color.White;
            this.MesTitle.Location = new System.Drawing.Point(200, 0);
            this.MesTitle.Name = "MesTitle";
            this.MesTitle.Size = new System.Drawing.Size(55, 29);
            this.MesTitle.TabIndex = 2;
            this.MesTitle.Text = "عزيزي";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 4);
            this.panel1.TabIndex = 19;
            // 
            // panelMesAdd
            // 
            this.panelMesAdd.Controls.Add(this.MesClose);
            this.panelMesAdd.Controls.Add(this.MesText);
            this.panelMesAdd.Controls.Add(this.MesIcon);
            this.panelMesAdd.Location = new System.Drawing.Point(32, 36);
            this.panelMesAdd.Name = "panelMesAdd";
            this.panelMesAdd.Size = new System.Drawing.Size(200, 120);
            this.panelMesAdd.TabIndex = 21;
            // 
            // MesClose
            // 
            this.MesClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.MesClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.MesClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.MesClose.BorderRadius = 20;
            this.MesClose.BorderSize = 0;
            this.MesClose.FlatAppearance.BorderSize = 0;
            this.MesClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MesClose.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesClose.ForeColor = System.Drawing.Color.White;
            this.MesClose.Location = new System.Drawing.Point(62, 80);
            this.MesClose.Name = "MesClose";
            this.MesClose.Size = new System.Drawing.Size(83, 37);
            this.MesClose.TabIndex = 6;
            this.MesClose.Text = "إغلاق";
            this.MesClose.TextColor = System.Drawing.Color.White;
            this.MesClose.UseVisualStyleBackColor = false;
            this.MesClose.Click += new System.EventHandler(this.MesClose_Click);
            // 
            // MesText
            // 
            this.MesText.AutoSize = true;
            this.MesText.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesText.ForeColor = System.Drawing.Color.Black;
            this.MesText.Location = new System.Drawing.Point(62, 33);
            this.MesText.Name = "MesText";
            this.MesText.Size = new System.Drawing.Size(121, 29);
            this.MesText.TabIndex = 4;
            this.MesText.Text = "تم الإضافة بنجاح";
            // 
            // MesIcon
            // 
            this.MesIcon.Image = ((System.Drawing.Image)(resources.GetObject("MesIcon.Image")));
            this.MesIcon.Location = new System.Drawing.Point(16, 29);
            this.MesIcon.Name = "MesIcon";
            this.MesIcon.Size = new System.Drawing.Size(40, 37);
            this.MesIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MesIcon.TabIndex = 5;
            this.MesIcon.TabStop = false;
            // 
            // panelMesCloseP
            // 
            this.panelMesCloseP.Controls.Add(this.Yes);
            this.panelMesCloseP.Controls.Add(this.No);
            this.panelMesCloseP.Controls.Add(this.labelCloseP);
            this.panelMesCloseP.Controls.Add(this.pictureBox1);
            this.panelMesCloseP.Location = new System.Drawing.Point(0, 44);
            this.panelMesCloseP.Name = "panelMesCloseP";
            this.panelMesCloseP.Size = new System.Drawing.Size(258, 120);
            this.panelMesCloseP.TabIndex = 22;
            // 
            // Yes
            // 
            this.Yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.Yes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.Yes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Yes.BorderRadius = 20;
            this.Yes.BorderSize = 0;
            this.Yes.FlatAppearance.BorderSize = 0;
            this.Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yes.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yes.ForeColor = System.Drawing.Color.White;
            this.Yes.Location = new System.Drawing.Point(131, 80);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(83, 37);
            this.Yes.TabIndex = 7;
            this.Yes.Text = "نعم";
            this.Yes.TextColor = System.Drawing.Color.White;
            this.Yes.UseVisualStyleBackColor = false;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // No
            // 
            this.No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.No.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.No.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.No.BorderRadius = 20;
            this.No.BorderSize = 0;
            this.No.FlatAppearance.BorderSize = 0;
            this.No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No.ForeColor = System.Drawing.Color.White;
            this.No.Location = new System.Drawing.Point(42, 80);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(83, 37);
            this.No.TabIndex = 6;
            this.No.Text = "لا";
            this.No.TextColor = System.Drawing.Color.White;
            this.No.UseVisualStyleBackColor = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // labelCloseP
            // 
            this.labelCloseP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCloseP.AutoSize = true;
            this.labelCloseP.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloseP.ForeColor = System.Drawing.Color.Black;
            this.labelCloseP.Location = new System.Drawing.Point(58, 30);
            this.labelCloseP.Name = "labelCloseP";
            this.labelCloseP.Size = new System.Drawing.Size(173, 29);
            this.labelCloseP.TabIndex = 4;
            this.labelCloseP.Text = "هل  تريد إغلاق البرنامج؟";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panelErorr
            // 
            this.panelErorr.Controls.Add(this.label2);
            this.panelErorr.Controls.Add(this.alhadiButton1);
            this.panelErorr.Controls.Add(this.labelError);
            this.panelErorr.Controls.Add(this.pictureBox2);
            this.panelErorr.Location = new System.Drawing.Point(4, 39);
            this.panelErorr.Name = "panelErorr";
            this.panelErorr.Size = new System.Drawing.Size(252, 127);
            this.panelErorr.TabIndex = 23;
            this.panelErorr.Paint += new System.Windows.Forms.PaintEventHandler(this.panelErorr_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(97, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "خطاء:";
            // 
            // alhadiButton1
            // 
            this.alhadiButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.alhadiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(143)))), ((int)(((byte)(188)))));
            this.alhadiButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.alhadiButton1.BorderRadius = 20;
            this.alhadiButton1.BorderSize = 0;
            this.alhadiButton1.FlatAppearance.BorderSize = 0;
            this.alhadiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alhadiButton1.Font = new System.Drawing.Font("Cairo", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alhadiButton1.ForeColor = System.Drawing.Color.White;
            this.alhadiButton1.Location = new System.Drawing.Point(76, 83);
            this.alhadiButton1.Name = "alhadiButton1";
            this.alhadiButton1.Size = new System.Drawing.Size(83, 41);
            this.alhadiButton1.TabIndex = 6;
            this.alhadiButton1.Text = "إغلاق";
            this.alhadiButton1.TextColor = System.Drawing.Color.White;
            this.alhadiButton1.UseVisualStyleBackColor = false;
            this.alhadiButton1.Click += new System.EventHandler(this.alhadiButton1_Click);
            // 
            // labelError
            // 
            this.labelError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.labelError.ForeColor = System.Drawing.Color.Black;
            this.labelError.Location = new System.Drawing.Point(181, 17);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(57, 32);
            this.labelError.TabIndex = 4;
            this.labelError.Text = "خطاء:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // MessagBoxH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(258, 176);
            this.Controls.Add(this.panelErorr);
            this.Controls.Add(this.panelMesCloseP);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMesAdd);
            this.Font = new System.Drawing.Font("Cairo", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MessagBoxH";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessagBox";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelMesAdd.ResumeLayout(false);
            this.panelMesAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MesIcon)).EndInit();
            this.panelMesCloseP.ResumeLayout(false);
            this.panelMesCloseP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelErorr.ResumeLayout(false);
            this.panelErorr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MesTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMesAdd;
        private System.Windows.Forms.Label MesText;
        private System.Windows.Forms.PictureBox MesIcon;
        private Haved7Controls.AlhadiButton MesClose;
        private System.Windows.Forms.Panel panelMesCloseP;
        private Haved7Controls.AlhadiButton Yes;
        private Haved7Controls.AlhadiButton No;
        private System.Windows.Forms.Label labelCloseP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelErorr;
        private Haved7Controls.AlhadiButton alhadiButton1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}