using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2._72485.Positive_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            for(int i=0;i<n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int pnum = 0;
            for(int i=0;i<n; i++)
            {
                if (a[i] > 0) pnum++;
                
            }
            Console.WriteLine("Positive numbers: "+pnum);
            Console.ReadKey();

        }
    }
}
