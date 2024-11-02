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
    public partial class Form15 : Form
    {
        public Form15(string imagePath)
        {
            InitializeComponent();
            ShowImage(imagePath);
        }

        private void ShowImage(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    Image img = Image.FromFile(path);
                    pictureBox1.Image = img; // ใช้ PictureBox ที่สร้างใน Form15
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }
    }
}
