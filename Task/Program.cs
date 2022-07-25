using System;
using System.Threading.Tasks;
namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TaskLetrehozas();
            //CancellationTokenBemutatasa();
            //EgymasraFuzottTaskok();
            TaskTomb();
            Console.ReadKey();
        }

        private static void TaskTomb()
        {
            Task[] konkurens = new Task[]
            {
                Task.Run(() => Console.WriteLine("Egyik")),
                Task.Run(() => Console.WriteLine("Másik")),
                Task.Run(() => Console.WriteLine("Harmadik")),
                Task.Run(() => Console.WriteLine("Negyedik")),
            };

            Task.WhenAll(konkurens).ContinueWith(t =>
            {
                Console.WriteLine("Vége");
            });
        }

        private static void EgymasraFuzottTaskok()
        {
            Task.Run(() =>
            {
                Console.WriteLine("Első Task");
                throw new Exception();
            }).ContinueWith((t) =>
            {
                //t az előzőnek futtatott task
                Console.WriteLine("Következő Task");
                //Az előzőleg nem kezelt kivétel miatt a státusza Faulted lesz
                Console.WriteLine("Előző task eredménye: {0}", t.Status);
            });
        }

        private static void CancellationTokenBemutatasa()
        {
            try
            {
                var t = new Task(() =>
                Thread.Sleep(TimeSpan.FromSeconds(2)));
                t.Start();
                t.Wait(500, new CancellationToken(true));
                Console.WriteLine(t.Status);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void TaskLetrehozas()
        {
            Action<object> paramTask = (object p) => Console.WriteLine($"Task {p}");
            Task.Factory.StartNew(paramTask, "egy");

            Task.Run(() => Console.WriteLine("Hello Task!"));

            var t = new Task<int>(() => { return 42; });
            t.Start();
            Console.WriteLine($"A 't' Task eredménye: {t.Result}");

            var num = 5;
            Task<int> calculated = Task.Run(() => num * 10);

            int result = calculated.Result;
            Console.WriteLine(result);
        }
    }
}
