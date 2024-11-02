using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf.parser.clipper;
using MySql.Data.MySqlClient;

namespace Projectfinal
{
    public partial class Form1 : Form
    {
        private int userId;
        private string userEmail;
        private string userfname;
        private string userlname;

        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=badmintonpro;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Logintext_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void passwordtext_TextChanged(object sender, EventArgs e)
        {
            passwordtext.PasswordChar = '*';
        }



        private void LOginbut_Click(object sender, EventArgs e)
        {
            if (Logintext.Text == "" && passwordtext.Text == "")
            {
                MessageBox.Show("กรุณากรอกอีเมลหรือรหัสผ่านให้ถูกต้อง", "Message");
                Logintext.Focus();

            }
            else if (Logintext.Text == "")
            {
                MessageBox.Show("กรุณากรอกอีเมลให้ถูกต้อง", "Message");
                Logintext.Focus();
            }
            else if (passwordtext.Text == "")
            {
                MessageBox.Show("กรุณากรอกรหัสผ่าน", "Message");
                passwordtext.Focus();
            }
            else
            {
                string sql = "SELECT * FROM register WHERE email = @email AND password = @password";
                MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=badmintonpro;");
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", Logintext.Text);
                cmd.Parameters.AddWithValue("@password", passwordtext.Text);

                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // ดึง UserID จาก reader
                    userId = reader.GetInt32("id"); // เก็บ userId ในตัวแปร
                    userEmail = reader.GetString("email");
                    userfname = reader.GetString("fname");
                    userlname = reader.GetString("lname");


                    MessageBox.Show("เข้าสู่ระบบสำเร็จ ยินดีต้อนรับค่ะ:)", "Message");
                    this.Hide();

                    // เปิด Form3 
                    Form3 f = new Form3(userId, userEmail,userfname,userlname);
                    f.Show();

                }
                else
                {
                    MessageBox.Show("กรุณากรอกอีเมลและรหัสผ่านให้ถูกต้อง", "Message");
                    Logintext.Focus();
                }
            }
        }

        private void ForgetPasswordbut_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide(); // ซ่อนหน้า Form ปัจจุบัน
        }

        private void Adminbut_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.Show(); 
            this.Hide(); // ซ่อนหน้า Form ปัจจุบัน 
        }

        private void Registerbut_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); // ซ่อนหน้า Form ปัจจุบัน
        }
    }
}
