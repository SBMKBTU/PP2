using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2
{
    class Program
    {
        static void Main(string[] args)             /// int.Parse(массив назв.) - перевести в интеджер взяв цифры из массива
        {                                          ///int.TryParse(массив назв. , out то что хотите )

            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(a + b);

            int aa = int.Parse(a);
            int bb = int.Parse(b);
            Console.WriteLine(aa + bb);
        }
    }
}
