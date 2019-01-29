using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad12._73247.MergeTwoArrays_Объед._2массив.В.одно_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            for(int i=0; i<n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Massiv 1: ");
            for(int i= 0;i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            k = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[k];
            for(int j=0; j< k; j++)
            {
                m[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Massiv 2: ");
            for(int j=0; j< k; j++)
            {
                Console.Write(m[j] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Massiv vmeste: ");

            int[] z = new int[a.Length + m.Length];

            Array.Copy(a, z, a.Length);
            Array.Copy(m, 0, z, a.Length, m.Length);

            Array.Sort(z);

            foreach (var i in z)
                Console.Write(i + " ");

            Console.ReadKey();
        }
    }
}
