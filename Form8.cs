using MySql.Data.MySqlClient;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            LoadComboBoxValues();

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
        
        private void LoadComboBoxValues()
        {
            ComboBox1.Items.Add(""); // เพิ่มค่าว่างก่อน
            for (int i = 1; i <= 31; i++)
            {
                ComboBox1.Items.Add(i.ToString("D2"));
            }

            ComboBox2.Items.Add(""); // เพิ่มค่าว่างก่อน
            for (int i = 1; i <= 12; i++)
            {
                ComboBox2.Items.Add(i.ToString("D2"));
            }

            ComboBox3.Items.Add(""); // เพิ่มค่าว่างก่อน
            for (int i = 2024; i <= 2040; i++)
            {
                ComboBox3.Items.Add(i.ToString());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // รับค่าจาก ComboBox ทั้ง 3
            string day = ComboBox1.SelectedItem?.ToString();
            string month = ComboBox2.SelectedItem?.ToString();
            string year = ComboBox3.SelectedItem?.ToString();

            // ตรวจสอบว่าเลือกปีหรือยัง
            if (string.IsNullOrEmpty(year))
            {
                MessageBox.Show("กรุณาเลือกปี");
                return;
            }

            // ตรวจสอบว่าเดือนถูกเลือกหรือยังถ้ามีการเลือกวัน
            if (!string.IsNullOrEmpty(day) && string.IsNullOrEmpty(month))
            {
                MessageBox.Show("กรุณาเลือกเดือน");
                return;
            }

            // สร้าง connection string สำหรับเชื่อมต่อกับฐานข้อมูล MySQL
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=badmintonpro;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // สร้าง SQL query โดยตรงเพื่อดึงข้อมูลจากคอลัมน์ Price
                    string query;
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;

                    if (string.IsNullOrEmpty(day) && string.IsNullOrEmpty(month))
                    {
                        // ถ้า day และ month เป็นค่าว่าง ให้ดึงข้อมูลแค่ตามปี
                        query = "SELECT * FROM Bookings WHERE YEAR(BookingDate) = @year";
                        cmd.Parameters.AddWithValue("@year", year);
                    }
                    else if (string.IsNullOrEmpty(day))
                    {
                        // ถ้า day เป็นค่าว่าง ให้ดึงข้อมูลตามเดือนและปี
                        query = "SELECT * FROM Bookings WHERE MONTH(BookingDate) = @month AND YEAR(BookingDate) = @year";
                        cmd.Parameters.AddWithValue("@month", month);
                        cmd.Parameters.AddWithValue("@year", year);
                    }
                    else
                    {
                        // ถ้าทั้ง day, month, และ year มีค่า ให้ดึงข้อมูลตามวัน เดือน และปี
                        DateTime selectedDate = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
                        query = "SELECT * FROM Bookings WHERE BookingDate = @selectedDate";
                        cmd.Parameters.AddWithValue("@selectedDate", selectedDate);
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // กำหนดค่า parameter
                        command.Parameters.AddWithValue("@year", year);
                        if (!string.IsNullOrEmpty(month))
                        {
                            command.Parameters.AddWithValue("@month", month);
                        }
                        if (!string.IsNullOrEmpty(day))
                        {
                            DateTime selectedDate = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
                            command.Parameters.AddWithValue("@selectedDate", selectedDate);
                        }

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // สร้าง DataTable เพื่อเก็บข้อมูลที่ดึงมา
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            // ตรวจสอบว่ามีข้อมูลหรือไม่
                            if (dataTable.Rows.Count == 0)
                            {
                                dataGridView1.DataSource = null;
                                label1.Text = "ไม่พบข้อมูลการขาย";
                                return;
                            }

                            // ตั้งค่า DataGridView ให้แสดงข้อมูลจาก DataTable
                            dataGridView1.DataSource = dataTable;

                            // รวมค่าในคอลัมน์ totalprice
                            decimal total = 0;
                            foreach (DataRow row in dataTable.Rows)
                            {
                                total += Convert.ToDecimal(row["Price"]);
                            }

                            // แสดงผลรวมใน Label1
                            label1.Text = "Total Price\n " + total.ToString("N2");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // แสดงข้อความ error หากมีปัญหาในการเชื่อมต่อ
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide(); // ซ่อนหน้า Form ปัจจุบัน
        }
    }
}
