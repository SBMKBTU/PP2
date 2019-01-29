using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K._73281.Primes
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
            int cnt = 0;
            Console.WriteLine("Massiv: ");
            for(int i=0; i<n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Primes num : ");
            for(int i=0; i<n; i++)
            {
                for(int j=2; j<=Math.Sqrt(a[i]); j++)
                {
                    if (a[i] % j != 0)
                    {
                        cnt++;                 
                   }
                   
                    
                }
            }
            Console.Write(cnt);
            Console.ReadKey();
        }
    }
}
