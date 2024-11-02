using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projectfinal
{
    public partial class Form3 : Form
    {
        // ตัวแปร static เพื่อเก็บข้อมูลที่เลือกจาก Form 3
        public static string SelectedCourt { get; private set; }
        public static DateTime SelectedDate { get; private set; }
        private int userId;
        private string userEmail;
        private string userfname;
        private string userlname;

        public Form3(int userId, string userEmail,string userfname,string userlname)
        {
            InitializeComponent();
            this.userId = userId; // เก็บ userId
            this.userEmail = userEmail;
            this.userfname = userfname;
            this.userlname = userlname;

        }

        private void Court1but_Click(object sender, EventArgs e)
        {
            string selectedCourt = "1"; // ตั้งค่า selectedCourt ตามที่เลือก
            DateTime selectedDate = dateTimePicker1.Value; // รับค่า selectedDate จาก DateTimePicker

            // เปิด Form11 และส่งข้อมูล selectedCourt และ selectedDate ไปด้วย
            Form11 form11 = new Form11(selectedCourt, selectedDate, userId,userEmail,userfname,userlname);
            form11.ShowDialog(); // เปิดเป็นโหมดแบบ modal เพื่อรอผู้ใช้เลือกเวลา
            this.Hide(); // ซ่อน Form 


        }

        private void Logoutbut_Click(object sender, EventArgs e)
        {
            // แสดง MessageBox พร้อมปุ่ม Yes และ No
            DialogResult dialogResult = MessageBox.Show("ออกจากระบบ", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // ตรวจสอบว่าผู้ใช้กด Yes หรือไม่
            if (dialogResult == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide(); // ซ่อนหน้า Form ปัจจุบัน
            }
            else
            {
                // ทำอย่างอื่นหรือไม่ทำอะไรเลยถ้าผู้ใช้กด No
            }
        }

        private void Court2but_Click(object sender, EventArgs e)
        {
            string selectedCourt = "2"; // ตั้งค่า selectedCourt ตามที่เลือก
            DateTime selectedDate = dateTimePicker1.Value; // รับค่า selectedDate จาก DateTimePicker

            // เปิด Form12 และส่งข้อมูล selectedCourt และ selectedDate ไปด้วย
            Form12 form12 = new Form12(selectedCourt, selectedDate, userId, userEmail,userfname,userlname);
            form12.ShowDialog(); // เปิดเป็นโหมดแบบ modal เพื่อรอผู้ใช้เลือกเวลา
            this.Hide(); // ซ่อน Form 
        }

        private void Court3but_Click(object sender, EventArgs e)
        {
            string selectedCourt = "3"; // ตั้งค่า selectedCourt ตามที่เลือก
            DateTime selectedDate = dateTimePicker1.Value; // รับค่า selectedDate จาก DateTimePicker

            // เปิด Form13 และส่งข้อมูล selectedCourt และ selectedDate ไปด้วย
            Form13 form13 = new Form13(selectedCourt, selectedDate, userId, userEmail, userfname, userlname);
            form13.ShowDialog(); // เปิดเป็นโหมดแบบ modal เพื่อรอผู้ใช้เลือกเวลา
            this.Hide(); // ซ่อน Form 
        }

        private void Court4but_Click(object sender, EventArgs e)
        {
            string selectedCourt = "4"; // ตั้งค่า selectedCourt ตามที่เลือก
            DateTime selectedDate = dateTimePicker1.Value; // รับค่า selectedDate จาก DateTimePicker

            // เปิด Form14 และส่งข้อมูล selectedCourt และ selectedDate ไปด้วย
            Form14 form14 = new Form14(selectedCourt, selectedDate, userId, userEmail, userfname, userlname);
            form14.ShowDialog(); // เปิดเป็นโหมดแบบ modal เพื่อรอผู้ใช้เลือกเวลา
            this.Hide(); // ซ่อน Form 
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date < DateTime.Today)
            {
                MessageBox.Show("ไม่สามารถเลือกวันที่่ผ่านมาแล้วได้.", "กรุณาเลือกวันที่ใหม่", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.Value = DateTime.Today;
            }
            else
            {
                SelectedDate = dateTimePicker1.Value;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
