using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projectfinal
{
    public partial class Form2 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=badmintonpro;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void fnamere_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnamere_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonere_TextChanged(object sender, EventArgs e)
        {

        }

        private void eamilre_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordre_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmbut_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่าผู้ใช้กรอกข้อมูลครบทุกช่องหรือไม่
            if (string.IsNullOrWhiteSpace(fnamere.Text) || string.IsNullOrWhiteSpace(lnamere.Text) ||
                string.IsNullOrWhiteSpace(phonere.Text) || string.IsNullOrWhiteSpace(eamilre.Text) ||
                string.IsNullOrWhiteSpace(passwordre.Text))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "Invalid Input");
                return;
            }
            // ตรวจสอบข้อมูล
            if (!IsValidName(fnamere.Text) || !IsValidName(lnamere.Text))
            {
                MessageBox.Show("ชื่อและนามสกุลต้องไม่มีตัวเลข", "Invalid Input");
                return;
            }
            if (!IsValidPhone(phonere.Text))
            {
                MessageBox.Show("เบอร์โทรศัพท์ต้องเป็นตัวเลข 10 หลัก", "Invalid Input");
                return;
            }
            if (!IsValidEmail(eamilre.Text))
            {
                MessageBox.Show("อีเมลต้องลงท้ายด้วย .com เท่านั้น", "Invalid Input");
                return;
            }
            if (!IsValidPassword(passwordre.Text))
            {
                MessageBox.Show("รหัสผ่านต้องมีทั้งตัวอักษรและตัวเลข", "Invalid Input");
                return;
            }

            MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=badmintonpro;");
            try
            {
                conn.Open();
                string sql = "INSERT INTO register(fname, lname, phone, email, password) VALUES (@fname, @lname, @phone, @email, @password)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@fname", fnamere.Text);
                cmd.Parameters.AddWithValue("@lname", lnamere.Text);
                cmd.Parameters.AddWithValue("@phone", phonere.Text);
                cmd.Parameters.AddWithValue("@email", eamilre.Text);
                cmd.Parameters.AddWithValue("@password", passwordre.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Welcome to Nnbadminton, Hope You Enjoy!", "Nnbadminton");
                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Failed to insert data.", "Butter");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Butter");
            }
            finally
            {
                conn.Close();
            }
        }

        // ฟังก์ชันตรวจสอบชื่อ-นามสกุลห้ามมีตัวเลข
        private bool IsValidName(string name)
        {
            return name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        // ฟังก์ชันตรวจสอบเบอร์โทรศัพท์ต้องเป็นตัวเลข 10 หลัก
        private bool IsValidPhone(string phone)
        {
            return phone.Length == 10 && phone.All(char.IsDigit);
        }

        // ฟังก์ชันตรวจสอบอีเมลต้องลงท้ายด้วย .com
        private bool IsValidEmail(string email)
        {
            return email.EndsWith(".com") && email.Contains("@");
        }

        // ฟังก์ชันตรวจสอบรหัสผ่านต้องมีทั้งตัวอักษรและตัวเลข
        private bool IsValidPassword(string password)
        {
            bool hasLetter = password.Any(char.IsLetter);
            bool hasDigit = password.Any(char.IsDigit);
            return hasLetter && hasDigit && password.Length >= 6; // สามารถปรับจำนวนตัวอักษรขั้นต่ำได้
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
