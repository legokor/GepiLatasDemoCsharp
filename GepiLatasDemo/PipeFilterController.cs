using GepiLatasDemo.PipeFilter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GepiLatasDemo
{
    public class PipeFilterController
    {
        public PipeFilterController(PictureBox pictureBox)
        {
            _list.Add(new ImageDrawer(pictureBox));
        }

        List<PipeFilterBase> _list = new List<PipeFilterBase>();

        public void Add(PipeFilterBase pipeFilter, int position)
        {
            pipeFilter.Next = _list[position];
            _list.Insert(position, pipeFilter);
            if (position-1 < 0)
            {
                _list[0].PushImage(null);
            }
        }

        public void Add(PipeFilterBase pipeFilter)
        {
            Add(pipeFilter, _list.Count - 1);
        }

        public void Remove(PipeFilterBase pipeFilter)
        {
            _list.Remove(pipeFilter);
        }

        public List<PipeFilterBase> GetList()
        {
            return _list;
        }
    }
}
