namespace Projectfinal
{
    partial class Form9
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CConfirmbut = new System.Windows.Forms.Button();
            this.Backbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(332, 207);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(332, 318);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 30);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CConfirmbut
            // 
            this.CConfirmbut.BackColor = System.Drawing.Color.Transparent;
            this.CConfirmbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CConfirmbut.FlatAppearance.BorderSize = 0;
            this.CConfirmbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CConfirmbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CConfirmbut.ForeColor = System.Drawing.Color.Transparent;
            this.CConfirmbut.Location = new System.Drawing.Point(414, 399);
            this.CConfirmbut.Name = "CConfirmbut";
            this.CConfirmbut.Size = new System.Drawing.Size(75, 23);
            this.CConfirmbut.TabIndex = 2;
            this.CConfirmbut.UseVisualStyleBackColor = false;
            this.CConfirmbut.Click += new System.EventHandler(this.CConfirmbut_Click);
            // 
            // Backbut
            // 
            this.Backbut.BackColor = System.Drawing.Color.Transparent;
            this.Backbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Backbut.FlatAppearance.BorderSize = 0;
            this.Backbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbut.ForeColor = System.Drawing.Color.Transparent;
            this.Backbut.Location = new System.Drawing.Point(818, 471);
            this.Backbut.Name = "Backbut";
            this.Backbut.Size = new System.Drawing.Size(75, 23);
            this.Backbut.TabIndex = 3;
            this.Backbut.UseVisualStyleBackColor = false;
            this.Backbut.Click += new System.EventHandler(this.Backbut_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projectfinal.Properties.Resources.form9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 506);
            this.Controls.Add(this.Backbut);
            this.Controls.Add(this.CConfirmbut);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserEditPassword";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button CConfirmbut;
        private System.Windows.Forms.Button Backbut;
    }
}