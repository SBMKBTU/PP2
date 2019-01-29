using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7._72780.MaxToMin_Максимум_делаем_минимумом_
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
            for(int i=0; i<n; i++)
            {
                Console.Write(a[i] + " ");
            }

            int maxi = a[0];
            int mini = a[0];
            for(int i=0; i < n; i++)
            {
                if (maxi < a[i]) maxi = a[i];
                if (mini > a[i]) mini = a[i];
            }
            Console.WriteLine();
            Console.WriteLine("Максимум: " + maxi);
            Console.WriteLine("Минимум: " + mini);
            
            for(int i=0;i<n; i++)
            {
                if (maxi == a[i]) a[i] = mini;
            }

            Console.WriteLine("MaxToMin: ");
            for(int i=0; i<n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();

        }
    }
}
