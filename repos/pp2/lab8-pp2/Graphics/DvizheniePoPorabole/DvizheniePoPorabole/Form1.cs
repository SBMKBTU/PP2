using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DvizheniePoPorabole
{
    public partial class Form1 : Form
    {
        Func<float, float> function = (x) => -x * x;
        private float time = 0f;
        private TrackBar tb;

        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            tb = new TrackBar { Minimum = 5, Maximum = 20, Parent = this };
            Application.Idle += (o, e) => Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            var dt = tb.Value / 4000f;
            var p = VirtualToAbsolute(time, function(time));
            e.Graphics.FillEllipse(Brushes.Green, p.X - 5, p.Y - 5, 10, 10);

            var points = new List<PointF>();
            for (var t = 0f; t <= 1; t += dt)
                points.Add(VirtualToAbsolute(t, function(t)));

            e.Graphics.DrawLines(Pens.Maroon, points.ToArray());

            if (p.X > Height)
                time = 0;

            time += dt;
        }
        PointF VirtualToAbsolute(float x, float y)
        {
            return new PointF(x * Width, Height / 2 - y * Height);
        }

    }
}
