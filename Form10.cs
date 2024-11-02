using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectfinal
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Comfirmbut_Click(object sender, EventArgs e)
        {
            string inputCode = textBox1.Text; // รับรหัสจาก TextBox

            // เช็คว่ารหัสที่ป้อนถูกต้องหรือไม่
            if (inputCode == "1111")
            {
                // ถ้ารหัสถูกต้องให้เปิดหน้าถัดไป
                Form5 form5 = new Form5();
                form5.Show();
            }
            else
            {
                // ถ้ารหัสไม่ถูกต้องให้แสดงข้อความแจ้งเตือน
                MessageBox.Show("รหัสไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Backbut_Click(object sender, EventArgs e)
        {
            // เปลี่ยนหน้า Form เป็น Form1
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // ซ่อนหน้า Form ปัจจุบัน
        }
    }
}
