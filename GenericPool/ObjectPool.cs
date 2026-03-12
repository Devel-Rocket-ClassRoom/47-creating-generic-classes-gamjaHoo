using System;
using System.Collections.Generic;

namespace GenericPool
{
    internal class ObjectPool<T> where T : class, IPoolable, new()
    {
        private int maxSize;
        private List<T> _available;
        private List<T> _active;

        public ObjectPool(int maxSize)
        {
            this.maxSize = maxSize;
            _available = new List<T>();
            _active = new List<T>();
        }

        public T Get()
        {
            T item;

            if (_available.Count > 0)
            {
                item = _available[0];
                _available.RemoveAt(0);
            }
            else
            {
                if (_active.Count + _available.Count >= maxSize)
                {
                    return null;
                }

                item = new T();
            }

            _active.Add(item);
            return item;
        }

        public void Return(T item)
        {
            if (_active.Remove(item))
            {
                item.Reset();
                _available.Add(item);
            }
        }

        public int ActiveCount
        {
            get { return _active.Count; }
        }

        public int AvailableCount
        {
            get { return _available.Count; }
        }
    }
}