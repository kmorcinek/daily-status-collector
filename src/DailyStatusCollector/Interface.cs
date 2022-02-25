using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyStatusCollector
{
    internal class Interface
    {
        private readonly CommitRepository _repository;

        public Interface(CommitRepository repository)
        {
            _repository = repository;
        }

        public void Canvas(string[] commandLineArgs)
        {
            if(commandLineArgs?.Any() == true)
            {
                Command(commandLineArgs.First(), commandLineArgs.Skip(1));
            }
            else
            {
                ShowHelp();
            }
        }

        private void Command(string command, IEnumerable<string> arguments)
        {
            switch (command)
            {
                case "get":
                    ShowCommits();
                    break;
                case "add":
                    bool isThereAnyArgument = arguments.Count() > 0;
                    if(isThereAnyArgument)
                    {
                        AddCommit(arguments.First());
                        break;
                    }
                    ShowHelp();
                    break;
                default:
                    ShowHelp();
                    break;
            }
        }

        private void ShowHelp()
        {
            Console.WriteLine("\nAvailable command: daily get\n");
        }

        private void ShowCommits()
        {
            var commits = _repository.Get();
            Print(commits);
        }

        private void Print(IEnumerable<Commit> commits)
        {
            foreach (var commit in commits)
                Console.WriteLine($"> {commit.Text}");
        }

        private void AddCommit(string text)
        {
            _repository.Add(new Commit(text));
        }
    }
}