using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threads_factarial_summa_vseh
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
                Thread thread1 = new Thread(delegate() { mythread1(n); });
                Thread thread2 = new Thread(delegate() { mythread2(n); });


                thread1.Start();
                thread2.Start();
         }
         public static void mythread1(int n)
          {
                int j = 1;
                
                for (int i = 1; i <= n; i++)
                {
                    j = j * i;
                }
                Console.WriteLine("Поток для подсчета факториала числа равен " + j);
          }
            static void mythread2(int n)
            {
                int j = 0;
                
                for (int i = 0; i <= n; i++)
                {
                    j = j + i;
                }
                Console.WriteLine("Поток для подсчета суммы чисел равен " + j);
            }
     }
 }


