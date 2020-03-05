using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace GepiLatasDemo
{
    public class ControlFactory
    {
        private readonly Form1 form;
        public int NextControlY { get; set; } = 60;
        private int LastControlIndex = 1;
        private int VerticalPadding = 10;
        private int XCoordinate = 25;
        private int TabIndex = 100;


        public ControlFactory(Form1 form)
        {
            this.form = form;
        }

        public TrackBar AddTrackBar()
        {
            TrackBar trackBar = new TrackBar
            {
                Name = $"trackBar{++LastControlIndex}",
                Location = new System.Drawing.Point { X = XCoordinate, Y = NextControlY },
                TabIndex = TabIndex++,
            };

            NextControlY = trackBar.Location.Y + trackBar.Height + VerticalPadding;

            form.Controls.Add(trackBar);
            return trackBar;
        }

        public Button AddButton(string text)
        {
            Button button = new Button
            {
                Name = $"button{++LastControlIndex}",
                Location = new System.Drawing.Point { X = XCoordinate, Y = NextControlY },
                TabIndex = TabIndex++,
                Text = text,
                UseVisualStyleBackColor = true,
                Size = new System.Drawing.Size(75, 30)
            };

            NextControlY = button.Location.Y + button.Height + VerticalPadding;
            form.Controls.Add(button);
            return button;
        }

        public void AddButton(string text, EventHandler onClick)
        {
            Button button = new Button
            {
                Name = $"button{++LastControlIndex}",
                Location = new System.Drawing.Point { X = XCoordinate, Y = NextControlY },
                TabIndex = TabIndex++,
                Text = text,
                UseVisualStyleBackColor = true,
                Size = new System.Drawing.Size(75, 30)
            };

            NextControlY = button.Location.Y + button.Height + VerticalPadding;
            form.Controls.Add(button);
            button.Click += onClick;
        }
    }
}
