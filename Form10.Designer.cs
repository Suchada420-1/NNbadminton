namespace Projectfinal
{
    partial class Form10
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
            this.Comfirmbut = new System.Windows.Forms.Button();
            this.Backbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(342, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Comfirmbut
            // 
            this.Comfirmbut.BackColor = System.Drawing.Color.Transparent;
            this.Comfirmbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Comfirmbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Comfirmbut.Location = new System.Drawing.Point(425, 295);
            this.Comfirmbut.Name = "Comfirmbut";
            this.Comfirmbut.Size = new System.Drawing.Size(75, 23);
            this.Comfirmbut.TabIndex = 1;
            this.Comfirmbut.UseVisualStyleBackColor = false;
            this.Comfirmbut.Click += new System.EventHandler(this.Comfirmbut_Click);
            // 
            // Backbut
            // 
            this.Backbut.BackColor = System.Drawing.Color.Transparent;
            this.Backbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Backbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbut.Location = new System.Drawing.Point(818, 471);
            this.Backbut.Name = "Backbut";
            this.Backbut.Size = new System.Drawing.Size(75, 23);
            this.Backbut.TabIndex = 2;
            this.Backbut.UseVisualStyleBackColor = false;
            this.Backbut.Click += new System.EventHandler(this.Backbut_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Projectfinal.Properties.Resources.Form10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 506);
            this.Controls.Add(this.Backbut);
            this.Controls.Add(this.Comfirmbut);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Comfirmbut;
        private System.Windows.Forms.Button Backbut;
    }
}