using System.Collections.Generic;
using System.Linq;

namespace DailyStatusCollector
{
    internal class CommitRepository
    {
        private readonly Storage _reader;

        public CommitRepository(Storage reader) => _reader = reader;

        public IEnumerable<Commit> Get() =>
            _reader
                .ReadAllLines()
                .Select(x => new Commit(x));
    }
}