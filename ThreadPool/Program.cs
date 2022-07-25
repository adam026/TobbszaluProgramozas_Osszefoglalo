using System;
using System.Threading;

namespace ThreadPoolB
{
    public class Program
    {
        static void Main(string[] args)
        {

            //ThreadPoolBemutatas();
            PLINQ();
            Console.ReadKey();
        }

        private static void PLINQ()
        {
            var collection = new List<int>();
            for (int i = 0; i < 444; i += 2)
            {
                collection.Add(i);
            }

            var q = from c in collection.AsParallel()
                    where c % 5 == 0
                    select c;

            foreach (var item in q)
            {
                Console.Write("{0} ", item);
            }
        }

        private static void ThreadPoolBemutatas()
        {
            ThreadPool.QueueUserWorkItem(_ =>
            {
                Console.WriteLine("Thread pool művelet");
            });
        }
    }
}