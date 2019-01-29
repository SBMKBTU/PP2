using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._73411.Even_numbers
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
            int even = 0;
            Console.WriteLine();
            Console.WriteLine("Massiv: ");
            for(int i= 0; i<n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            for(int i=0; i<n; i++)
            {
                if (a[i] % 2 == 0) even++; 
            }
            
            Console.WriteLine("Even_numbers: ");
            Console.Write(even);
            Console.ReadKey();
        }
    }
}
