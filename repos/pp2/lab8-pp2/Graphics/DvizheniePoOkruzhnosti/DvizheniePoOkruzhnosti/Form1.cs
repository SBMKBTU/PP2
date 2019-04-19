using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DvizheniePoOkruzhnosti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int r = 100;     //радиус
        int x0 = 150;   //координата X центра окружности
        int y0 = 150;   //координата X центра окружности
        float x = 0, y = 0;
        double fi = 0.0;


        private void Form1_Load(object sender, EventArgs e)
        {
            Timer tmr = new Timer();
            tmr.Interval =10;
            tmr.Tick += tmr_Tick;
            tmr.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Red, x, y, 20, 20);
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            fi += 0.1;
            if (fi > 2 * Math.PI) fi = 0.0;
            x = (float)(r * Math.Cos(fi) + x0);
            y = (float)(r * Math.Sin(fi) + y0);
            Invalidate();
        }
    }
}
