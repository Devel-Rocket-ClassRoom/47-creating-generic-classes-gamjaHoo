using System;

namespace GenericQueue
{
    internal class SimpleQueue<T>
    {
        private T[] items;
        private int _capacity;

        private int head = 0;
        private int tail = 0;
        public int _count = 0;

        public int Count => _count;
        public bool IsFull => _count == _capacity;
        public bool IsEmpty => _count == 0;

        public SimpleQueue(int capacity)
        {
            _capacity = capacity;
            items = new T[capacity];
        }

        public void EnQueue(T item)
        {
            if (IsFull)
            {
                Console.WriteLine("큐가 가득 찼습니다.");
                return;
            }

            items[tail] = item;
            tail = (tail + 1) % _capacity;
            _count++;
        }

        public T DeQueue()
        {
            if (IsEmpty)
            {
                Console.WriteLine("큐가 비어있습니다.");
                return default(T);
            }

            T item = items[head];
            items[head] = default(T);

            head = (head + 1) % _capacity;
            _count--;

            return item;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("큐가 비어있습니다.");
                return default(T);
            }

            return items[head];
        }
    }
}