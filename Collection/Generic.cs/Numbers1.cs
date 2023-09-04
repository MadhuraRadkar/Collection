using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Generic.cs
{
    public class Numbers1
    {  // 1.Create an array of 5 integers.Initialize 5 values & display using foreach loop.
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            List<int> numList = new List<int>(numbers);

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
