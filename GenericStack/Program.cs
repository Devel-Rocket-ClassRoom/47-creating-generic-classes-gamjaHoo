using System;

namespace GenericQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleQueue<int> queue1 = new SimpleQueue<int>(3);
            SimpleQueue<string> queue2 = new SimpleQueue<string>(2);

            Console.WriteLine("=== int 큐 ===");
            queue1.EnQueue(10);
            queue1.EnQueue(20);
            queue1.EnQueue(30);
            Console.WriteLine("Enqueue: 10, 20, 30");
            Console.WriteLine($"Count: {queue1._count}, IsFull: {queue1.IsFull}");
            queue1.EnQueue(50);
            Console.WriteLine($"Peek: {queue1.Peek()}");
            Console.WriteLine($"Dequeue: {queue1.DeQueue()}");
            Console.WriteLine($"Dequeue: {queue1.DeQueue()}");
            Console.WriteLine($"Count: {queue1._count}, IsEmpty: {queue1.IsEmpty}");

            Console.WriteLine("=== string 큐 (용량: 2) ===");
            queue2.EnQueue("Hello");
            queue2.EnQueue("World");
            Console.WriteLine($"Enqueue: Hello, World");
            Console.WriteLine($"Dequeue: {queue2.DeQueue()}");
            Console.WriteLine($"Dequeue: {queue2.DeQueue()}");
            Console.WriteLine($"Dequeue: {queue2.DeQueue()}");
            Console.WriteLine($"IsEmpty: {queue2.IsEmpty}");
        }
    }
}