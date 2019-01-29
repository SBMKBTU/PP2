using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6._72768.Reverse
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

            Console.WriteLine("Reverse: ");
            for(int i=n-1 ; i>=0; i--)
            {
                Console.Write(a[i]+ " ");
            }
            Console.ReadKey();
        }
    }
}
