using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad8._72782.сколько_odd_и_even_в_массиве
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
            Console.WriteLine("Наш массив: ");
            for(int i=0; i<n; i++)
            {
                Console.Write(a[i]+" ");
            }

            int odd = 0;
            int even = 0;
            Console.WriteLine();
            for(int i=0; i<n; i++)
            {
                if (a[i] % 2 == 0) even++;
                else odd++;
            }
            Console.WriteLine("Odd: " + odd);
            Console.WriteLine("Even: " + even);
            Console.ReadKey();
        }

    }
}
