using System;
using System.Collections;
using System.Collections.Generic;
using SortList;
namespace SortList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("001", "Nguyen Van A");
            sl.Add("002", "Nguyen Van B");
            sl.Add("003", "Nguyen Van C");
            sl.Add("004", "Nguyen Van D");
            sl.Add("005", "Nguyen Van E");
            sl.Add("006", "Nguyen Van F");
            
            if(sl.ContainsValue("Nguyen Van G"))
            {
                Console.WriteLine("This name is already in the list");
            }
            else
            {
                sl.Add("007", "Nguyen Van G");
            }

            ICollection key = sl.Keys;

            foreach(string k in key)
            {
                Console.WriteLine(k + ":" + sl[k]);
            }
        }
    }
}
