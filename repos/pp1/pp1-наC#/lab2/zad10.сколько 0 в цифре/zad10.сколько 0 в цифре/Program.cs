using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad10.сколько_0_в_цифре
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            int zeroes = 0;
            for(int i=0; i<n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

                while (a[i] != 0)
                {
                    if (a[i] % 10 == 0) zeroes++;
                    a[i] /= 10;
                }
            }
            Console.WriteLine("Сколько 0 в цифре внутри массива= " + zeroes);
            Console.ReadKey();
        }
    }
}
