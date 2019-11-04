using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GepiLatasDemo
{
    public partial class Form1 : Form
    {
        private string fileName = "Resources/rubik.jpg";
        public Form1()
        {
            InitializeComponent();
        }
        private void load_Click(object sender, EventArgs e)
        {
            Mat src = Cv2.ImRead(fileName);

            pictureBox1.Image = src.ToBitmap();
        }
        private void grayButton_Click(object sender, EventArgs e)
        {
            Mat src = Cv2.ImRead(fileName);
            Mat dst = new Mat();
            Cv2.CvtColor(src, dst, ColorConversionCodes.BGRA2GRAY);
            pictureBox1.Image = dst.ToBitmap();
        }

        private void canny_Click(object sender, EventArgs e)
        {
            Mat src = Cv2.ImRead(fileName);
            Mat gray = new Mat();
            Cv2.CvtColor(src, gray, ColorConversionCodes.BGRA2GRAY);
            Mat dst = new Mat();
            Cv2.Canny(gray, dst, 50, 200);
            pictureBox1.Image = dst.ToBitmap();
        }
        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            this.Width = pictureBox1.Location.X + pictureBox1.Width + 80;
            this.Height = pictureBox1.Location.Y + pictureBox1.Height + 100;
        }
    }
}
