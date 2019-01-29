using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad8._72783
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
            for(int i=0;i<n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            long sum = 0;
            Console.WriteLine("Sum: ");
            for(int i=l-1; i<r; i++)
            {
                sum += a[i];
            }
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}
