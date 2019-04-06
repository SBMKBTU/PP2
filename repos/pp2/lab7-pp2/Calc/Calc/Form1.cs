using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double a;
        public double b;
        public char c;
        public string s;
        public bool znak = true;


       

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "00";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "000";
        }

        private void button15_Click(object sender, EventArgs e) //    +
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                c = '+';
                textBox1.Text = "";
            }
            catch(Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
        }

        private void button18_Click(object sender, EventArgs e) //    -
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                c = '-';
                textBox1.Text = "";
            }
            catch (Exception)
            {
              //  MessageBox.Show("ОшибкаВвода");
            }
        }

        private void button16_Click(object sender, EventArgs e) //    *
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                c = '*';
                textBox1.Text = "";
            }
            catch (Exception)
            {
               // MessageBox.Show("ОшибкаВвода");
            }
        }

        private void button19_Click(object sender, EventArgs e) //     /
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                c = '/';
                textBox1.Text = "";
            }
            catch (Exception)
            {
               // MessageBox.Show("ОшибкаВвода");
            }
        }

        private void button17_Click(object sender, EventArgs e)  //     =
        {

            timer1.Start();
            progressBar1.Value = 0;
            b = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            
            switch (c)
            {
                case '+':
                    textBox1.Text = Convert.ToString(a + b);
                    break;
                case '-':
                    textBox1.Text = Convert.ToString(a - b);
                    break;
                case '*':
                    textBox1.Text = Convert.ToString(a * b);
                    break;
                case '/':
                    textBox1.Text = Convert.ToString(a / b);
                    break;
                case '^':
                    textBox1.Text = Convert.ToString(Math.Pow(a, b));
                    break;
                case '√':
                    textBox1.Text = Convert.ToString(Math.Pow(a, 1.0 / b));
                    break;
                case '%':
                    textBox1.Text = Convert.ToString(((a/b)*100)+"%");
                    break;
            }
        }

        private void button20_Click(object sender, EventArgs e) // , 
        {
            if (textBox1.Text.IndexOf(",") == -1)
                textBox1.Text += ",";
        }

        private void button21_Click(object sender, EventArgs e) //x^2
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Pow(a , 2));
        }

        private void button27_Click(object sender, EventArgs e) //x^y
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '^';
            textBox1.Text = "";          
        }

        private void button26_Click(object sender, EventArgs e) //Sqrt
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Sqrt(a));
        }

        private void button22_Click(object sender, EventArgs e) //sin
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sin((a * Math.PI) / 180));
            }
            catch (Exception)
            {

            }
        }

        private void button24_Click(object sender, EventArgs e) //cos
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Cos((a * Math.PI) / 180));
            }
            catch (Exception)
            {

            }
        }

        private void button23_Click(object sender, EventArgs e) //tan
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Tan((a * Math.PI) / 180));
            }
            catch (Exception)
            {

            }

        }

        private void button25_Click(object sender, EventArgs e) //ctan
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString((Math.Cos((a * Math.PI) / 180)) / (Math.Sin((a * Math.PI) / 180)));
            }
            catch (Exception)
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)  // C
        {
            textBox1.Text = "";
            a = 0;
            b = 0;
        }

        private void button14_Click(object sender, EventArgs e)   // <-
        {
            s = textBox1.Text;
            s = s.Substring(0, s.Length - 1);
            textBox1.Text = s;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) //Файл --->  Выход
        { 
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)  //Справка ---> О программе
        {
            MessageBox.Show("Калькуля́тор (лат. calculātor «счётчик») — электронное вычислительное устройство для выполнения операций над числами или алгебраическими формулами.                                       Samat Bagdan KBTU ", " О программе ");
        }

        private void button28_Click(object sender, EventArgs e)  //ln(1-x)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Log(1 - a));
        }

        private void button29_Click(object sender, EventArgs e) //ln(x)
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Log(a));
        }

        private void button30_Click(object sender, EventArgs e) //а в корне n-ой степени
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '√';
            textBox1.Text = "";
        }

        private void button31_Click(object sender, EventArgs e) //%
        {
            a = Convert.ToDouble(textBox1.Text);
            c = '%';
            textBox1.Text = "";
        }

        private void button32_Click(object sender, EventArgs e)  // 1/n
        {
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(1 / a);

        }

        private void timer1_Tick(object sender, EventArgs e)//таймер запускает прогресс
        {
            
            progressBar1.PerformStep();
           
        }

        private void button33_Click(object sender, EventArgs e) //+-
        {
            {
                if (znak == true)
                {
                    textBox1.Text = "-" + textBox1.Text;
                    znak = false;
                }
                else if (znak == false)
                {
                    textBox1.Text = textBox1.Text.Replace("-", "");
                    znak = true;
                }
            }
        }
    }
}
