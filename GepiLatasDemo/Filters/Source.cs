using GepiLatasDemo.Pipes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GepiLatasDemo.Filters
{
    class Source : FilterBase
    {
        public override List<PipeType> getInputTypes() { return new List<PipeType> { PipeType.NOIO }; }
        public override List<PipeType> getOutputTypes() { return new List<PipeType> { PipeType.Image3Channel }; }
    }
}
