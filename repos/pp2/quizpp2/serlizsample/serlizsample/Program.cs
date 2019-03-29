using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace task2
{
    public class Program
    {
        public class Marks
        {
            public string letter;
            public int points;
           
          

            public Marks()
            {

            }
            public void GetLetter(int points)
            {
                if (points <= 100 && points >= 95)
                {
                    letter = "A";
                }
                else if (points <= 94 && points >= 90)
                {
                    letter = "A-";
                }
                else if (points <= 89 && points >= 85)
                {
                    letter = "B+";
                }
                else if (points <= 84 && points >= 80)
                {
                    letter = "B";
                }
                else if (points <= 79 && points >= 75)
                {
                    letter = "B-";
                }
                else if (points <= 74 && points >= 70)
                {
                    letter = "C+";
                }
                else if (points <= 69 && points >= 65)
                {
                    letter = "C";
                }
                else if (points <= 64 && points >= 60)
                {
                    letter = "C-";
                }
                else if (points <= 59 && points >= 55)
                {
                    letter = "D+";
                }
                else if (points <= 54 && points >= 50)
                {
                    letter = "D-";
                }
                else if (points <= 49 && points >= 0)
                {
                    letter = "F";
                }
            }
            public void PrintInfo()
            {
                Console.WriteLine(letter + " " + points);
            }
            public override string ToString()
            {
                return letter + " " + points;
            }
            
            public struct Marks1
            {
                public string gpa;
                public void GetGpa(string letter)
                {
                    if (letter == "A")
                    {
                        gpa ="4";
                    }
                    else if (letter == "A-")
                    {
                        gpa = "3.67";
                    }
                    else if (letter == "B+")
                    {
                        gpa = "3.33";
                    }
                    else if (letter == "B")
                    {
                        gpa = "3.0";
                    }
                    else if (letter == "B-")
                    {
                        gpa = "2.67";
                    }
                    else if (letter == "C+")
                    {
                        gpa = "2.33";
                    }
                    else if (letter == "C")
                    {
                        gpa = "2.0";
                    }
                    else if (letter == "C-")
                    {
                        gpa = "1.67";
                    }
                    else if (letter == "D+")
                    {
                        gpa = "1.33";
                    }
                    else if (letter == "D")
                    {
                        gpa = "1.0";
                    }
                    else if (letter == "F")
                    {
                        gpa = "0";
                    }
                }
                public override string ToString()
                {
                    return gpa;
                }

            }
            
        }
        
        static void Main(string[] args)
        {
          // Serializer();
           Deserialize();

        }
        public static void Deserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Marks>));
            XmlSerializer xs1 = new XmlSerializer(typeof(List<Marks.Marks1>));
            int i = 0;
            int j = 0;
            using (FileStream fs = new FileStream("tttt.txt", FileMode.Open))   //открываем файл для чтения
            {
                
                List<Marks> res = (List<Marks>)xs.Deserialize(fs); //Десеривализуем то чо в файле тхт в лист рес

                foreach (var el in res)
                {
                    Console.WriteLine("Student " + (i + 1) + ":" + " {0}", el.ToString());
                    i = i + 1;                            //показываем в консоле преоброзовывая ее в стринг методом toString()
                }
            }
            using (FileStream fs1 = new FileStream("tttt1.txt", FileMode.Open))
            {
                List<Marks.Marks1> res1 = (List<Marks.Marks1>)xs1.Deserialize(fs1);
                foreach (var el1 in res1)
                {
                    Console.WriteLine("Student " + (j + 1) + ":" + "{0}", el1.ToString());
                    j = j + 1;
                }
            }
        }
        public static void Serializer()
        {

            List<Marks> Point = new List<Marks>();  //Объявляем лист 
            Marks Student = new Marks();    //Записываем новый марк
            Student.points = int.Parse(Console.ReadLine());    //У студента есть определенное кол. баллов , вводим сами
            Marks Student2 = new Marks();
            Student2.points = int.Parse(Console.ReadLine());
            Marks Student3 = new Marks();
            Student3.points = int.Parse(Console.ReadLine());
            Marks Student4 = new Marks();
            Student4.points = int.Parse(Console.ReadLine());
            Marks Student5 = new Marks();
            Student5.points = int.Parse(Console.ReadLine());
            

            if (Student.points > 100 && Student2.points > 100 && Student3.points > 100 && Student4.points > 100 && Student5.points > 100 )
            {
                Student.points = 100;
                Student2.points = 100;
                Student3.points = 100;
                Student4.points = 100;
                Student5.points = 100;
                
            }
            else if (Student.points < 0 && Student2.points < 0)
            {
                Student.points = 0;
                Student2.points = 0;
                Student3.points = 0;
                Student4.points = 0;
                Student5.points = 0;
            }

            Student.GetLetter(Student.points);  //С помощью GetLetter мы определяем какая оценка по буквам у студента
            Student2.GetLetter(Student2.points);
            Student3.GetLetter(Student3.points);
            Student4.GetLetter(Student4.points);
            Student5.GetLetter(Student5.points);
            List<Marks.Marks1> Point1 = new List<Marks.Marks1>(); 
            Marks.Marks1 Gpa = new Marks.Marks1();
            Marks.Marks1 Gpa2 = new Marks.Marks1();
            Marks.Marks1 Gpa3 = new Marks.Marks1();
            Marks.Marks1 Gpa4 = new Marks.Marks1();
            Marks.Marks1 Gpa5 = new Marks.Marks1();
            Gpa.GetGpa(Student.letter);
            Gpa2.GetGpa(Student2.letter);
            Gpa3.GetGpa(Student3.letter);
            Gpa4.GetGpa(Student4.letter);
            Gpa5.GetGpa(Student5.letter);
            


            Point.Add(Student); //     И то что имееться в Студенте мы добовляем в лист Пойнт
            Point.Add(Student2);
            Point.Add(Student3);
            Point.Add(Student4);
            Point.Add(Student5);

            Point1.Add(Gpa);
            Point1.Add(Gpa2);
            Point1.Add(Gpa3);
            Point1.Add(Gpa4);
            Point1.Add(Gpa5);



            Student.PrintInfo();              //   Показываем что есть в Студенте на консоле
            Student2.PrintInfo();
            Student3.PrintInfo();
            Student4.PrintInfo();
            Student5.PrintInfo();


            XmlSerializer xs = new XmlSerializer(typeof(List<Marks>));  //Объявляем что серилизуем лист Марк
            XmlSerializer xs1 = new XmlSerializer(typeof(List<Marks.Marks1>));
            FileStream fs = new FileStream("tttt.txt", FileMode.Create, FileAccess.Write);    // Создаем тхт файл и пишем в нее то что будем среиализовать  
            FileStream fs1 = new FileStream("tttt1.txt", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, Point);  //в файл сериализуем то что в Поинте
            xs1.Serialize(fs1, Point1);
            
            fs.Close();   //закрываем 
        }
    }
}