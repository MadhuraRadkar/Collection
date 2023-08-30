using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Generic.cs
{
    internal class MathsOprtionHashet
    {
        static void Main(string[] args)
        {
            HashSet<string> list1 = new HashSet<string>();

            list1.Add("C");
            list1.Add("C++");
            list1.Add("C#");
            list1.Add("Java");

            HashSet<string> list2 = new HashSet<string>();

            list2.Add("Python");
            list2.Add("C++");
            list2.Add("Angular");
            list2.Add("Java");

            // combine the result & display unique elements
           // list1.UnionWith(list2);

            // first list matched with second & only matched elements will be displayed
          // list1.IntersectWith(list2);

            // compare first list with second & only unique elements from list1 get accepted
            list1.ExceptWith(list2);

            foreach (string item in list1)
            {
                Console.WriteLine(item);
            }

        }
    }
}
