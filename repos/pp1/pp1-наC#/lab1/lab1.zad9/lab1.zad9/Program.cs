using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n % 10 + n / 10 % 10 + n / 100);
            Console.ReadKey();
        }
    }
}
