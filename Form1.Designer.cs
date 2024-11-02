namespace Projectfinal
{
    partial class Form1
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
            this.Logintext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.Adminbut = new System.Windows.Forms.Button();
            this.Registerbut = new System.Windows.Forms.Button();
            this.Loginbut = new System.Windows.Forms.Button();
            this.ForgetPasswordbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logintext
            // 
            this.Logintext.BackColor = System.Drawing.SystemColors.Window;
            this.Logintext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logintext.Location = new System.Drawing.Point(337, 273);
            this.Logintext.Name = "Logintext";
            this.Logintext.Size = new System.Drawing.Size(246, 30);
            this.Logintext.TabIndex = 0;
            this.Logintext.TextChanged += new System.EventHandler(this.Logintext_TextChanged);
            // 
            // passwordtext
            // 
            this.passwordtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtext.Location = new System.Drawing.Point(337, 366);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(246, 30);
            this.passwordtext.TabIndex = 1;
            this.passwordtext.TextChanged += new System.EventHandler(this.passwordtext_TextChanged);
            // 
            // Adminbut
            // 
            this.Adminbut.BackColor = System.Drawing.Color.Transparent;
            this.Adminbut.FlatAppearance.BorderSize = 0;
            this.Adminbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Adminbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adminbut.ForeColor = System.Drawing.Color.Transparent;
            this.Adminbut.Location = new System.Drawing.Point(44, 54);
            this.Adminbut.Name = "Adminbut";
            this.Adminbut.Size = new System.Drawing.Size(75, 23);
            this.Adminbut.TabIndex = 2;
            this.Adminbut.UseVisualStyleBackColor = false;
            this.Adminbut.Click += new System.EventHandler(this.Adminbut_Click);
            // 
            // Registerbut
            // 
            this.Registerbut.BackColor = System.Drawing.Color.Transparent;
            this.Registerbut.FlatAppearance.BorderSize = 0;
            this.Registerbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Registerbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registerbut.ForeColor = System.Drawing.Color.Transparent;
            this.Registerbut.Location = new System.Drawing.Point(44, 105);
            this.Registerbut.Name = "Registerbut";
            this.Registerbut.Size = new System.Drawing.Size(75, 23);
            this.Registerbut.TabIndex = 3;
            this.Registerbut.UseVisualStyleBackColor = false;
            this.Registerbut.Click += new System.EventHandler(this.Registerbut_Click);
            // 
            // Loginbut
            // 
            this.Loginbut.BackColor = System.Drawing.Color.Transparent;
            this.Loginbut.FlatAppearance.BorderSize = 0;
            this.Loginbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Loginbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbut.ForeColor = System.Drawing.Color.Transparent;
            this.Loginbut.Location = new System.Drawing.Point(413, 415);
            this.Loginbut.Name = "Loginbut";
            this.Loginbut.Size = new System.Drawing.Size(75, 23);
            this.Loginbut.TabIndex = 4;
            this.Loginbut.UseVisualStyleBackColor = false;
            this.Loginbut.Click += new System.EventHandler(this.LOginbut_Click);
            // 
            // ForgetPasswordbut
            // 
            this.ForgetPasswordbut.BackColor = System.Drawing.Color.Transparent;
            this.ForgetPasswordbut.FlatAppearance.BorderSize = 0;
            this.ForgetPasswordbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ForgetPasswordbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgetPasswordbut.ForeColor = System.Drawing.Color.Transparent;
            this.ForgetPasswordbut.Location = new System.Drawing.Point(364, 458);
            this.ForgetPasswordbut.Name = "ForgetPasswordbut";
            this.ForgetPasswordbut.Size = new System.Drawing.Size(183, 23);
            this.ForgetPasswordbut.TabIndex = 5;
            this.ForgetPasswordbut.UseVisualStyleBackColor = false;
            this.ForgetPasswordbut.Click += new System.EventHandler(this.ForgetPasswordbut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projectfinal.Properties.Resources.form1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 506);
            this.Controls.Add(this.ForgetPasswordbut);
            this.Controls.Add(this.Loginbut);
            this.Controls.Add(this.Registerbut);
            this.Controls.Add(this.Adminbut);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.Logintext);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Logintext;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Button Adminbut;
        private System.Windows.Forms.Button Registerbut;
        private System.Windows.Forms.Button Loginbut;
        private System.Windows.Forms.Button ForgetPasswordbut;
    }
}

