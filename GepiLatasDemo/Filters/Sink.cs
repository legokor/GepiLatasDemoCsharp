using GepiLatasDemo.Pipes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GepiLatasDemo.Filters
{
    public class Sink : FilterBase
    {
        public override List<PipeType> getInputTypes() { return new List<PipeType> { PipeType.Image1Channel, PipeType.Image3Channel, PipeType.Image4Channel }; }
        public override List<PipeType> getOutputTypes() { return new List<PipeType> { PipeType.NOIO }; }
    }
}
