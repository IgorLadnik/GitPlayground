namespace ConsoleAppGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("This is change done in main branch");

            Console.WriteLine("This is change done in main branch before rebase");

            Console.WriteLine("Some change in feature-1 branch before rebase");

            Logger logger = new();
            logger.Log("Logged string");
        }
    }
}
