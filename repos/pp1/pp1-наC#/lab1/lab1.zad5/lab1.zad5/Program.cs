using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int v, t;
            int z;
            v = Convert.ToInt32(Console.ReadLine());
            t = Convert.ToInt32(Console.ReadLine());
            z = v * t;
            if (v > 0)
            {
                if (z > 109)
                {

                    while (z > 109)
                        {
                            z = z- 109;
                            
                        }
                    Console.WriteLine(z);


                }
                else
                {
                    Console.WriteLine(z);
                }

            }
            else
            {
                Console.WriteLine(109 - (Math.Abs(z)));
            }
            Console.ReadKey();
        }
    }
}
