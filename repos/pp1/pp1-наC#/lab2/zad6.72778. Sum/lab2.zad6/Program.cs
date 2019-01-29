using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i <=n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    

    }
}
