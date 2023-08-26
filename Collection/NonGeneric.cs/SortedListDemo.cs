using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.NonGeneric.cs
{
    internal class SortedListDemo
    {
        static void Main(string[] args)
        {    //  Print Alphabetically or Ascending order.
            SortedList sl = new SortedList();
            sl.Add(".docx", "Word File");
            sl.Add(".xlsx", "Excel File");
            sl.Add(".cs", "C# source code");
            sl.Add(".html", "Web page");

            sl.Remove(".docx");// based on key data will be removed from the SortedList.

            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }


        }
    }
}
