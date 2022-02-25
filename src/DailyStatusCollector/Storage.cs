using System.Collections.Generic;
using System.IO;

namespace DailyStatusCollector
{
    internal class Storage
    {
        public IEnumerable<string> ReadAllLines() =>
            File.ReadAllLines("storage");

        public void AppendLine(string text) =>
            File.AppendAllText("storage", $"\n{text}");
    }
}