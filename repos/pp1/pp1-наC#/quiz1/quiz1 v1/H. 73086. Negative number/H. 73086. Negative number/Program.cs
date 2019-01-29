using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H._73086.Negative_number
{
    class Program
    {
        static void Main(string[] args)
        {
            long n;
            n = Convert.ToInt64(Console.ReadLine());
            long k = 0;
            while (n > 0)
            {
                k=n;
                n = Convert.ToInt64(Console.ReadLine());
                
            }
            Console.WriteLine(k);
            Console.ReadKey();

        }
    }
}
