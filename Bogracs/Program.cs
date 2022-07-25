using System.Diagnostics;

namespace Bogracs
{
    internal class Program
    {
        public static async Task HagymaPucolas()
        {
            Console.WriteLine("Elkezdem pucolni a hagymát...");
            await Task.Delay(1000);
            Console.WriteLine("Megpucoltam a hagymát...");
        }

        public static async Task Husmosas()
        {
            Console.WriteLine("Elkezdem mosni a húst...");
            await Task.Delay(1000);
            Console.WriteLine("Megmostam a húst...");
        }

        public static async Task Tuzcsiholas()
        {
            Console.WriteLine("Elkezdem csiholni a tüzet...");
            await Task.Delay(1000);
            Console.WriteLine("Megcsiholtam a tüzet...");
        }

        public static async Task HagymaFelvagas()
        {
            await HagymaPucolas();
            Console.WriteLine("Felvágom a hagymát...");
            await Task.Delay(1000);
            Console.WriteLine("Felvágtam a hagymát...");
        }

        public static async Task HusFelvagas()
        {
            await HusMosas();
            Console.WriteLine("Felvágom a húst...");
            await Task.Delay(1000);
            Console.WriteLine("Felvágtam a húst...");
        }

        public static async Task HusMosas()
        {
            Console.WriteLine("Elkezdem mosni a húst...");
            await Task.Delay(1000);
            Console.WriteLine("Megmostam a húst...");
        }
        public static async Task HagymaBograncsba()
        {
            var task1 = Tuzcsiholas();
            var task2 = HagymaFelvagas();
            await task1;
            await task2;
            Console.WriteLine("Beleteszem a hagymát a bográcsba...");
            await Task.Delay(1000);
            Console.WriteLine("Beletettem a hagymát a bográcsba...");
        }
        public static async Task HusBograncsba()
        {
            await Husmosas();
            Console.WriteLine("Beleteszem a húst a bográcsba...");
            await Task.Delay(1000);
            Console.WriteLine("Beletettem a húst a bográcsba...");
        }
        public static async Task Fozes()
        {
            var task1 = HagymaBograncsba();
            var task2 =  HusBograncsba();
            await task1;
            await task2;
            //Párhuzamosan indul el a kettő
            Console.WriteLine("Elkezdem főzni a bográcst...");
            await Task.Delay(1000);
            Console.WriteLine("Megfőtt...");
        }
        public static async Task Kiszedes()
        {
            await Fozes();
            Console.WriteLine("Elkezdem a kiszedést..");
            await Task.Delay(1000);
            Console.WriteLine("Kiszedtem...");
        }
        public static async Task Elfogyasztas()
        {
            await Kiszedes();
            Console.WriteLine("Elkezdem az evést..");
            await Task.Delay(1000);
            Console.WriteLine("Köszi, finom volt...");
        }

        static async Task Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            await Elfogyasztas();
            sw.Stop();
            Console.WriteLine();
            Console.WriteLine($"Total Time: {sw.Elapsed.TotalSeconds:0.000} s");

            Console.ReadKey();
        }
    }
}