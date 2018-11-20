using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students do you have?");
            int stdntCount = int.Parse(Console.ReadLine());
            Student[] MyClass = new Student[stdntCount];
            SetClass(MyClass);
            ShowClass(MyClass);
        }

        static void ShowClass(Student[] MyClass)
        {
            Console.WriteLine("YOUR CLASS:");
            for (int i = 0; i < MyClass.Length; i++)
            {
                Console.WriteLine("Student number " + (i + 1)+":");
                MyClass[i].ShowStudent();
            }
        }
        static void SetClass(Student[] MyClass)
        {
            for (int i = 0; i < MyClass.Length; i++)
            {
                MyClass[i] = new Student();
                MyClass[i].SetStudent();
            }
        }
    }
    class Student
    {
        // Fields
        int sId;
        int sGrade;
        string sName;
        // Methods

        // Set
        public void SetName(string name)
        {
            if (2 <= name.Length)
            {
                sName = name;
            }
            else
                Console.WriteLine("INVALID NAME");
        }
        public void SetGrade(int grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                sGrade = grade;
            }
            else
                Console.WriteLine("INVALID GRADE");
        }
        public void SetId(int id)
        {
            if (id >= 0)
                sId = id;
            else
                Console.WriteLine("INVALID ID");
        }
        public void SetStudent()
        {
            Console.WriteLine("Student name:");
            string name = Console.ReadLine();
            SetName(name);
            Console.WriteLine("Student ID:");
            int id = int.Parse(Console.ReadLine());
            SetId(id);
            Console.WriteLine("Grade:");
            int grade = int.Parse(Console.ReadLine());
            SetGrade(grade);
        }

        // Get
        public int GetId()
        {
            return sId;
        }
        public int GetGrade()
        {
            return sGrade;
        }
        public string GetName()
        {
            return sName;
        }

        // Show
        public void ShowStudent()
        {
            Console.WriteLine($"Name={sName} ID:{sId} Grade:{sGrade}");
        }

    }
}
