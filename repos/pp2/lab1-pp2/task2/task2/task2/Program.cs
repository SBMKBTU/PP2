using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student
    {
        public string name;
        public string id;
        public int year_of_study;
        public void PrintInfo()
        {
            Console.Write(name + " " + id + " " + (year_of_study)+ " ");
            Console.WriteLine();
            
        }
        public void IncrementYearOfStudy()
        {
            year_of_study++;
            PrintInfo();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = Convert.ToString(Console.ReadLine());
            s.id = Convert.ToString(Console.ReadLine());
            s.year_of_study = Convert.ToInt32(Console.ReadLine());
            s.PrintInfo();
            s.IncrementYearOfStudy();
        }
    }
}
