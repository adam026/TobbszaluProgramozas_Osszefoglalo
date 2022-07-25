namespace DoOperationAsync
{
    internal class Program
    {
        public static async Task DoOperation1()
        {
            Console.WriteLine("DoOperation1 Started");
            await Task.Delay(1000);
            Console.WriteLine("DoOperation1 Finished");
        }

        public static async Task DoOperation2()
        {
            Console.WriteLine("DoOperation2 Started");
            await Task.Delay(1000);
            Console.WriteLine("DoOperation2 Finished");
        }

        static async Task Main(string[] args)
        {
            await DoOperation1();

            await DoOperation2();

            var task1 = DoOperation1();
            Console.WriteLine("Ez kiíródik, amíg megy a DoOperation1");
            await task1;

            Console.ReadKey();
        }
    }
}