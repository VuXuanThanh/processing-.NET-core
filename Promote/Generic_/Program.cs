using System;

namespace Generic_
{
    public class MyGeneric<T>
    {
        private T[] array;
        
        public MyGeneric(int size)
        {
            array = new T[size + 1];
        }
        public T getItem(int index)
        {
            return array[index];
        }
        public void setItem(int index, T value)
        {
            array[index] = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Datatype of array is Integer
            MyGeneric<int> intArray = new MyGeneric<int>(5);

            for(int i = 0; i < 5; i++)
            {
                intArray.setItem(i, i * 5);
            }

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(intArray.getItem(i));
            }
            // Datatype of array is Double

            MyGeneric<char> charArray = new MyGeneric<char>(5);

            for(int i = 0; i < 5; i++)
            {
                charArray.setItem(i, (char)(i + 97));
            }

            for(int i = 0; i < 5; i++)
            {
                Console.Write(charArray.getItem(i)+" ");
            }

        }
    }
}
