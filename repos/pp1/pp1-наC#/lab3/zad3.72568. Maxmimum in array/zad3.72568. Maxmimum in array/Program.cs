using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3._72568.Maxmimum_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            for(int i=0;i <n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Massiv: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            int maxi = a[0];

            for(int i=0; i<n; i++)
            {
                if (maxi < a[i]) maxi = a[i];
            }
            Console.WriteLine("Максимум в массиве: " + maxi);
            Console.ReadKey();
        }
    }
}
