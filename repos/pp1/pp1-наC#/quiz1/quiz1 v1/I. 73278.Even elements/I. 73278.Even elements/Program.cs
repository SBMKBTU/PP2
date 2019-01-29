using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I._73278.Even_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine();
            for(int i=0; i<n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Massiv: ");
            for(int i=0; i<n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Элементый индекс которых четный: ");
            for(int i = 0 ; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    
                    
                        Console.Write(a[i] + " ");
                    }
                
            }
            Console.ReadKey();

        }
    }
}
