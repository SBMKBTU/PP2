using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad11._72789._2power
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            while (x < n)
            {                              
              
                Console.Write(x + " ");
                x *= 2;
            }
            Console.ReadKey();
        }
    }
}
