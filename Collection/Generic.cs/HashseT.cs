using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Generic.cs
{
    internal class HashseT
    {
            static void Main(string[] args)
            {
                HashSet<string> list1 = new HashSet<string>();

                list1.Add("pune");
                list1.Add("mumbai");
                list1.Add("nagpur");
                list1.Add("pune");

                list1.Remove("nagpur"); // remove the single element that we specified in the argument
              //  list1.Clear();  // remove all the elements
                foreach (string item in list1)
                {
                    Console.WriteLine(item);
                }
            }

        
    }
}
