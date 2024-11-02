namespace Projectfinal
{
    partial class Pay
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
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.slip = new System.Windows.Forms.PictureBox();
            this.labelCourt = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.confirm_but = new System.Windows.Forms.Button();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.slip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(114, 346);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(203, 32);
            this.labelTotalPrice.TabIndex = 0;
            this.labelTotalPrice.Text = "\"ราคา : 0 THB\"";
            this.labelTotalPrice.Click += new System.EventHandler(this.labelTotalPrice_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(818, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // slip
            // 
            this.slip.BackColor = System.Drawing.Color.Transparent;
            this.slip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.slip.Location = new System.Drawing.Point(614, 364);
            this.slip.Name = "slip";
            this.slip.Size = new System.Drawing.Size(109, 28);
            this.slip.TabIndex = 2;
            this.slip.TabStop = false;
            this.slip.Click += new System.EventHandler(this.slip_Click);
            // 
            // labelCourt
            // 
            this.labelCourt.AutoSize = true;
            this.labelCourt.BackColor = System.Drawing.Color.Transparent;
            this.labelCourt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourt.Location = new System.Drawing.Point(116, 164);
            this.labelCourt.Name = "labelCourt";
            this.labelCourt.Size = new System.Drawing.Size(134, 29);
            this.labelCourt.TabIndex = 4;
            this.labelCourt.Text = "labelCourt";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(116, 206);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(125, 29);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "labelDate";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.BackColor = System.Drawing.Color.Transparent;
            this.labelStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.Location = new System.Drawing.Point(116, 252);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(185, 29);
            this.labelStartTime.TabIndex = 6;
            this.labelStartTime.Text = "labelStartTime";
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.BackColor = System.Drawing.Color.Transparent;
            this.labelEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndTime.Location = new System.Drawing.Point(116, 299);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(177, 29);
            this.labelEndTime.TabIndex = 7;
            this.labelEndTime.Text = "labelEndTime";
            // 
            // confirm_but
            // 
            this.confirm_but.BackColor = System.Drawing.Color.Transparent;
            this.confirm_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_but.ForeColor = System.Drawing.Color.Transparent;
            this.confirm_but.Location = new System.Drawing.Point(416, 440);
            this.confirm_but.Name = "confirm_but";
            this.confirm_but.Size = new System.Drawing.Size(107, 34);
            this.confirm_but.TabIndex = 8;
            this.confirm_but.UseVisualStyleBackColor = false;
            this.confirm_but.Click += new System.EventHandler(this.confirm_but_Click);
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Location = new System.Drawing.Point(614, 164);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(125, 130);
            this.pictureBoxQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQRCode.TabIndex = 10;
            this.pictureBoxQRCode.TabStop = false;
            this.pictureBoxQRCode.Click += new System.EventHandler(this.pictureBoxQRCode_Click);
            // 
            // Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projectfinal.Properties.Resources.Form4_edit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 506);
            this.Controls.Add(this.pictureBoxQRCode);
            this.Controls.Add(this.confirm_but);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelCourt);
            this.Controls.Add(this.slip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTotalPrice);
            this.DoubleBuffered = true;
            this.Name = "Pay";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay";
            this.Load += new System.EventHandler(this.Pay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox slip;
        private System.Windows.Forms.Label labelCourt;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.Button confirm_but;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
    }
}