using System;
using System.Diagnostics;

namespace Attribute
{
    public class myClass
    {
       /* [Conditional("DEBUG")]*/

        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }

   
    class Program
    {
        /* static void function1()
         {
             myClass.Message("In function 1.");
             function2();
         }
         static void function2()
         {
             myClass.Message("In the function 2.");
         }*/
        [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
        static void oldMethod()
        {
            Console.WriteLine("It is the old method");
        }
        static void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }

        public static void Main(string[] args)
        {
            /*myClass.Message("In main fuction,");
            function1();
            Console.ReadKey();*/
           /* oldMethod();*/
          
        }
    }
}
