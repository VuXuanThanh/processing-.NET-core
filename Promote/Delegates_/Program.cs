﻿using System;


delegate int NumberChanger(int n);
namespace Delegates_
{
    class Program
    {
        static int num = 10;
        
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }
        static void Main(string[] args)
        {

            // create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);

            NumberChanger nc2 = new NumberChanger(MultNum);

          
            // calling the method using the delegate objects
          /*  nc1(25);
            Console.WriteLine("Value of Num: {0}", getNum());

            nc2(10);
            Console.WriteLine("Value of Num: {0}", getNum());*/

            NumberChanger nc;
            nc = nc1;
            nc += nc2;
            nc(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadKey();
        }
    }
}
