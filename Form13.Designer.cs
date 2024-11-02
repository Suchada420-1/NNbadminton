namespace Projectfinal
{
    partial class Form13
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxStartTime = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Confirmbut = new System.Windows.Forms.Button();
            this.Backbut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(124, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(328, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBoxStartTime
            // 
            this.comboBoxStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStartTime.FormattingEnabled = true;
            this.comboBoxStartTime.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00"});
            this.comboBoxStartTime.Location = new System.Drawing.Point(621, 209);
            this.comboBoxStartTime.Name = "comboBoxStartTime";
            this.comboBoxStartTime.Size = new System.Drawing.Size(121, 33);
            this.comboBoxStartTime.TabIndex = 1;
            this.comboBoxStartTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxStartTime_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.comboBox2.Location = new System.Drawing.Point(621, 327);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Confirmbut
            // 
            this.Confirmbut.BackColor = System.Drawing.Color.Transparent;
            this.Confirmbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Confirmbut.FlatAppearance.BorderSize = 0;
            this.Confirmbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Confirmbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirmbut.Location = new System.Drawing.Point(667, 396);
            this.Confirmbut.Name = "Confirmbut";
            this.Confirmbut.Size = new System.Drawing.Size(75, 23);
            this.Confirmbut.TabIndex = 3;
            this.Confirmbut.UseVisualStyleBackColor = false;
            this.Confirmbut.Click += new System.EventHandler(this.Confirmbut_Click);
            // 
            // Backbut
            // 
            this.Backbut.BackColor = System.Drawing.Color.Transparent;
            this.Backbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Backbut.FlatAppearance.BorderSize = 0;
            this.Backbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Backbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbut.Location = new System.Drawing.Point(818, 471);
            this.Backbut.Name = "Backbut";
            this.Backbut.Size = new System.Drawing.Size(75, 23);
            this.Backbut.TabIndex = 4;
            this.Backbut.UseVisualStyleBackColor = false;
            this.Backbut.Click += new System.EventHandler(this.Backbut_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projectfinal.Properties.Resources.Form13;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 506);
            this.Controls.Add(this.Backbut);
            this.Controls.Add(this.Confirmbut);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBoxStartTime);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Form13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Court3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxStartTime;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Confirmbut;
        private System.Windows.Forms.Button Backbut;
    }
}