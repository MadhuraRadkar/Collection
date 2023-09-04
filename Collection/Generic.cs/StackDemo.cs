using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Generic.cs
{
    public class StackDemo
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

           //stack.Pop();
            Console.WriteLine("Top element " + stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
