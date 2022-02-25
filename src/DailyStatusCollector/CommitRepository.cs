using System.Collections.Generic;
using System.Linq;

namespace DailyStatusCollector
{
    internal class CommitRepository
    {
        private readonly Storage _storage;

        public CommitRepository(Storage storage) => _storage = storage;

        public IEnumerable<Commit> Get() =>
            _storage
                .ReadAllLines()
                .Select(x => new Commit(x));

        public void Add(Commit commit) =>
            _storage
                .AppendLine(commit.Text);
    }
}