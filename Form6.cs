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
    public partial class Form6 : Form
    {
        private MySqlConnection conn;
        private DataGridViewRow selectedRow;
        public Form6()
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
                string query = "SELECT * FROM register";
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dataGridView1.Rows[e.RowIndex]; // เก็บแถวที่ถูกเลือก
                textBox2.Text = selectedRow.Cells["fname"].Value.ToString();
                textBox3.Text = selectedRow.Cells["lname"].Value.ToString();
                textBox4.Text = selectedRow.Cells["phone"].Value.ToString();
                textBox5.Text = selectedRow.Cells["email"].Value.ToString();
                textBox6.Text = selectedRow.Cells["password"].Value.ToString();
            }

        }
        private void confirm_Click(object sender, EventArgs e)
        {
            if (selectedRow == null)
            {
                MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการอัปเดต");
                return;
            }

            try
            {
                conn.Open();
                string query = "UPDATE register SET fname = @fname, lname = @lname, phone = @phone, email = @email, password = @password WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // ตรวจสอบข้อมูลที่ส่งเข้า SQL
                MessageBox.Show($"กำลังอัปเดต fname: {textBox2.Text}, lname: {textBox3.Text}, phone: {textBox4.Text}, email: {textBox5.Text}, password: {textBox6.Text}, id: {selectedRow.Cells["id"].Value}");

                cmd.Parameters.AddWithValue("@fname", textBox2.Text);
                cmd.Parameters.AddWithValue("@lname", textBox3.Text);
                cmd.Parameters.AddWithValue("@phone", textBox4.Text);
                cmd.Parameters.AddWithValue("@email", textBox5.Text);
                cmd.Parameters.AddWithValue("@password", textBox6.Text);
                cmd.Parameters.AddWithValue("@id", selectedRow.Cells["id"].Value); // ใช้ selectedRow แทน row

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("อัปเดตข้อมูลสำเร็จ");

                    LoadData(); // โหลดข้อมูลใหม่หลังการอัปเดต
                }
                else
                {
                    MessageBox.Show("การอัปเดตล้มเหลว");
                }
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

        private void Back_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide(); // ซ่อนหน้า Form ปัจจุบัน
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                // แสดงกล่องข้อความเพื่อยืนยันการลบ
                DialogResult dialogResult = MessageBox.Show("คุณต้องการลบข้อมูลนี้ ใช่ไหม?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM register WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", selectedRow.Cells["id"].Value);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("ลบข้อมูลสำเร็จ");
                            LoadData(); // โหลดข้อมูลใหม่หลังการลบ
                            ClearTextBoxes(); // ล้างข้อมูลใน TextBox
                        }
                        else
                        {
                            MessageBox.Show("การลบข้อมูลล้มเหลว");
                        }
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
                else
                {
                    MessageBox.Show("การลบข้อมูลถูกยกเลิก");
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการลบ");
            }
        }
        private void ClearTextBoxes()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            selectedRow = null; // เคลียร์ข้อมูลแถวที่เลือก
        }
    }
}
