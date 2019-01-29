using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            

            if (num1 > num2)
            {
                Console.WriteLine(1);
            }
            else if (num1 < num2)
            {
                Console.WriteLine(2);

            }
            else
            {
                Console.WriteLine(0);
            }
            Console.ReadKey();
        }
    }
}
