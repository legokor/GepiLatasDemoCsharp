using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace GepiLatasDemo.PipeFilter
{
    public abstract class PipeFilterBase
    {
        public PipeFilterBase()
        {
            InTypes = GetInPypeTypes();
            OutType = GetOutPypeType();
        }

        private PipeFilterBase _next;

        public PipeFilterBase Next { 
            get 
            { 
                return _next; 
            } 
            set
            {
                _next = value;
            }
        }

        public List<PipeType> InTypes { get; private set; }
        public PipeType OutType { get; private set; }

        protected ImageObject Image { get; set; }

        protected abstract List<PipeType> GetInPypeTypes();
        protected abstract PipeType GetOutPypeType();

        protected abstract ImageObject ProcessImage();
        public void PushImage(ImageObject image) 
        {
            Image = image;
            ImageObject img = ProcessImage();
            Next?.PushImage(img);
        }
    }
}
