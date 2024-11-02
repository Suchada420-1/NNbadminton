using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using QRCoder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using iTextSharp.text.pdf.draw;

namespace Projectfinal
{
    public partial class Pay : Form
    {
        private string selectedCourt;
        private DateTime selectedDate;
        private TimeSpan startTime;
        private TimeSpan endTime;
        private int totalPrice;
        private MySqlConnection conn;
        private string imageFilePath;
        private int userId; // ตัวแปรสำหรับเก็บ UserID
        private string userEmail;
        private string userfname;
        private string userlname;



        public Pay(string court, DateTime date, TimeSpan start, TimeSpan end, int price, int userId, string userEmail,string userfname,string userlname)
        {
            InitializeComponent();
            selectedCourt = court;
            selectedDate = date;
            startTime = start;
            endTime = end;
            totalPrice = price;
            this.userId = userId; // เก็บ UserID ที่ส่งมา
            this.userEmail = userEmail;
            this.userfname = userfname;
            this.userlname = userlname;


            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=badmintonpro;";
            conn = new MySqlConnection(connectionString);
        }
       
        private async Task GenerateReceiptPDF()
        {
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string receiptFolder = Path.Combine(documentsFolder, "Receipt");
            if (!Directory.Exists(receiptFolder))
            {
                Directory.CreateDirectory(receiptFolder);
            }

            // สร้าง file path สำหรับ PDF
            string filePath = Path.Combine(receiptFolder, $"Receipt_{DateTime.Now:yyyyMMddHHmmss}.pdf");

            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    Document doc = new Document(PageSize.B5, 25, 25, 20, 20);
                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                    doc.Open();

                    // ตั้งค่า Font
                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                    var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
                    var cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

                    // เพิ่มหัวข้อ
                    Paragraph title = new Paragraph("NNBadminton\nCourt", titleFont)
                    {
                        Alignment = Element.ALIGN_CENTER
                    };
                    doc.Add(title);
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("Ban kok, Khon Kaen, Thailand, Khon Kaen 40000\n", headerFont) { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new Paragraph("tel 0973190292 (New)\n", headerFont) { Alignment = Element.ALIGN_CENTER });
                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("         -----------------------------------------------------------------------------------------------"));
                    doc.Add(new Paragraph("\n"));
                    // ข้อมูลในใบเสร็จ
                    PdfPTable table = new PdfPTable(2);
                    table.WidthPercentage = 100;

                    // คำนวณราคาหลังหัก VAT
                    double vatRate = 0.07; // 7% VAT
                    double totalPriceWithVAT = this.totalPrice; // รวม VAT
                    double totalPriceExcludingVAT = totalPriceWithVAT / (1 + vatRate); // คำนวณราคาหลังหัก VAT
                    double vatAmount = totalPriceWithVAT - totalPriceExcludingVAT; // คำนวณ VAT

                    // เพิ่มข้อมูล
                    AddRow(table, "Name ", $"{this.userfname} {this.userlname}", cellFont);
                    AddRow(table, "Court ", selectedCourt, cellFont);
                    AddRow(table, "Booking Date ", selectedDate.ToString("dd/MM/yyyy"), cellFont);
                    AddRow(table, "Start Time ", this.startTime.ToString(@"hh\:mm"), cellFont);
                    AddRow(table, "End Time ", this.endTime.ToString(@"hh\:mm"), cellFont);
                    AddRow(table, "Total Price (Excl. VAT)", $"{totalPriceExcludingVAT:F2} THB", cellFont); // ราคาหลังหัก VAT
                    AddRow(table, "VAT (7%) ", $"{vatAmount:F2} THB", cellFont); // แสดง VAT
                    AddRow(table, "Total Price (Incl. VAT)", $"{totalPriceWithVAT:F2} THB", cellFont); // ราคาที่รวม VAT
                    // ตั้งค่าการจัดตำแหน่งของตารางให้อยู่ตรงกลาง
                    table.HorizontalAlignment = Element.ALIGN_CENTER;

                    // เพิ่มตารางลงในเอกสาร
                    doc.Add(table);

                    doc.Add(new Paragraph("\n"));
                    doc.Add(new Paragraph("         -----------------------------------------------------------------------------------------------"));
                    doc.Add(new Paragraph("\n"));                    

                    // ปิดเอกสาร PDF
                    doc.Close();
                    await SendEmailWithPDFAsync(filePath);
                    MessageBox.Show("PDF created and saved at: " + filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการสร้าง PDF: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRow(PdfPTable table, string label, string value, iTextSharp.text.Font font)
        {
            // สร้างเซลล์สำหรับ label
            PdfPCell labelCell = new PdfPCell(new Phrase(label, font))
            {
                BorderWidth = 0,
                HorizontalAlignment = Element.ALIGN_CENTER, // จัดตำแหน่งข้อความกลางในเซลล์
                Padding = 10 // เพิ่ม padding
            };

            // สร้างเซลล์สำหรับ value
            PdfPCell valueCell = new PdfPCell(new Phrase(value, font))
            {
                BorderWidth = 0,
                HorizontalAlignment = Element.ALIGN_CENTER, // จัดตำแหน่งข้อความกลางในเซลล์
                Padding = 10 // เพิ่ม padding
            };

            // เพิ่มเซลล์ไปยังตาราง
            table.AddCell(labelCell);
            table.AddCell(valueCell);
        }

        private async Task SendEmailWithPDFAsync(string filePath)
        {
            try
            {
                string fromMail = "Suchada.sris@kkumail.com";
                string fromPassword = "qsud mtdq jkov zzra"; // Consider storing passwords more securely

                // Retrieve email from TextBox
                string email = userEmail;

                // สร้างอีเมลข้อความ
                MailMessage message = new MailMessage
                {
                    From = new MailAddress(fromMail),
                    Subject = "Your Receipt from NNBadminton Court",
                    Body = "ขอบคุณที่ใช้บริการ สนามแบดมินตันของเรา\n ขอให้มีความสุขในการออกกำลังกาย\n หวังว่าจะได้เจอกันอีกครั้ง Thanks :)",
                    IsBodyHtml = false
                };
                message.To.Add(new MailAddress(email));

                // แนบไฟล์ PDF ใบเสร็จ
                Attachment attachment = new Attachment(filePath);
                message.Attachments.Add(attachment);

                // ส่งอีเมลด้วย SmtpClient
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential(fromMail, fromPassword);
                    smtpClient.EnableSsl = true;

                    await smtpClient.SendMailAsync(message);
                }

                MessageBox.Show("Email sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send the receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GeneratePaymentQRCode(int totalPrice)
        {
            string imageUrl = "https://promptpay.io/0973190292/" + totalPrice.ToString("F2") + ".png";

            pictureBoxQRCode.ImageLocation = imageUrl;
            pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void Pay_Load(object sender, EventArgs e)
        {
            // ใช้ข้อมูลที่รับมาแสดงผลบนหน้าจ่ายเงิน
            labelCourt.Text = $"สนามที่ : {selectedCourt}";
            labelDate.Text = $"วันที่ : {selectedDate.ToString("dd/MM/yyyy")}";
            labelStartTime.Text = $"เริ่มเวลา : {startTime.ToString(@"hh\:mm")}";
            labelEndTime.Text = $"หมดเวลา : {endTime.ToString(@"hh\:mm")}";
            labelTotalPrice.Text = $"ราคา : {totalPrice} THB";

            // สร้าง QR Code สำหรับการจ่ายเงิน
            GeneratePaymentQRCode(totalPrice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(userId, userEmail, userfname, userlname);
            form3.Show();
            this.Hide(); // ซ่อนหน้า Form ปัจจุบัน
        }

        private void labelTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private async void confirm_but_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imageFilePath))
            {
                MessageBox.Show("กรุณาอัพโหลดสลิปการจ่ายเงิน");
                return;
            }

            try
            {
                conn.Open();
                MessageBox.Show($"Court: {selectedCourt}, Date: {selectedDate}, Start: {startTime}, End: {endTime}, Price: {totalPrice}");

                // Insert booking and payment details
                string query = "INSERT INTO Bookings (UserID,CourtID, BookingDate, StartTime, EndTime,status, price, PaymentProof,userfname,userlname) VALUES (@UserID ,@CourtID, @BookingDate, @StartTime, @EndTime,@status, @price, @PaymentProof,@userfname,@userlname)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@CourtID", selectedCourt);
                cmd.Parameters.AddWithValue("@BookingDate", selectedDate);
                cmd.Parameters.AddWithValue("@StartTime", startTime);
                cmd.Parameters.AddWithValue("@Status", "Booked");
                cmd.Parameters.AddWithValue("@EndTime", endTime);
                cmd.Parameters.AddWithValue("@price", totalPrice);
                cmd.Parameters.AddWithValue("@PaymentProof", File.ReadAllBytes(imageFilePath));
                cmd.Parameters.AddWithValue("@Userfname", userfname);
                cmd.Parameters.AddWithValue("@Userlname", userlname);
                await cmd.ExecuteNonQueryAsync(); // ใช้ ExecuteNonQueryAsync


                MessageBox.Show("การจองของท่านเสร็จสิ้น ขอบคุณที่ใช้บริการ");
                await GenerateReceiptPDF(); // เพิ่ม await
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error recording booking: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void slip_Click(object sender, EventArgs e)
        {
            // เปิด dialog เพื่อเลือกไฟล์รูปภาพ
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = openFileDialog.FileName;
                MessageBox.Show("Image selected: " + imageFilePath);

                // แสดงภาพใน PictureBox
                ShowImage(imageFilePath);
            }
        }

        // ฟังก์ชันสำหรับแสดงรูปภาพ
        private void ShowImage(string path)
        {
            // เปิด dialog เพื่อเลือกไฟล์รูปภาพ
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageFilePath = openFileDialog.FileName;
                MessageBox.Show("Image selected: " + imageFilePath);

                // เปิดฟอร์มใหม่เพื่อแสดงภาพ
                Form15 imageForm = new Form15(imageFilePath);
                imageForm.Show(); // แสดงฟอร์มภาพใหม่
            }
        }

            private void pictureBoxQRCode_Click(object sender, EventArgs e)
        {
         
        }
    }

}
