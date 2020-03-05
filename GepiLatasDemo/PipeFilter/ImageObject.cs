using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace GepiLatasDemo.PipeFilter
{
    public class ImageObject
    {
        public PipeType Type { get; set; } = PipeType.NOIO;
        public Mat Image { get; set; }
    }
}
