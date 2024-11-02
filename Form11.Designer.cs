namespace Projectfinal
{
    partial class Form11
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
            this.comboBoxEndTime = new System.Windows.Forms.ComboBox();
            this.Confirmbut = new System.Windows.Forms.Button();
            this.Backbut = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(119, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(335, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.comboBoxStartTime.Location = new System.Drawing.Point(611, 209);
            this.comboBoxStartTime.Name = "comboBoxStartTime";
            this.comboBoxStartTime.Size = new System.Drawing.Size(121, 33);
            this.comboBoxStartTime.TabIndex = 1;
            this.comboBoxStartTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxStartTime_SelectedIndexChanged_1);
            // 
            // comboBoxEndTime
            // 
            this.comboBoxEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEndTime.FormattingEnabled = true;
            this.comboBoxEndTime.Items.AddRange(new object[] {
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
            this.comboBoxEndTime.Location = new System.Drawing.Point(611, 324);
            this.comboBoxEndTime.Name = "comboBoxEndTime";
            this.comboBoxEndTime.Size = new System.Drawing.Size(121, 33);
            this.comboBoxEndTime.TabIndex = 2;
            this.comboBoxEndTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxEndTime_SelectedIndexChanged_1);
            // 
            // Confirmbut
            // 
            this.Confirmbut.BackColor = System.Drawing.Color.Transparent;
            this.Confirmbut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Confirmbut.FlatAppearance.BorderSize = 0;
            this.Confirmbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirmbut.Location = new System.Drawing.Point(666, 395);
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(651, 79);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 22);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2024, 7, 10, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projectfinal.Properties.Resources.editform11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 506);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Backbut);
            this.Controls.Add(this.Confirmbut);
            this.Controls.Add(this.comboBoxEndTime);
            this.Controls.Add(this.comboBoxStartTime);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Court1";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxStartTime;
        private System.Windows.Forms.ComboBox comboBoxEndTime;
        private System.Windows.Forms.Button Confirmbut;
        private System.Windows.Forms.Button Backbut;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}