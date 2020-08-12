using System;
using System.Collections;
using System.Linq;

namespace Collection_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push('A');
            stack.Push('B');
            stack.Push('C');
            stack.Push('D');
            stack.Push('E');

            Console.WriteLine("Current stack: ");
            foreach(char c in stack)
            {
                Console.WriteLine(c + " ");
            }

            stack.Push('V');
            stack.Push('G');

            Console.WriteLine("the next popable value in stack: {0}", stack.Peek());
            Console.WriteLine("After removing: ");
            foreach (char c in stack)
            {
                Console.WriteLine(c + " ");
            }


            Console.WriteLine("Pop method in Stack");
            stack.Pop();

            Console.WriteLine("Current stack: ");
            foreach (char c in stack)
            {
                Console.WriteLine(c + " ");
            }
        }
    }
}
