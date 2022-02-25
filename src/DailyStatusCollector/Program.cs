using System;

namespace DailyStatusCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Daily Status Collector!");

            var commitRepository = new CommitRepository();
            var @interface = new Interface(commitRepository);
            @interface.ShowCommits();
        }
    }
}
