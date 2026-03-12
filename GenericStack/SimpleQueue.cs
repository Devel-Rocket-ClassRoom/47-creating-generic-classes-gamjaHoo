using System;
using System.Collections.Generic;
using System.Net.Quic;
using System.Text;

namespace GenericQueue
{
    internal class SimpleQueue<T>
    {
        private T[] items;
        private int _capacity;
        public int _count = 0;
        public bool IsFull => _count == _capacity;
        public bool IsEmpty => _count == 0;
        private int currentOut = 0;
        public SimpleQueue(int capacity)
        {  
            _capacity = capacity; 
            items = new T[capacity];
        }
        public void EnQueue(T item)
        {
            if(IsFull)
            {
                Console.WriteLine("큐가 가득 찼습니다.");
                return;
            }
            items[_count++] = item;
        }
        public T DeQueue()
        {
            T itemOut;
            if (IsEmpty)
            {
                Console.WriteLine("큐가 비어있습니다.");
                return default(T);
            }
            if(currentOut == _capacity - 1)
            {
                currentOut = 0;
                itemOut = items[_capacity - 1];
                items[_capacity - 1] = default(T);
                _count--;
                return itemOut;
            }
            _count--;
            itemOut = items[currentOut++];
            return itemOut;
        }
        public T Peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("큐가 비어있습니다.");
                return default(T);
            }
            return items[currentOut];
        }
    }
}
