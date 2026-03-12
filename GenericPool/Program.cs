using System;

namespace GenericPool
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectPool<Bullet> pool = new ObjectPool<Bullet>(3);

            Console.WriteLine("=== 총알 발사 ===");

            Bullet b1 = pool.Get();
            b1.Fire(10, 20);

            Bullet b2 = pool.Get();
            b2.Fire(30, 40);

            Bullet b3 = pool.Get();
            b3.Fire(50, 60);

            Console.WriteLine($"활성: {pool.ActiveCount}, 비활성: {pool.AvailableCount}");

            Console.WriteLine("\n=== 풀 초과 시도 ===");

            Bullet b4 = pool.Get();
            if (b4 == null)
            {
                Console.WriteLine("풀이 가득 찼습니다!");
            }

            Console.WriteLine("\n=== 반납 후 재사용 ===");

            pool.Return(b1);
            Console.WriteLine("총알 반납됨");

            Console.WriteLine($"활성: {pool.ActiveCount}, 비활성: {pool.AvailableCount}");

            Bullet b5 = pool.Get();
            b5.Fire(100, 200);

            Console.WriteLine($"활성: {pool.ActiveCount}, 비활성: {pool.AvailableCount}");
        }
    }
}