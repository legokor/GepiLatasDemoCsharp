using GepiLatasDemo.PipeFilter;
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
        private ControlFactory controlFactory;
        private string fileName = "Resources/rubik.jpg";
        Mat thresholdImage = null;
        TrackBar trackBar = null;
        Button LoadButton = null;
        Button GrayButton = null;
        Button CannyButton = null;
        PipeFilterController pipeFilterController;

        public Form1()
        {
            InitializeComponent();
            InitializeControls();

            pipeFilterController = new PipeFilterController(pictureBox1);
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            if(thresholdImage == null)
                thresholdImage = Cv2.ImRead(fileName);
            Mat dst = new Mat();
            Mat gray = new Mat();
            Cv2.CvtColor(thresholdImage, gray, ColorConversionCodes.BGRA2GRAY);
            Cv2.Threshold(gray, dst, trackBar.Value, 255, ThresholdTypes.Binary);
            pictureBox1.Image = dst.ToBitmap();
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
        private void InitializeControls()
        {
            controlFactory = new ControlFactory(this);

            controlFactory.AddButton("Load", (s, e) =>
            {
                pipeFilterController.Add(new FileLoader());
            });

            /*
            LoadButton = controlFactory.AddButton("Load");
            GrayButton = controlFactory.AddButton("Gray");
            CannyButton = controlFactory.AddButton("Canny");
            LoadButton.Click += load_Click;
            GrayButton.Click += grayButton_Click;
            CannyButton.Click += canny_Click;

            trackBar = controlFactory.AddTrackBar();
            trackBar.ValueChanged += TrackBar_ValueChanged;
            trackBar.Maximum = 255;
            */
        }
    }
}
