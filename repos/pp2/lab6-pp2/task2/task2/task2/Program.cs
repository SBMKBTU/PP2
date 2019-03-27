using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Thread thread1 = new Thread(mythread1);
            Thread thread2 = new Thread(mythread2);
            Thread thread3 = new Thread(mythread3);
            /*  thread1.Priority = ThreadPriority.Highest;                   //   Highest - самый высокий
              thread2.Priority = ThreadPriority.AboveNormal;                 //   AboveNormal - выше среднего
              thread2.Priority = ThreadPriority.AboveNormal;                 //   Normal - стандартный
              thread3.Priority = ThreadPriority.Lowest;                      //   BelowNormal - ниже среднего
                                                                             //   Lowest - самый низкий */
            



            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
        static void mythread2()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Поток 2 выводит " + i);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Поток 2 = Завершился");
        }
        static void mythread1()
        {
            for (int i = 1; i <= 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Поток 1 выводит " + i);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Поток 1 = Завершился");
        }

         static void mythread3()
         {
                for (int i = 1; i <= 4; i++)
                {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Поток 3 выводит " + i);
                }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Поток 3 = Завершился");
         }
     }
}
