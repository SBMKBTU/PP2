using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad10._73239.Upper_bound__1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;

            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            for(int i=0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (a[i] == k) { Console.WriteLine(i + 1); Console.ReadKey(); System.Environment.Exit(0);  }
                else if (k < a[i]) { Console.WriteLine(i); Console.ReadKey(); System.Environment.Exit(0); }
                
            }
            Console.WriteLine(n);
            Console.ReadKey();

        }
    }
}
