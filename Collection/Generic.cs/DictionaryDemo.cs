using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Generic.cs
{
    public class DictionaryDemo
    {
        static void Main(string[] args)
        {
            // 10. WAP to store country code & country name using generic dictionary.Add & display details.
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            dictionary.Add(036, "Australia");
            dictionary.Add(076, "Brazil");
            dictionary.Add(352, "India");

            foreach (KeyValuePair<int,string> item in dictionary)
            {
                Console.WriteLine($"{item.Key},{item.Value}");
            }



            // Document type,file.
            Dictionary<string,string> dictionary1= new Dictionary<string,string>();
            dictionary1.Add(".docx", "Word file");
            dictionary1.Add(".xlsx", "Excel file");
            dictionary1.Add(".cs", "C# file");
            foreach( KeyValuePair<string,string> item in dictionary1)
            {
                Console.WriteLine($"{item.Key },{item.Value}");
            }




            // Employee id , Employee type.
            Dictionary<int,string> dictionary2= new Dictionary<int,string>();
            dictionary2.Add(101, "HR");
            dictionary2.Add(102, "Sales");
            dictionary2.Add(103, "Marketing");

            dictionary2.Remove(103);

            foreach( KeyValuePair<int,string> item in dictionary2)
            {
                Console.WriteLine($"{item.Key},{item.Value}");
            }
        }
    }
}
