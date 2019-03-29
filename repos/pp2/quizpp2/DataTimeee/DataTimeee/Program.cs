using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DataTimeee
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                DateTime time = DateTime.Now;
                TimeSpan diff = time.Subtract(new DateTime(2019, 3, 29, 3, 30, 0));
                Console.WriteLine(time.ToString("yyyy-MM-dd HH:mm:ss.fff") + " " + diff);
                Thread.Sleep(1000);
            }
        }
    }
}
