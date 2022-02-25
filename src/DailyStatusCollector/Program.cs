using System;

namespace DailyStatusCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHello Daily Status Collector!\n");

            var commitRepository = new CommitRepository();
            var @interface = new Interface(commitRepository);
            @interface.ShowCommits();
        }
    }
}
