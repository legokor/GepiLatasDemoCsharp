using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace GepiLatasDemo.PipeFilter
{
    class FileLoader : PipeFilterBase
    {
        protected override ImageObject ProcessImage()
        {
            string fileName = "Resources/rubik.jpg";
            return new ImageObject()
            {
                Type = PipeType.Image3Channel,
                Image = Cv2.ImRead(fileName)
            };
        }

        protected override List<PipeType> GetInPypeTypes()
        {
            return new List<PipeType>{ PipeType.NOIO };
        }

        protected override PipeType GetOutPypeType()
        {
            return PipeType.Image3Channel;
        }
    }
}
