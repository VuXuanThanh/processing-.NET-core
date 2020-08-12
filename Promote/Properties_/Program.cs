using System;
using System.Reflection.Metadata.Ecma335;

namespace Properties_
{
    
    class Student
    {
        private string code = "ABC";
        private string name = "Not define";
        private int age;

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public override string ToString()
        {
            return "Code= " + Code + ", Name: " + Name + ", Age= " + Age;
        }
    }

    public abstract class Person
    {
        public abstract string Name
        {
            get;
            set;
        }
        public abstract int Age
        {
            get;
            set;
        }
    }

    class Employee : Person
    {
        private string code = "No define";
        private string name = "no define";
        private int age = 0;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return "Code = " + Code + ",Name = " + Name + ", Age = " + Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Code = "2018604704";
            s.Name = "Thanh Vu";
            s.Age = 20;
            Console.WriteLine("The infor of student: {0}", s);

            s.Age += 1;
            Console.WriteLine("The infor of student: {0}", s);

            // 2.
            Employee em = new Employee();
            em.Code = "2018604705";
            em.Name = "Vu Xuan Thanh";
            em.Age = 24;

            Console.WriteLine("Infor of student: " + em);
           


        }
    }
}
