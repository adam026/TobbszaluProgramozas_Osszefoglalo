namespace Threads
{
    public class Szal
    {
        public void TizigSzamol()
        {
            Console.Write("Elszámolok tízig!");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.Write("\nTíz!");
        }
    }
}
