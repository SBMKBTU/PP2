using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G._73535.dozen
{
    class Program
    {
        static void Main(string[] args)
        {
            long n;
            n = Convert.ToInt64(Console.ReadLine());
            if (n <= 10)
            {
                n /= 10;
            }
            else if (n >= 1000)
            {
                n=((n/10)%100);
            }
            
            else
            {
                n /= 10;
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
