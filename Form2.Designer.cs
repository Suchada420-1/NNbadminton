namespace Projectfinal
{
    partial class Form2
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
            this.fnamere = new System.Windows.Forms.TextBox();
            this.lnamere = new System.Windows.Forms.TextBox();
            this.phonere = new System.Windows.Forms.TextBox();
            this.eamilre = new System.Windows.Forms.TextBox();
            this.passwordre = new System.Windows.Forms.TextBox();
            this.confirmbut = new System.Windows.Forms.Button();
            this.Backbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fnamere
            // 
            this.fnamere.BackColor = System.Drawing.SystemColors.Window;
            this.fnamere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnamere.Location = new System.Drawing.Point(122, 154);
            this.fnamere.Name = "fnamere";
            this.fnamere.Size = new System.Drawing.Size(319, 34);
            this.fnamere.TabIndex = 0;
            this.fnamere.TextChanged += new System.EventHandler(this.fnamere_TextChanged);
            // 
            // lnamere
            // 
            this.lnamere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnamere.Location = new System.Drawing.Point(541, 158);
            this.lnamere.Name = "lnamere";
            this.lnamere.Size = new System.Drawing.Size(318, 34);
            this.lnamere.TabIndex = 1;
            this.lnamere.TextChanged += new System.EventHandler(this.lnamere_TextChanged);
            // 
            // phonere
            // 
            this.phonere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonere.Location = new System.Drawing.Point(122, 249);
            this.phonere.Name = "phonere";
            this.phonere.Size = new System.Drawing.Size(319, 34);
            this.phonere.TabIndex = 2;
            this.phonere.TextChanged += new System.EventHandler(this.phonere_TextChanged);
            // 
            // eamilre
            // 
            this.eamilre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eamilre.Location = new System.Drawing.Point(541, 249);
            this.eamilre.Name = "eamilre";
            this.eamilre.Size = new System.Drawing.Size(318, 34);
            this.eamilre.TabIndex = 3;
            this.eamilre.TextChanged += new System.EventHandler(this.eamilre_TextChanged);
            // 
            // passwordre
            // 
            this.passwordre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordre.Location = new System.Drawing.Point(304, 358);
            this.passwordre.Name = "passwordre";
            this.passwordre.Size = new System.Drawing.Size(311, 34);
            this.passwordre.TabIndex = 4;
            this.passwordre.TextChanged += new System.EventHandler(this.passwordre_TextChanged);
            // 
            // confirmbut
            // 
            this.confirmbut.BackColor = System.Drawing.Color.Transparent;
            this.confirmbut.FlatAppearance.BorderSize = 0;
            this.confirmbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.confirmbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmbut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbut.ForeColor = System.Drawing.Color.Transparent;
            this.confirmbut.Location = new System.Drawing.Point(402, 418);
            this.confirmbut.Name = "confirmbut";
            this.confirmbut.Size = new System.Drawing.Size(101, 35);
            this.confirmbut.TabIndex = 5;
            this.confirmbut.UseVisualStyleBackColor = false;
            this.confirmbut.Click += new System.EventHandler(this.confirmbut_Click);
            // 
            // Backbut
            // 
            this.Backbut.BackColor = System.Drawing.Color.Transparent;
            this.Backbut.FlatAppearance.BorderSize = 0;
            this.Backbut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Backbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Backbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbut.Location = new System.Drawing.Point(818, 471);
            this.Backbut.Name = "Backbut";
            this.Backbut.Size = new System.Drawing.Size(75, 23);
            this.Backbut.TabIndex = 6;
            this.Backbut.UseVisualStyleBackColor = false;
            this.Backbut.Click += new System.EventHandler(this.Backbut_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projectfinal.Properties.Resources.Form2_edit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 506);
            this.Controls.Add(this.Backbut);
            this.Controls.Add(this.confirmbut);
            this.Controls.Add(this.passwordre);
            this.Controls.Add(this.eamilre);
            this.Controls.Add(this.phonere);
            this.Controls.Add(this.lnamere);
            this.Controls.Add(this.fnamere);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnamere;
        private System.Windows.Forms.TextBox lnamere;
        private System.Windows.Forms.TextBox phonere;
        private System.Windows.Forms.TextBox eamilre;
        private System.Windows.Forms.TextBox passwordre;
        private System.Windows.Forms.Button confirmbut;
        private System.Windows.Forms.Button Backbut;
    }
}