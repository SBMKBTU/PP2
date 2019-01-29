using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._73449.seven
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
                Console.Write(a[i] + " ");
            }
            int sum = 0;
            Console.WriteLine();
            for(int i=0; i<n; i++)
            {
                if (i % 7 == 0)
                {
                    sum += a[i];
                }
            }
            Console.Write("Сумма цифр индекс которых делиться на 7: " + sum);
            Console.ReadKey();
            

        }
    }
}
