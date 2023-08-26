using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.NonGeneric.cs
{
    public class ArrList
    {
        static void Main(string[] args)
        {
            // Add(),insert(),Remove(),RemoveAt(),RemoveRange(),AddRange(),Clear(),Sort(),Reverse(),Count,Capacity.

            int[] arr = new int[] { 67, 45, 12, 78 };
            ArrayList list = new ArrayList();
            list.Add(11);
            list.Add(22);
            list.Add(38);

            list.Insert(1, 1.5);
            list.AddRange(arr); // add multiple values at a time 
            list.Remove(1.5);

            // remove the element based on index.
            list.Remove(0);

            // Remove multiple elements at once.
            list.RemoveRange(2, 4);

            // Remove all elemments
            list.Clear();

            list.Sort(); // Ascending order 
            list.Reverse(); // Reverse 

            Console.WriteLine("Count(Total element) " + list.Count); // count total element
            Console.WriteLine("Capacity " + list.Capacity);


            foreach (int item in list)
            {
                Console.WriteLine(item);
            }



















        }
    }
}
