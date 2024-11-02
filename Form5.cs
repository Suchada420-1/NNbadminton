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
    public partial class Form5 : Form
    {
        private MySqlConnection conn;
        private DataGridViewRow selectedRow;

        public Form5()
        {
            InitializeComponent();

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=badmintonpro;";
            conn = new MySqlConnection(connectionString);
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM bookings";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // ตั้งค่า DataGridView ให้แสดงข้อมูล
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        private void DeleteBooking(string bookingID)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM bookings WHERE BookingID = @bookingID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@bookingID", bookingID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("การจองถูกลบแล้ว");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting booking: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }


        private void edit_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide(); // ซ่อนหน้า Form ปัจจุบัน
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่ามีการเลือกแถวใน DataGridView หรือไม่
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // ดึงข้อมูลแถวที่เลือก
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string bookingID = selectedRow.Cells["BookingID"].Value.ToString(); // สมมติว่ามีคอลัมน์ BookingID ในตาราง

                // ยืนยันการลบ
                DialogResult dialogResult = MessageBox.Show("คุณต้องการลบการจองนี้หรือไม่?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // เรียกฟังก์ชันลบการจอง
                    DeleteBooking(bookingID);

                    // โหลดข้อมูลใหม่หลังจากลบ
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกการจองที่ต้องการลบ");
            }
        }

        private void ssl_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide(); // ซ่อนหน้า Form ปัจจุบัน
        }

        private void backbut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // ซ่อนหน้า Form ปัจจุบัน
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ninew_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide(); // ซ่อนหน้า Form ปัจจุบัน
        }

        private void TextBoxsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void butsearch_Click(object sender, EventArgs e)
        {
            string searchTerm = TextBoxsearch.Text.Trim(); // รับข้อความจาก TextBoxsearch
            if (!string.IsNullOrEmpty(searchTerm))
            {
                LoadData(searchTerm); // เรียกใช้ฟังก์ชัน LoadData พร้อมกับคำค้นหา
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อความเพื่อค้นหา");
            }
        }
        private void LoadData(string searchTerm = "")
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM bookings";
                if (!string.IsNullOrEmpty(searchTerm))
                    {
                        // ค้นหาจากทุกคอลัมน์ที่ต้องการ
                        query += " WHERE BookingID LIKE @searchTerm " +
                             "OR UserID LIKE @searchTerm " +
                             "OR CourtID LIKE @searchTerm " +
                             "OR BookingDate LIKE @searchTerm " +
                             "OR StartTime LIKE @searchTerm " +
                             "OR EndTime LIKE @searchTerm " +
                             "OR Status LIKE @searchTerm " +
                             "OR Price LIKE @searchTerm " +
                             "OR userfname LIKE @searchTerm " +  // ค้นหาจาก userfname
                             "OR userlname LIKE @searchTerm";    // ค้นหาจาก userlname
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // ตั้งค่า DataGridView ให้แสดงข้อมูล
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
