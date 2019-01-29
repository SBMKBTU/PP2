using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad9._72871.Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, l, r;
            n = Convert.ToInt32(Console.ReadLine());
            l = Convert.ToInt32(Console.ReadLine());
            r = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Massiv: ");
            for(int i= 0; i<n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("Reverse: ");
            
            for (int i =r-1; i >=l-1; i++)
                {
                    Console.Write(a[i] + " ");
                }

            
            Console.ReadKey();
        }
    }
}
