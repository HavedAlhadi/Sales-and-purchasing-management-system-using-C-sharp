namespace SuperSoft
{
    partial class haved_toolreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(haved_toolreport));
            this.lblItemTime = new System.Windows.Forms.Label();
            this.lblItemSize = new System.Windows.Forms.Label();
            this.imgIcon = new System.Windows.Forms.PictureBox();
            this.lblItemName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemTime
            // 
            this.lblItemTime.AutoSize = true;
            this.lblItemTime.BackColor = System.Drawing.Color.Transparent;
            this.lblItemTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItemTime.Location = new System.Drawing.Point(65, 33);
            this.lblItemTime.Name = "lblItemTime";
            this.lblItemTime.Size = new System.Drawing.Size(41, 26);
            this.lblItemTime.TabIndex = 8;
            this.lblItemTime.Text = "Time";
            this.lblItemTime.Click += new System.EventHandler(this.lblItemTime_Click);
            // 
            // lblItemSize
            // 
            this.lblItemSize.AutoSize = true;
            this.lblItemSize.BackColor = System.Drawing.Color.Transparent;
            this.lblItemSize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.lblItemSize.Location = new System.Drawing.Point(279, 20);
            this.lblItemSize.Name = "lblItemSize";
            this.lblItemSize.Size = new System.Drawing.Size(49, 19);
            this.lblItemSize.TabIndex = 6;
            this.lblItemSize.Text = "0 MB";
            // 
            // imgIcon
            // 
            this.imgIcon.BackColor = System.Drawing.Color.Transparent;
            this.imgIcon.Image = ((System.Drawing.Image)(resources.GetObject("imgIcon.Image")));
            this.imgIcon.Location = new System.Drawing.Point(8, 11);
            this.imgIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgIcon.Name = "imgIcon";
            this.imgIcon.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.imgIcon.Size = new System.Drawing.Size(51, 43);
            this.imgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIcon.TabIndex = 5;
            this.imgIcon.TabStop = false;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Font = new System.Drawing.Font("Cairo SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(21)))), ((int)(((byte)(46)))));
            this.lblItemName.Location = new System.Drawing.Point(65, 10);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(78, 29);
            this.lblItemName.TabIndex = 9;
            this.lblItemName.Text = "File Name";
            this.lblItemName.Click += new System.EventHandler(this.lblItemName_Click_1);
            // 
            // haved_toolreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemTime);
            this.Controls.Add(this.lblItemSize);
            this.Controls.Add(this.imgIcon);
            this.Font = new System.Drawing.Font("Cairo SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "haved_toolreport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(336, 63);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemTime;
        private System.Windows.Forms.Label lblItemSize;
        private System.Windows.Forms.PictureBox imgIcon;
        private System.Windows.Forms.Label lblItemName;
    }
}