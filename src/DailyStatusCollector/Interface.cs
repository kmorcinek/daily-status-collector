using System;
using System.Collections.Generic;

namespace DailyStatusCollector
{
    internal class Interface
    {
        private readonly CommitRepository _repository;

        public Interface(CommitRepository repository)
        {
            _repository = repository;
        }

        public void ShowCommits()
        {
            var commits = _repository.Get();
            Print(commits);
        }

        private void Print(IEnumerable<Commit> commits)
        {
            foreach (var commit in commits)
            {
                Console.WriteLine($"> {commit.Text}");
            }
        }
    }
}