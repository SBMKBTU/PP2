using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animaciya___graphics_dvizhenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int d = 10; 
        int d1 = 5;
        int d2 = 10; int dd = 10;
        bool znak = true;
        bool znak1 = true;
        bool znak2 = true;
        bool znak3 = true;
        int index = 0;

        Pen pen = new Pen(Color.Blue, 3);
        Pen pen1 = new Pen(Color.Green, 3);
        Pen pen2 = new Pen(Color.Yellow, 3);
        Pen pen3 = new Pen(Color.Gold, 5);

        Color[] colors = new Color[] { Color.Green, Color.Red, Color.Yellow, Color.Blue , Color.Gray , Color.HotPink ,
        Color.MediumAquamarine };   //цвета в массиве

        Point[] points5 = new Point[]   //координаты треугльника
        {
            new Point(520 , 350),
             new Point(495 ,385),
             new Point(545, 385)
         };
        Point[] points4 = new Point[]   //координаты треугольника
        {
            new Point(520, 400),
             new Point(495 ,365),
             new Point(545, 365)
         };


        PointF[] points1 = new PointF[]   //пойнты точнее координаты многоугольника
        {
            new PointF(400 , 250),
            new PointF(375 , 275),
            new PointF(375 , 300),
            new PointF(400 , 325),
            new PointF(425 , 300),
            new PointF(425 , 275)
        };

        private void button1_Click(object sender, EventArgs e) //запускает таймер элипса
        {
            if (znak == true)
            {
                timer1.Start();
                znak = false;
            }
            else
            {
                timer1.Stop();
                znak = true;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e) //таймер элипса
        {
            d += 5;
            
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {                                                              //элипс и фулл элипс
            e.Graphics.DrawEllipse(new Pen(Color.Red, 2), new Rectangle(50 - d, 50 - d, 50 + 2 * d, 50 + 2 * d));
            e.Graphics.FillEllipse(pen.Brush , new Rectangle(250 - d1, 50 - d1, 50 + 3 * d1, 50 + 3 * d1)); 
           
            e.Graphics.FillRectangle(pen1.Brush,50 + d2, 250 , 50 + 3 , 50 + 3 );  //квадрат фулл

            e.Graphics.FillPolygon(pen2.Brush, points4);  //звезда с помощью двух треугольников
            e.Graphics.FillPolygon(pen2.Brush, points5);

            e.Graphics.DrawPolygon(pen3, points1);  //многоугольник 


        }

        private void button2_Click(object sender, EventArgs e)  //запускает таймер фулл элипса
        {
            if (znak1 == true)
            {
                timer2.Start();
                znak1 = false;
            }
            else
            {
                timer2.Stop();
                znak1 = true;
            }

            
        }

        private void timer2_Tick(object sender, EventArgs e) //таймер фулл элипса
        {
            d1 += 5;
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)  //запускает таймер квадрата
        {
            if (znak2 == true)
            {
                timer3.Start();
                znak2 = false;
            }
            else
            {
                timer3.Stop();
                znak2 = true;
            }
            
        }

        private void timer3_Tick(object sender, EventArgs e) //таймер квадрата
        {
            dd += 5;
            if (dd > 70)
            {
                d2 -= 10;
            }
            if (dd == 140)
            {
                dd *= 0;
            }
            if (dd==0 || dd !=0 || dd<70 )
            {
                d2 += 5;
                
            }   
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e)  //запускает звезду точнее его таймер
        {
            if (znak3 == true)
            {
                timer4.Start();
                znak3 = false;
            }
            else if (znak3==false)
            {
                timer4.Stop();
                znak3 = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)  //таймер звезды
        {
            index = (index + 1) % colors.Length;   //Берет цвета из массива и перекрашивает нашу звезду
            pen2.Color = colors[index];
           // pen2.Color = Color.FromArgb(new Random().Next());   //рандом по всем существующим цветам закрашивает
            Refresh();
        }
       
    }
}
