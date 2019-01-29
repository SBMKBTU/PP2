using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad9._72784.сколько_цифр_оканчивается_на_7
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

            int seven = 0;
            Console.WriteLine();
            for(int i = 0; i < n; i++)
            {
                if (a[i] % 10 == 7) seven++;
            }

            Console.Write("Сколько цифр в массиве заканчив. на 7 : " + seven);
            Console.ReadKey();
        }
    }
}
