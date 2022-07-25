using System;
using System.Threading.Tasks;

namespace PeldaAsyncawaitAsycAction
{
    class Program
    {
        static void Main(string[] args)
        {
            //A task magja így egy async Action delegate.
            Task.Run(async () =>
            {
                Console.WriteLine("Async előtt");
                await PrintCurrentTimeAsync();
                Console.WriteLine("Async után");
            });
            Console.ReadKey();
        }

        private static async Task PrintCurrentTimeAsync()
        {
            Console.WriteLine(DateTime.Now);
            await Task.Delay(2000);
            Console.WriteLine(DateTime.Now);
        }
    }
}
