using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad13._73257.Inﬁnite
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            while (n !=0 )
            {
                sum += n;
                n = Convert.ToInt32(Console.ReadLine());
               
            }
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
