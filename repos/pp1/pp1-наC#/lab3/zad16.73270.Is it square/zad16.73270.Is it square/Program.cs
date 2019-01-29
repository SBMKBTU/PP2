using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad16._73270.Is_it_square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            double c = Math.Sqrt(n * n);
            if (c % 2 == 0)
            {
                Console.WriteLine("Yes");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("No");
                Console.ReadKey();
                System.Environment.Exit(0);
            }

        }
    }
}
