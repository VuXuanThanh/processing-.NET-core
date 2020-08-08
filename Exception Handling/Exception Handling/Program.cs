using System;

namespace Exception_Handling
{
    class Program
    {
        public static int Integer(string text)
        {
            try
            {
                Console.WriteLine("Begin: " + text);

                int value = Int32.Parse(text);
                return value;
            }
            catch(FormatException e)
            {
                Console.WriteLine("Your program has a drawback: " + e.Message);
                return 0;
            }
            finally
            {
                Console.WriteLine("ended: " + text);
            }
        }
        static void Main(string[] args)
        {
            //1. NullReferenceException
            string s = null;
            
            try
            {
                Console.WriteLine("begin: " + s.Length + 10);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("Mid: " + e.Message);
            }
            finally
            {
                Console.WriteLine("The program finished!!!");
            }

            // 2. IndexOutRangeException
            int[] a = { 1, 2, 3, 4, 5 };

            int last_Element;
            try
            {
                last_Element = a[5];
                Console.WriteLine(last_Element);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("False: " + e.Message);
            }
            finally
            {
                Console.WriteLine("done!!!");
            }

            // 3. FormatExpection
            string text = "1234s";
            int value = Integer(text);
            Console.WriteLine("output: " + value);
        }
    }
}
