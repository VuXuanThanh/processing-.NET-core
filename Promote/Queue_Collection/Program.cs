using System;
using System.Collections;
namespace Queue_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue qe = new Queue(10);
            qe.Enqueue('H');
            qe.Enqueue('E');
            qe.Enqueue('L');
            qe.Enqueue('L');
            qe.Enqueue('O');

            Console.WriteLine("Current queue: ");
            foreach(char c in qe)
            {
                Console.Write(c + "  ");
            }
            Console.WriteLine("\nThe number of elements in the Queue is " + qe.Count);

            if (qe.Contains('D'))
            {
                Console.WriteLine("It was contained in the Queue");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine("The elements at the beginning of the Queue: " + qe.Dequeue());
            Console.WriteLine("Current queue: ");
            foreach (char c in qe)
            {
                Console.Write(c + "  ");
            }
            Console.WriteLine("The elements at the endding of the Queue: " + qe.Dequeue());
        }
    }
}
