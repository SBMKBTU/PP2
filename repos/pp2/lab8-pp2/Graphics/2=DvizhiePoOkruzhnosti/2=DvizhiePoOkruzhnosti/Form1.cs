using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_DvizhiePoOkruzhnosti
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        double a, x, y;
        private void Form1_Load(object sender, EventArgs e)
        {
            a = 0;
            x = y = 100;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(new SolidBrush(Color.Black), (int)x, (int)y, 20, 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = x + 5 * Math.Cos(a);
            y = y + 5 * Math.Sin(a);
            a = a + 0.1;
            Refresh();
        
         }
    }
}
