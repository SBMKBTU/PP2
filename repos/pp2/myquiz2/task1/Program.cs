using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace std
{
    public class Program
    {
        public class Departament
        {
            public string name;

        }
        public class Student
        {
            public string name;
            public string surname;
            public int grade;
        }
        public class Group
        {
            public string name;

        }
        static void Main()
        {
            Serializer();


        }
        public static void Serializer()
        {

            List<Student> Point = new List<Student>();
            Student Stud1 = new Student();
            Student Stud2 = new Student();
            Group bd = new Group();
            Stud1.name = "gdad";
            Stud2.name = "shjda";
            Stud2.surname = "dsafa";
            Stud1.surname = "safas";
            Stud1.grade = 18;
            Stud2.




        }
    }
}
    