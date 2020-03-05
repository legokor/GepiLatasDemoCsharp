using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GepiLatasDemo.PipeFilter
{
    public class ImageDrawer : PipeFilterBase
    {
        PictureBox pictureBox;

        public ImageDrawer(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        protected override ImageObject ProcessImage()
        {
            pictureBox.Image = Image.Image.ToBitmap();
            return new ImageObject();
        }

        protected override List<PipeType> GetInPypeTypes()
        {
            return new List<PipeType> { PipeType.Image3Channel };
        }

        protected override PipeType GetOutPypeType()
        {
            return PipeType.NOIO;
        }
    }
}
