using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A._73306.palindrome
{
    class Program
    {
        public static bool Palindromtest(string s)
        {
            for (int i = 1, j = s.Length - 1; i < j; i++, j--)

                if (s[i] != s[j])
                    return false;
            return true;

        }
    

        static void Main(string[] args)
        {
           
                string s;
            Console.WriteLine("Анализ палиндромов\n\nВведите строку:");
            s = Console.ReadLine();
            if (Palindromtest(s)==true)
                Console.WriteLine("Эта строка - не палиндром");
            else Console.WriteLine("Эта строка -палиндром ");
            Console.ReadLine();

        }
    }
}
