using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F._73067.Mass_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int m1, m2, m3;
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            m3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if(m1<99 || m1>699 || m2<99 || m2>699 || m3<99 || m3 > 699)
            {
                Console.Write("Error");
            }
            else
            {
                if(m1>=m2 && m1 >= m3)
                {
                    Console.Write(m1);
                }
                else if(m2>=m1 && m2 >= m3)
                {
                    Console.Write(m2);
                }
                else
                {
                    Console.Write(m3);
                }
            }
            Console.ReadKey();


        }
    }
}
