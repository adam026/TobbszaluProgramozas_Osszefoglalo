namespace Aync_Await_Async_Mainnel
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Async előtt");
            await PrintCurrentTimeAsync();
            Console.WriteLine("Async után");
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
