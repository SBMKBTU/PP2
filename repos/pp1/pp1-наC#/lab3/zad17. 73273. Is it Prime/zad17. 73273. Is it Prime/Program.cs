using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad17._73273.Is_it_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n=Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("No");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            Console.WriteLine("Yes");
            Console.ReadKey();
        }
    }
}
