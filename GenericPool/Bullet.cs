using System;

namespace GenericPool
{
    internal class Bullet : IPoolable
    {
        public bool IsActive { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public void Fire(int x, int y)
        {
            X = x;
            Y = y;
            IsActive = true;

            Console.WriteLine($"총알 발사! 위치: ({X}, {Y})");
        }

        public void Reset()
        {
            IsActive = false;
            X = 0;
            Y = 0;
        }
    }
}