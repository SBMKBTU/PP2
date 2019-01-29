using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7.maxi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Massiv: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            int maxi = a[0];
            Console.WriteLine();
            for(int i=0; i<n; i++)
            {
                if (maxi < a[i]) maxi = a[i];
            }
            
            Console.WriteLine("Максимум: "+ maxi);

            Console.WriteLine();
            int mini = a[0];
            for(int i=0; i<n; i++)
            {
                if (mini > a[i]) mini = a[i];
            }
            Console.WriteLine("Минимум: " + mini);
             Console.ReadKey();

        }
    }
}
