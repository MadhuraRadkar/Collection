using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Generic.cs
{
    public class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);

            queue.Dequeue(); // 10 remove
            Console.WriteLine("First element in the queue " + queue.Peek());
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
