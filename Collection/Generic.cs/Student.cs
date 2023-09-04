using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Generic.cs
{
    public class Student
    {   // 2. WAP to create an array of 5 strings to store student name,sort names in ascending order & display using foreach loop.
        // Generic method.
        static void Main(string[] args)
        {
            List<string> student = new List<string>();
            student.Add("Babita");
            student.Add("Arun");
            student.Add("Virat");
            student.Add("Tara");
            student.Add("Aarti");

            student.Sort();

            foreach (string s in student)
            {
                Console.WriteLine(s);
            }

        }
    }
}
