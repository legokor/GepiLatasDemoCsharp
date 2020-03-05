using System;
using System.Collections.Generic;
using System.Text;

namespace GepiLatasDemo.Pipes
{
    public interface Component
    {
        public List<PipeType> getInputTypes();
        public List<PipeType> getOutputTypes();
    }
}
