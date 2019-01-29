using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.zad11
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const string v = " ";
            int n, z, k=0;
            n = Convert.ToInt32(Console.ReadLine());
            
            if (n > 60)
            {
                while (n > 60)
                {
                    k++;
                    n -= 60;
                    
                }
                if (k > 23)
                {
                    k -= 23;
                }
                
              
                    z = k * 60;

                    Console.WriteLine("The result " + k , v ,n - z);


                

            }
            else
            {
                Console.WriteLine("The result " + 0, v , n);
            }
            Console.ReadKey();
        }
    }
}
