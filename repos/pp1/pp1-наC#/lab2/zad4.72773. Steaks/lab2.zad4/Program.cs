using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, z = 0;
            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            
            while (k>=0)
            {
                z++;
                k -= n;
            }

            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
