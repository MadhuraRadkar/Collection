using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Generic.cs
{
    public class ConvertArrayToList
    {    // Write a code to convert array to list in various ways.
        static void Main(string[] args)
        {
            // using AddRange method.
            int[] array = { 10, 20, 30, 40, 50 };
            List<int> list=new List<int>();
            list.AddRange(array);


            // Using for loop
            int[] array1 = { 11, 12, 13, 14, 15 };
            List<int> list1=new List<int>();
            for(int i = 0; i < array1.Length; i++)
            {
                list1.Add(array1[i]);
            }


            // Using the Constructor.
            int[] array2 = { 100, 200, 300, 400 };
            List<int> list2 = new List<int>(array2);



            //-----------------------------------------------------------
            // Convert list to array in different ways.

            // Using for loop
            List<int> list3 = new List<int> { 2, 4, 6, 8, 10 };
            int[] array3 = new int[list3.Count];
            for(int i = 0; i < list3.Count; i++)
            {
                array3[i] = list3[i];
            }


            // Using Constructor
            List<int> list4 = new List<int> { 5, 10, 15, 20, 25 };
            int[] array4 = list4.ToArray();
            

        }
    }
}
