namespace Projectfinal
{
    partial class Form3
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Court1but = new System.Windows.Forms.Button();
            this.Court2but = new System.Windows.Forms.Button();
            this.Court3but = new System.Windows.Forms.Button();
            this.Court4but = new System.Windows.Forms.Button();
            this.Logoutbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Court1but
            // 
            this.Court1but.BackgroundImage = global::Projectfinal.Properties.Resources.C1_form3;
            this.Court1but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Court1but.Location = new System.Drawing.Point(207, 123);
            this.Court1but.Name = "Court1but";
            this.Court1but.Size = new System.Drawing.Size(189, 162);
            this.Court1but.TabIndex = 3;
            this.Court1but.UseVisualStyleBackColor = true;
            this.Court1but.Click += new System.EventHandler(this.Court1but_Click);
            // 
            // Court2but
            // 
            this.Court2but.BackgroundImage = global::Projectfinal.Properties.Resources.C2_form3;
            this.Court2but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Court2but.Location = new System.Drawing.Point(511, 123);
            this.Court2but.Name = "Court2but";
            this.Court2but.Size = new System.Drawing.Size(189, 162);
            this.Court2but.TabIndex = 4;
            this.Court2but.UseVisualStyleBackColor = true;
            this.Court2but.Click += new System.EventHandler(this.Court2but_Click);
            // 
            // Court3but
            // 
            this.Court3but.BackgroundImage = global::Projectfinal.Properties.Resources.C3_form3;
            this.Court3but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Court3but.Location = new System.Drawing.Point(207, 314);
            this.Court3but.Name = "Court3but";
            this.Court3but.Size = new System.Drawing.Size(189, 162);
            this.Court3but.TabIndex = 5;
            this.Court3but.UseVisualStyleBackColor = true;
            this.Court3but.Click += new System.EventHandler(this.Court3but_Click);
            // 
            // Court4but
            // 
            this.Court4but.BackgroundImage = global::Projectfinal.Properties.Resources.C4_form3;
            this.Court4but.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Court4but.Location = new System.Drawing.Point(511, 314);
            this.Court4but.Name = "Court4but";
            this.Court4but.Size = new System.Drawing.Size(189, 162);
            this.Court4but.TabIndex = 6;
            this.Court4but.UseVisualStyleBackColor = true;
            this.Court4but.Click += new System.EventHandler(this.Court4but_Click);
            // 
            // Logoutbut
            // 
            this.Logoutbut.BackColor = System.Drawing.Color.Transparent;
            this.Logoutbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logoutbut.FlatAppearance.BorderSize = 0;
            this.Logoutbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutbut.Location = new System.Drawing.Point(827, 445);
            this.Logoutbut.Name = "Logoutbut";
            this.Logoutbut.Size = new System.Drawing.Size(66, 49);
            this.Logoutbut.TabIndex = 7;
            this.Logoutbut.UseVisualStyleBackColor = false;
            this.Logoutbut.Click += new System.EventHandler(this.Logoutbut_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projectfinal.Properties.Resources.Form3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 506);
            this.Controls.Add(this.Logoutbut);
            this.Controls.Add(this.Court4but);
            this.Controls.Add(this.Court3but);
            this.Controls.Add(this.Court2but);
            this.Controls.Add(this.Court1but);
            this.Controls.Add(this.dateTimePicker1);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourtID";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Court1but;
        private System.Windows.Forms.Button Court2but;
        private System.Windows.Forms.Button Court3but;
        private System.Windows.Forms.Button Court4but;
        private System.Windows.Forms.Button Logoutbut;
    }
}