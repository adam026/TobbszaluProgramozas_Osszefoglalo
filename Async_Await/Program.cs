namespace Async_Await
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Async_Await_Bemutatas();
        }

        private static void Async_Await_Bemutatas()
        {
            Console.WriteLine("Async előtt");
            DoThingAsync();
            Console.WriteLine("Async után");
            Console.ReadKey();
        }

        private async static void DoThingAsync()
        {
            await PrintCurrentTimeAsync();
        }

        private static async Task PrintCurrentTimeAsync()
        {
            Console.WriteLine(DateTime.Now);
            await Task.Delay(2000);
            Console.WriteLine(DateTime.Now);
        }
    }
}
