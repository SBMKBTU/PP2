using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J._73251.Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Convert.ToString(Console.ReadLine());
            string output = new string(s.ToCharArray().Reverse().ToArray());
            Console.Write(output);
            //////////////////////////////////////////////////////////////////////////////////////////////////
            //            string output = new string(s.ToCharArray().Reverse().ToArray());                  //
            //            Сначала строка снова конвертируется в массив символов.Массив(Array) реализует     //
            //          интерфейс IEnumerable, так что мы можем вызвать LINQ метод Reverse() на нем. С      //
            //          помощью вызова метода ToArray() результирующий IEnumerable снова                    //
            //          конвертируется в массив символов, которы используется в конструкторе строки.        //
            //////////////////////////////////////////////////////////////////////////////////////////////////
            Console.ReadKey();
        }
    }
}
