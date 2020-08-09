using System;
using System.IO;

namespace File_I_or_0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*FileStream F = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for(int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);
            }
            F.Position = 0;
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine(F.ReadByte() + " ");
            }
            F.Close();
            Console.ReadKey();*/

            // StreamReader
            /* try
             {
                 using (StreamReader sr = new StreamReader("E:/processing-.NET-core/File I or 0/File I or 0/bin/Debug/netcoreapp3.1/Jamaica.txt"))
                 {
                     string line;
                     while ((line = sr.ReadLine()) != null)
                     {
                         Console.WriteLine(line);
                     }
                 }
             }
             catch(Exception e)
             {
                 Console.WriteLine("The file could not be read");
                 Console.WriteLine(e.Message);
             }
 */
            // StreamWriter
            string[] names = new string[] { "Thanh Vu", "Xuan Thanh" };
           
                using(StreamWriter srw = new StreamWriter("myName.txt"))
                {
                    foreach(string s in names)
                    {
                        srw.WriteLine(s);
                    }
                }

            string line = "";
            using(StreamReader sr = new StreamReader("myName.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }


            Console.ReadKey();
        }
    }
}
