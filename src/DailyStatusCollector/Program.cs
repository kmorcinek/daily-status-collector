namespace DailyStatusCollector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storage = new Storage();
            storage.Init();
            var commitRepository = new CommitRepository(storage);
            var @interface = new Interface(commitRepository);
            @interface.Canvas(args);
        }
    }
}
