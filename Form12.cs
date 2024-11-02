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

    public partial class Form12 : Form
    {
        private MySqlConnection conn;
        private string selectedCourt;
        private DateTime selectedDate;
        private TimeSpan startTimeSelected;
        private TimeSpan endTimeSelected;
        private int userId; // ตัวแปรสำหรับเก็บ UserID
        private string userEmail;
        private string userfname;
        private string userlname;
        public Form12(string court, DateTime date,int userId, string userEmail, string userfname, string userlname) 
        {
            InitializeComponent();
            LoadTimeSlots();
            selectedCourt = court;
            selectedDate = date;
            this.userId = userId; // เก็บ userId
            this.userEmail = userEmail;
            this.userfname = userfname;
            this.userlname = userlname;
            string connStr = "datasource=127.0.0.1;port=3306;user=root;password=;database=badmintonpro;";
            conn = new MySqlConnection(connStr);
            LoadTimeSlots(); // เรียกเมท็อดโหลดเวลาที่สร้างไว้

        }
        private void LoadTimeSlots()
        {
            // กำหนดเวลาเริ่มต้นและสิ้นสุด
            TimeSpan startTime = new TimeSpan(09, 0, 0); // 09:00
            TimeSpan endTime = new TimeSpan(23, 0, 0);   // 23:00

            // ล้างคอลัมน์เดิมก่อน
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // เพิ่มหัวข้อคอลัมน์
            dataGridView1.Columns.Add("Time", "Time");
            dataGridView1.Columns.Add("Status", "Status");

            // เช็คสถานะการจองในช่วงเวลา
            List<(TimeSpan start, TimeSpan end)> bookedSlots = GetBookedTimeSlots();

            // วนลูปเพื่อเพิ่มช่วงเวลาและสถานะเข้าไปใน DataGridView
            while (startTime < endTime)
            {
                TimeSpan timeSlotEnd = startTime.Add(new TimeSpan(1, 0, 0));
                string timeSlot = startTime.ToString(@"hh\:mm") + " - " + timeSlotEnd.ToString(@"hh\:mm");

                // เช็คสถานะจอง
                string status = bookedSlots.Any(slot => (slot.start < timeSlotEnd && slot.end > startTime)) ? "Booked" : "Available";
                // เพิ่มแถวใน DataGridView
                int rowIndex = dataGridView1.Rows.Add(timeSlot, status);

                // เปลี่ยนสีเซลล์ตามสถานะ
                if (status == "Booked")
                {
                    dataGridView1.Rows[rowIndex].Cells["Status"].Style.BackColor = Color.Red; // เปลี่ยนสีเซลล์เป็นสีแดง
                }

                // เพิ่มเวลาขึ้นไป 1 ชั่วโมง
                startTime = startTime.Add(new TimeSpan(1, 0, 0));
            }
        }

        private List<(TimeSpan start, TimeSpan end)> GetBookedTimeSlots()
        {
            List<(TimeSpan start, TimeSpan end)> bookedSlots = new List<(TimeSpan start, TimeSpan end)>();

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=badmintonpro;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT StartTime, EndTime FROM bookings WHERE BookingDate = @date AND CourtID = 2";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@date", selectedDate.Date);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bookedSlots.Add((reader.GetTimeSpan(0), reader.GetTimeSpan(1)));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading booked time slots: {ex.Message}");
                }
            }

            return bookedSlots;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(userId, userEmail, userfname, userlname);
            form3.Show();
            this.Hide(); // ซ่อนหน้า Form ปัจจุบัน
        }

        private void Confirmbut_Click(object sender, EventArgs e)
        {
            // ตรวจสอบว่าเลือกเวลาทั้ง startTime และ endTime แล้ว
            if (comboBoxStartTime.SelectedItem != null && comboBoxEndTime.SelectedItem != null)
            {
                TimeSpan startTime = TimeSpan.Parse(comboBoxStartTime.SelectedItem.ToString());
                TimeSpan endTime = TimeSpan.Parse(comboBoxEndTime.SelectedItem.ToString());

                // เช็คสถานะการจองในช่วงเวลาที่เลือก
                List<(TimeSpan start, TimeSpan end)> bookedSlots = GetBookedTimeSlots();
                bool isBooked = bookedSlots.Any(slot => (slot.start < endTime && slot.end > startTime));

                if (isBooked)
                {
                    MessageBox.Show("ช่วงเวลาที่เลือกไม่สามารถจองได้ เพราะมีการจองอยู่แล้ว", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // คำนวณราคาตามเวลาที่เลือก
                int totalHours = (int)(endTime - startTime).TotalHours;
                int totalPrice = totalHours * 150; // ตัวอย่างการคำนวณราคา

                // สร้าง FormPay พร้อมส่งพารามิเตอร์ทั้งหมด
                Pay pay = new Pay(selectedCourt, selectedDate, startTime, endTime, totalPrice, userId, userEmail, userfname, userlname);
                pay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ไม่สามารถเลือกเวลาสิ้นสุดก่อนเวลาเริ่มได้", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ดึงเวลาเริ่มต้นที่ผู้ใช้เลือกจาก ComboBox
            startTimeSelected = TimeSpan.Parse(comboBoxStartTime.SelectedItem.ToString());

            // ปรับเวลาใน comboBoxEndTime เพื่อไม่ให้เลือกก่อน start time
            comboBoxEndTime.Items.Clear();
            TimeSpan tempEndTime = startTimeSelected.Add(new TimeSpan(1, 0, 0)); // เริ่มจาก 1 ชั่วโมงหลัง start time
            TimeSpan endTimeLimit = new TimeSpan(23, 0, 0); // สมมติว่าเวลาสิ้นสุดสูงสุดคือ 23:00

            while (tempEndTime <= endTimeLimit)
            {
                comboBoxEndTime.Items.Add(tempEndTime.ToString(@"hh\:mm"));
                tempEndTime = tempEndTime.Add(new TimeSpan(1, 0, 0));
            }
        }

        private void comboBoxEndTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ดึงเวลาสิ้นสุดที่ผู้ใช้เลือกจาก ComboBox
            endTimeSelected = TimeSpan.Parse(comboBoxEndTime.SelectedItem.ToString());
        }
        public void LoadData()
        {
            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=badmintonpro;";
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM booking"; // ปรับ query ตามที่ต้องการ
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable; // ปรับให้ตรงกับ DataGridView ของคุณ
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }


        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
