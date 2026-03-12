using System;
using System.Collections.Generic;
using System.Text;

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
        }
        public T Get()
        {
            for(int i = 0; i < _available.Count; i++)
            {

            } 
        }
    }
}
