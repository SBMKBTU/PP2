using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Serialization;
using System.IO;

namespace ErzhQ2
{
    public class Program
    {
        public class Person
        {
            public string name;
            public string massage;
            public void PrintInfo()
            {
                Console.WriteLine(name + ":" + massage);
            }
            public override string ToString()
            {
                return name + ":" + massage;
            }

        }
       
        static void Main(string[] args)
        {
           Serialize();
           //Deserialize();
        }
        static void Deserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Person>));
            using (FileStream fs1 = new FileStream("tttt.txt", FileMode.Open))   //открываем файл для чтения
            {
                List<Person> res = (List<Person>)xs.Deserialize(fs1);   //Десеривализуем то чо в файле тхт в лист рес
                foreach (var el in res)
                {
                    Console.WriteLine("{0}", el.ToString()); //показываем в консоле преоброзовывая ее в стринг методом toString()
                }
            }

        }
        static void Serialize() { 
            List<Person> sms = new List<Person>();
            Person Samat = new Person();
            Samat.name = "Samat";
            Samat.massage = "Hello!";
            Person Bagdan = new Person();
            Bagdan.name = "Bagdan";
            Bagdan.massage = "Hello! How are you?";
            Person Mirbulatuly = new Person();
            Mirbulatuly.name = "Mirbulatuly";
            Mirbulatuly.massage = "NORMAL'NO!)))))";

            sms.Add(Samat);
            sms.Add(Bagdan);
            sms.Add(Mirbulatuly);

            Samat.PrintInfo();
            Bagdan.PrintInfo();
            Mirbulatuly.PrintInfo();

            XmlSerializer xs = new XmlSerializer(typeof(List<Person>));    //Объявляем что серилизуем лист Марк
            FileStream fs = new FileStream("tttt.txt", FileMode.Create, FileAccess.Write);    // Создаем тхт файл и пишем в нее то что будем среиализовать  
            xs.Serialize(fs, sms);  //в файл сериализуем то что в Поинте
            fs.Close();
        }
        
          
    }
}
