using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.NonGeneric.cs
{
    public class HashtableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(".docx", "World File");
            ht.Add(".Xlsx", "Excel File");
            ht.Add(".cs", "c# source code");
            ht.Add(".html", "Web Page");

            ht.Remove(".docx"); // based on key data will be removed from the hashtable.

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key}--> {item.Value}");
            }
        }
    }
}
