using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad11._73242.Duplicates_удалить_похожие_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0; i< n; i++)
            {
                a[i]= Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array : ");
            for(int i=0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            int x;
            Console.WriteLine("New Array: ");
            List<int> temp = a.ToList();
            for ( int i = 0 ; i < n ; i++){
                if (a[i] == a[i + 1])
                {
                    x = a[i];
                    temp.RemoveAt(x);
                    a = temp.ToArray();
                }
            }
            
            
           
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
