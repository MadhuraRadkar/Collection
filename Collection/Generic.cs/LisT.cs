using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Generic.cs
{
    public class LisT
    {
        static void Main(string[] args)
        {

            // Generic collections --> List<T>
            // T---> placeholder for type--> T stands for type(int,float,string,emp,stu)
            int[] arr = new int[] { 25, 21 };
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(23);
            list.Add(3);
            list.Add(42);
            list.Add(5);

            //list.Insert(0, 15);
           // list.AddRange(arr);
            //list.Remove(15);
           // list.RemoveAt(0);
           // list.RemoveRange(2,2);
          // list.Clear();
           // list.Sort();

            Console.WriteLine("Count(Total element) " + list.Count); // count total element
            Console.WriteLine("Capacity " + list.Capacity);



            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
