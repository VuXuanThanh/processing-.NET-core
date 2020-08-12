using System;

namespace Indexers_
{
    class Program
    {
        class IndexedNames
        {
            private string[] nameList = new string[size];
            public static int size = 10;

            public IndexedNames()
            {
                for(int i = 0; i < size; i++)
                {
                    nameList[i] = "Not define";
                }
            }

            public string this[int index]
            {
                get
                {
                    string temp;
                    if(index>-1 && index <= size - 1)
                    {
                        temp = nameList[index];
                    }
                    else
                    {
                        temp = "";
                    }
                    return temp;
                }

                set
                {
                    if(index>-1 && index <= size)
                    {
                        nameList[index] = value;
                    }
                }
            }

            // Overloading
            public int this[string name]
            {
                get
                {
                    int index = 0;
                    while (index < size)
                    {
                        if (nameList[index] == name)
                        {
                            return index;
                        }
                        index++;
                    }
                    return index;
                }
            }
        }
        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Andy";
            names[1] = "Bari";
            names[2] = "Cesi";
            names[6] = "Gin";
            names[7] = "JSol";
            names[8] = "Lara";
            names[9] = "Thanh Vu";

            for(int i = 0; i < IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }


            Console.WriteLine("index of the last elements: " + names["Thanh Vu"]);
            Console.ReadKey();
        }
    }
}
