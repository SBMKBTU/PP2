using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Example2
{
    public class Complex
    {
        
        public string onenum;
        public string twonum;
        public Complex()
        {

        }
        public void PrintInfo()
        {
            Console.WriteLine(string.Format("{0}+ {1}*i", onenum, twonum));
            //Console.Write(onenum + "+" + twonum +"*i");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Serialize();
            Deserialize();
        }

        private static void Deserialize()  //Процесс десериализации
        {
            FileStream fs = new FileStream("complex.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Complex));
            Complex student = xmlSerializer.Deserialize(fs) as Complex;  
            student.PrintInfo();
            fs.Close();
        }

        private static void Serialize() //Сериализация
        {
            Complex complexx = new Complex();
            complexx.onenum = Console.ReadLine();
            complexx.twonum = Console.ReadLine();
            //complexx.onenum = 2;
            //complexx.twonum = 3;
            XmlSerializer xs = new XmlSerializer(typeof(Complex));

            FileStream fs = new FileStream("complex.txt", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, complexx);
            fs.Close();
        }
    }
}
