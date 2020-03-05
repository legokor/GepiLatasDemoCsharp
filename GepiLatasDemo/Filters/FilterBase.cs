using GepiLatasDemo.Pipes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GepiLatasDemo.Filters
{
    public abstract class FilterBase : Component
    {
        public abstract List<PipeType> getInputTypes();
        public abstract List<PipeType> getOutputTypes();
    }
}
