using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace svetovor
{
        class MyThread
        {
            Thread thread;
            public MyThread()
            {
                thread = new Thread(Jam);

            }
            public void startThread()
            {
                thread.Start();
            }
            public void Jam()
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Thread.Sleep(1000);
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                string path = @"C:\Users\Багдан\Desktop\ddd\sbm.txt";
                MyThread t1 = new MyThread();
                t1.startThread();
                while (true) using (FileStream fs = File.OpenRead(path))
                    {
                        byte[] array = new byte[fs.Length];
                        fs.Read(array, 0, array.Length);
                        string s = System.Text.Encoding.Default.GetString(array);
                        Console.WriteLine(s);
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
            }
        }

 }
