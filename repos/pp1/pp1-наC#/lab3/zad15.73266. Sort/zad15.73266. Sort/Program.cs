using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad15._73266.Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            for(int i=0; i<n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Massiv: ");
            for(int i=0;i<n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Array.Sort(a);
            Array.Reverse(a);
            Console.WriteLine();
            Console.WriteLine("Sort Massiv: ");
            for(int i=0; i<n; i++)
            {
                Console.Write(a[i] + " ");
            }
            
            Console.ReadKey();
        }
    }
}
