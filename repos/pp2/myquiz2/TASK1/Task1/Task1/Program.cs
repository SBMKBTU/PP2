using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Task1
{
    public class Program
    {
         /*public class Post
         {

             DateTime t1 = DateTime.Now;
             public string text;
             public override string ToString()
             {
                 return text;
             }
         }
         public class Author
         {
             public string name;
                public string surname;
             public int age;
             public override string ToString()
             {
                 return name + " " + surname + " " + age;
             }
         }
         public static void Deserialize()
         {
             XmlSerializer xs = new XmlSerializer(typeof(List<Post>));
             XmlSerializer xs1 = new XmlSerializer(typeof(List<Author>));
             int i = 0;
             int j = 0;
             using (FileStream fs = new FileStream("tttt.txt", FileMode.Open))   //открываем файл для чтения
             {

                 List<Post> res = (List<Post>)xs.Deserialize(fs); //Десеривализуем то чо в файле тхт в лист рес

                 foreach (var el in res)
                 {
                     Console.WriteLine("Student " + (i + 1) + ":" + " {0}", el.ToString());
                     i = i + 1;                            //показываем в консоле преоброзовывая ее в стринг методом toString()
                 }
             }
             using (FileStream fs1 = new FileStream("tttt1.txt", FileMode.Open))
             {
                 List<Author> res1 = (List<Author>)xs1.Deserialize(fs1);
                 foreach (var el1 in res1)
                 {
                     Console.WriteLine("Student " + (j + 1) + ":" + "{0}", el1.ToString());
                     j = j + 1;
                 }
             }

         }
             static void Main(string[] args)
         {
             Serializer();
           //  Deserialize();
         }
             public static void Serializer()
             {
             List<Post> Point = new List<Post>();
             Post Student = new Post();
             Post Student2= new Post();
            List<Author> Point2 = new List<Author>();
            Student.text = "jgfgjfjgfjgf";
             Student2.text = "bdsjahbdfa";
             Author Stud = new Author();
             Stud.name = "Samat";
             Stud.surname = "Bagdan";
             Stud.age = 18;
             Author Stud2 = new Author();
             Stud.name = "fytwd";
             Stud.surname = "faefaef";
             Stud.age = 19;

             Point.Add(Student);
             Point.Add(Student2);
             Point2.Add(Stud);
             Point2.Add(Stud2);












             XmlSerializer xs = new XmlSerializer(typeof(Post));  //Объявляем что серилизуем лист Марк
                 XmlSerializer xs1 = new XmlSerializer(typeof(List<Author>));
                 FileStream fs = new FileStream("dgd.txt", FileMode.Create, FileAccess.Write);    // Создаем тхт файл и пишем в нее то что будем среиализовать  
                 FileStream fs1 = new FileStream("hgfjh.txt", FileMode.Create, FileAccess.Write);
                 xs.Serialize(fs, Point);  //в файл сериализуем то что в Поинте
                 xs1.Serialize(fs1, Point2);

                 fs.Close();   //закрываем 

             }
        */
           public class pen
        {
            public string s = "#";
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);
            Console.CursorVisible = false;
            while (true)
            {
                for(int i=0; i<160; i++)
                {
                    Console.Write("#");
                    Thread.Sleep(200);
                    if (i == 39)
                    {
                        
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("#");
                        Thread.Sleep(200);
                        
                       
                    }
                    else if (i == 78)
                    {
                       
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("#");
                        Thread.Sleep(200);

                    }
                    else if (i == 117)
                    {
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("#");
                        Thread.Sleep(200);
                    }

                }
            }
        }
        
        }
    }
    

 
