using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Generic.cs
{
    public class DuplicateList
    {   // Create a list and remove Duplicate from list.
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 2, 3, 4, 6, 7, 2, 8, 3, 9 };
            List<int> list = new List<int>();

            for(int i=0; i<numbers.Count; i++)
            {
                if (!list.Contains(numbers[i]))
                {
                    list.Add(numbers[i]);
                }
            }
            foreach(int number in list)
            {
                Console.WriteLine(number);
            }

        }
    }
}
