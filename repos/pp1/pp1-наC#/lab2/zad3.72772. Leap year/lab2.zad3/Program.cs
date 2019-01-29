using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            n = Convert.ToUInt32(Console.ReadLine());
            if( n % 400 == 0)
            {
             
                Console.WriteLine("YES");
            }
            else if(n%100==0)
            {
                Console.WriteLine("NO");
            }
            else if (n % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();

        }
    }
}
