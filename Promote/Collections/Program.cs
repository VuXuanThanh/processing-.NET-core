using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string Name, int Age)
        {
            this.name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {
            return "Name: " + name + " |  Age: " + age;
        }

    }

    public class sortPersons : IComparer
    {
        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;

            if(p1== null || p2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if (p1.Age > p2.Age)
                {
                    return 1;
                }
                else if (p1.Age == p2.Age)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 1. ArrayList
            /*  ArrayList arr = new ArrayList();
              Console.WriteLine("Adding some numbers: ");
              arr.Add(25);
              arr.Add(35);
              arr.Add(55);
              arr.Add(85);
              arr.Add(5);
              arr.Add(500);

              Console.WriteLine("There are {0} in this ArrayList", arr.Capacity);

              foreach (int i in arr)
              {
                  Console.WriteLine(i + " ");
              }
              Console.WriteLine("After removing 500:");
              arr.Remove(500);
              foreach (int i in arr)
              {
                  Console.WriteLine(i + " ");
              }
              Console.WriteLine("sort the elements of arraylist: ");
              arr.Sort();
              foreach (int i in arr)
              {
                  Console.WriteLine(i + " ");
              }


              Console.WriteLine("Search 85 in ArrayList: " + arr.BinarySearch(83435));*/

            ArrayList arrPersons = new ArrayList();
            //add
            arrPersons.Add(new Person("Nguyen Van Anh", 18));
            arrPersons.Add(new Person("Nguyen Van Binh", 25));
            arrPersons.Add(new Person("Nguyen Van Thanh", 30));

            //print
            foreach(Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }

            // sort

            arrPersons.Sort(new sortPersons());

            Console.WriteLine("ArrayList was sorted: ");
            foreach (Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }



    }
}
