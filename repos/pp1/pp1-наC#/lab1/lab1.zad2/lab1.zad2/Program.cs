using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.zad2
{
    class Program
    {
        private const string V = " is ";
        private const string Z = ".";
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int z = n + 1;
            int z1 = n - 1;
            Console.WriteLine("The next number for the number " + n + V + z + Z );
            Console.WriteLine("The previous number for the number " + n + V + z1 + Z);
            Console.ReadKey();


        }
    }
}
