using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1._72477.нужно_вывести_odd_циф.из_массива
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
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Нечетные: ");

            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 != 0)
                {
                    Console.Write( a[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
