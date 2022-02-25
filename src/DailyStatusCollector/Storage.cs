using System.Collections.Generic;
using System.IO;

namespace DailyStatusCollector
{
    internal class Storage
    {
        private const string FileName = "storage";

        public IEnumerable<string> ReadAllLines() =>
            File.ReadAllLines(FileName);

        public void AppendLine(string text) =>
            File.AppendAllText(FileName, $"\n{text}");
    }
}