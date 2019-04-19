using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Windows.Forms.Timer;

namespace Calc
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
             
            InitializeComponent();

             timer = new Timer();
            
            timer.Tick += new EventHandler(timer2_Tick);
            timer.Interval = 1000;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }
        Timer timer = null;
        public double a;
        public double b;
        public string c;
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
                textBox1.Text = textBox1.Text.Replace("(", "");
                textBox1.Text = textBox1.Text.Replace(")", "");

                a = Convert.ToDouble(textBox1.Text);
                c = "+";
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
                textBox1.Text = textBox1.Text.Replace("(", "");
                textBox1.Text = textBox1.Text.Replace(")", "");
                a = Convert.ToDouble(textBox1.Text);
                c = "-";
                textBox1.Text = "";
            }
            catch (Exception)
            {
              MessageBox.Show("ОшибкаВвода");
            }
        }

        private void button16_Click(object sender, EventArgs e) //    *
        {
            try
            {
                textBox1.Text = textBox1.Text.Replace("(", "");
                textBox1.Text = textBox1.Text.Replace(")", "");
                a = Convert.ToDouble(textBox1.Text);
                c = "*";
                textBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
        }

        private void button19_Click(object sender, EventArgs e) //     /
        {
            try
            {
                textBox1.Text = textBox1.Text.Replace("(", "");
                textBox1.Text = textBox1.Text.Replace(")", "");
                a = Convert.ToDouble(textBox1.Text);
                c = "/";
                textBox1.Text = "";
            }
            catch (Exception)
            {
               MessageBox.Show("ОшибкаВвода");
            }
        }

        private void button17_Click(object sender, EventArgs e)  //     =
        {
            try
            {
                timer1.Start();
                textBox1.Text = textBox1.Text.Replace("(", "");
                textBox1.Text = textBox1.Text.Replace(")", "");

                
                

                b = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";

               
                    
                    switch (c)
                    {
                        case "+":

                            textBox2.Text = Convert.ToString(a + "+" + b + "=");
                            textBox1.Text = Convert.ToString(a + b);
                            break;
                        case "-":

                            textBox2.Text = Convert.ToString(a + "-" + b + "=");
                            textBox1.Text = Convert.ToString(a - b);
                            break;
                        case "*":

                            textBox2.Text = Convert.ToString(a + "*" + b + "=");
                            textBox1.Text = Convert.ToString(a * b);
                            break;
                        case "/":

                            textBox2.Text = Convert.ToString(a + "/" + b + "=");
                            textBox1.Text = Convert.ToString(a / b);
                            break;
                        case "^":

                            textBox2.Text = Convert.ToString(a + "^" + b + "=");
                            textBox1.Text = Convert.ToString(Math.Pow(a, b));
                            break;
                        case "√":

                            textBox2.Text = Convert.ToString(b + "^" + "√" + a + "=");
                            textBox1.Text = Convert.ToString(Math.Pow(a, 1.0 / b));
                            break;
                        case "%":

                            textBox2.Text = Convert.ToString("Число " + a + "вот столько % от числа " + b + "=");
                            textBox1.Text = Convert.ToString(((a / b) * 100) + "%");
                            break;
                        case "logA(x)":

                            textBox2.Text = Convert.ToString("Log" + b + "(" + a + ")");
                            textBox1.Text = Convert.ToString((Math.Log10(a)) / (Math.Log10(b)));
                            break;
                        
                    }
                    progressBar1.Value = progressBar1.Minimum;

                    
                
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
        }

        private void button20_Click(object sender, EventArgs e) // , 
        {
            if (textBox1.Text == "")
            {
                textBox1.Text += "0" + ",";
            }
             else if (textBox1.Text.IndexOf(",") == -1)
                {
                    textBox1.Text += ",";
                }
            
        }

        private void button21_Click(object sender, EventArgs e) //x^2
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            timer1.Start();
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = Convert.ToString(a + "^2=");
                textBox1.Text = Convert.ToString(Math.Pow(a, 2));
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
            
        }

        private void button27_Click(object sender, EventArgs e) //x^y
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                c = "^";
                textBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
                  
        }

        private void button26_Click(object sender, EventArgs e) //Sqrt
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = Convert.ToString("Sqrt(" + a + ")=");
                textBox1.Text = Convert.ToString(Math.Sqrt(a));
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
           
        }

        private void button22_Click(object sender, EventArgs e) //sin
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sin((a * Math.PI) / 180));
                textBox2.Text = Convert.ToString("sin " + a+"=");
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
        }

        private void button24_Click(object sender, EventArgs e) //cos
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");

            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Cos((a * Math.PI) / 180));
                textBox2.Text = Convert.ToString("cos" + a + "=");
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
        }

        private void button23_Click(object sender, EventArgs e) //tan
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Tan((a * Math.PI) / 180));
                textBox2.Text = Convert.ToString("tan " + a + "=");
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }

        }

        private void button25_Click(object sender, EventArgs e) //ctan
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString((Math.Cos((a * Math.PI) / 180)) / (Math.Sin((a * Math.PI) / 180)));
                textBox2.Text = Convert.ToString("ctan " + a + "=");
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
        }

        private void button13_Click(object sender, EventArgs e)  // C
        {
            timer.Stop();
            textBox1.Text = "";
            textBox2.Text = "";
            a = 0;
            b = 0;
            
            znak = true;
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

        private void button28_Click(object sender, EventArgs e)  //log(x)
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            timer1.Start();
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Log10(a));
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
           
        }

        private void button29_Click(object sender, EventArgs e) //ln(x)
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            timer1.Start();
            try
            {
                a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Log(a));
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
        }

        private void button30_Click(object sender, EventArgs e) //а в корне n-ой степени
        {
            
            try
            {
                a = Convert.ToDouble(textBox1.Text);
            c = "√";
            textBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
        }

        private void button31_Click(object sender, EventArgs e) //%
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                c = "%";
                textBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
           
        }

        private void button32_Click(object sender, EventArgs e)  // 1/n
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            timer1.Start();
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(1 / a);
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
            

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

        private void button34_Click(object sender, EventArgs e)//time
        {

            
            timer.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)//time
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;

            int D = DateTime.Now.Day;
            int M = DateTime.Now.Month;
            int Y = DateTime.Now.Year;

            string time = "";
            string time1 = "";


            if (h < 10)
            {
                time += "0" + h;
            }
            else
            {
                time += h;
            }

            time += ":";

            if (m < 10)
            {
                time += "0" + m;
            }
            else
            {
                time += m;
            }

            time += ":";

            if (s < 10)
            {
                time += "0" + s;
            }
            else
            {
                time += s;
            }



            if (D < 10)
            {
                time1 += "0" + D;
            }
            else
            {
                time1 += D;
            }
            time1 += ".";
            if (M < 10)
            {
                time1 += "0" + M;
            }
            else
            {
                time1 += M;
            }
            time1 += ".";
            time1 += Y;



            textBox1.Text = time;
            textBox2.Text = time1;
      
        }

        private void button35_Click(object sender, EventArgs e)//n!
        {
            try
            {
                textBox1.Text = textBox1.Text.Replace("(", "");
                textBox1.Text = textBox1.Text.Replace(")", "");
                timer1.Start();
                double s = 1;
                a = Convert.ToDouble(textBox1.Text);
                for (int i = 1; i <= a; i++)
                {
                    s = s * i;
                }
                textBox1.Text = Convert.ToString(s);
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
           


        }

        private void button36_Click(object sender, EventArgs e)// ()
        {
            if (znak == true)
            {
                textBox1.Text = "(" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text + ")";
                znak = true;
            }
        }

        private void button38_Click(object sender, EventArgs e) //pi
        {
            textBox1.Text = "3,1415926535";
        }

        private void button37_Click(object sender, EventArgs e)//10^x
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            timer1.Start();
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
                textBox2.Text = Convert.ToString("10^0");
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Pow(10 , a));
                textBox2.Text = Convert.ToString("10^" + a);

            }
        }

        private void button39_Click(object sender, EventArgs e) //LogA(x)
        {
            timer1.Start();
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                c = "logA(x)";
                textBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }
           
        }

        private void button40_Click(object sender, EventArgs e) //e
        {
            textBox1.Text = "2,7182818285";
        }

        private void button41_Click(object sender, EventArgs e) //e^x
        {
            textBox1.Text = textBox1.Text.Replace("(", "");
            textBox1.Text = textBox1.Text.Replace(")", "");
            try
            {
                
                a = Convert.ToDouble(textBox1.Text);
                
                b = 2.7182818285;

                textBox1.Text = "";
                
                        
                textBox2.Text = Convert.ToString("e^" + a);
                textBox1.Text = Convert.ToString(Math.Pow( b, a));
              
            }
            catch (Exception)
            {
                MessageBox.Show("ОшибкаВвода");
            }


        }
    }
}
