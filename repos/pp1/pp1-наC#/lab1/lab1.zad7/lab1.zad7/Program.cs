using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int z;
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 99)
            {
                z = n % 100;
                Console.WriteLine(z /= 10);
            }
            else
            {
                Console.WriteLine(n / 10);
            }
            Console.ReadKey();

            }
    }
}
