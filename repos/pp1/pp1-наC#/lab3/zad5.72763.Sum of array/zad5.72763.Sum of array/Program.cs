using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5._72763.Sum_of_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            for(int i=0;i<n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Massiv: ");

            for(int i=0;i<n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int sum = 0;
            Console.WriteLine("Sum of array: ");
            for(int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}
