using System.Collections.Generic;

namespace DailyStatusCollector
{
    internal class CommitRepository
    {
        public IEnumerable<Commit> Get()
        {
            return new []
            {
                new Commit("Code review od PR-777 done."),
                new Commit("Created PR-888")
            };
        }
    }
}