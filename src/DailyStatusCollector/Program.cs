using System;

namespace DailyStatusCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHello Daily Status Collector!\n");

            var storage = new Storage();
            var commitRepository = new CommitRepository(storage);
            var @interface = new Interface(commitRepository);
            @interface.ShowCommits();
        }
    }
}
