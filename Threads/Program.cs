using System;
using System.Threading;

namespace Threads
{

    public class Program
    {
        [ThreadStatic]
        private static int _eddig;
        static void Main(string[] args)
        {

            //ThreadBemutatas();
            //ThreadBemutatasLambdaval();
            //SleepBemutatas();
            //ParameterezettSzal();
            //ParameterezettSzalKulsoParameterrel();
            KetSzalEgyIdoben();
            Console.ReadKey();
        }

        private static void KetSzalEgyIdoben()
        {
            _eddig = 5;
            new Thread(() =>
            {
                Console.Write($"\n Elszámolok {_eddig}-ig!");
                for (int i = 0; i < _eddig; i++)
                {
                    Console.Write('A');
                    Thread.Sleep(1000);
                }
                Console.Write($"\n {_eddig}");
            }).Start();

            _eddig = 3;
            new Thread(() =>
            {
                Console.Write($"\n Elszámolok {_eddig}-ig!");
                for (int i = 0; i < _eddig; i++)
                {
                    Console.Write('B');
                    Thread.Sleep(1000);
                }
                Console.Write($"\n {_eddig}");
            }).Start();
        }

        private static void ParameterezettSzalKulsoParameterrel()
        {
            _eddig = 5;
            new Thread(() =>
            {
                Console.Write($"\n Elszámolok {_eddig}-ig!");
                for (int i = 0; i < _eddig; i++)
                {
                    Console.Write('.');
                    Thread.Sleep(1000);
                }
                Console.Write($"\n {_eddig}");
            }).Start();
        }

        private static void ParameterezettSzal()
        {
            var sz = new ParameterezettSzal();
            Thread d = new Thread(new ParameterizedThreadStart(sz.ValameddigSzamol));
            d.Start(5);
        }

        private static void ThreadBemutatas()
        {
            var sz = new Szal();
            Thread t = new Thread(new ThreadStart(sz.TizigSzamol));
            t.Start();
        }

        private static void ThreadBemutatasLambdaval()
        {
            new Thread(() =>
            {
                Console.Write($"Elszámolok tízig!");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.Write("\nTíz!");
            }).Start();
            Console.ReadKey();
        }

        private static void SleepBemutatas()
        {
            Console.WriteLine(DateTime.Now);
            Thread.Sleep(10000);
            Console.WriteLine(DateTime.Now);
        }
    }
}
