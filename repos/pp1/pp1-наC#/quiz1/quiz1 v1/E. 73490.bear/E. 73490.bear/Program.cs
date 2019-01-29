using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E._73490.bear
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            int cnt = 0;
            while (n <= k)
            {
                cnt++;
                n *= 3;
                k *= 2;
            }
            Console.WriteLine();
            Console.Write("Через " + cnt + "лет у Азамата будеть больше денег чем у Даурена ");
            Console.ReadKey();
        }
    }
}
