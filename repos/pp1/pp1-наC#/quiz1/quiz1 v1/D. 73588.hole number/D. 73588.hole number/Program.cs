using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D._73588.hole_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //           У вас есть массив элементов, вы должны вывести сумму чисел с отверстиями, и у вас есть номера
            //           только между 0 и 9
            //           Номера с отверстиями: 0,4,6,8,9;
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == 4 || a[i] == 6 || a[i]==8 || a[i] == 9)
                {
                    sum =sum+ a[i];
                }
            }
            Console.WriteLine();
            Console.Write("Сумма намеров hole(отверстиями) : " + sum);
            Console.ReadKey();
               
        }
    }
}
