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

        public void Canvas(string[] commands)
        {
            if(commands?.Any() == true)
                Command(commands.First());
            else
                Menu();
        }

        private void Command(string command)
        {
            switch (command)
            {
                case "get":
                    ShowCommits();
                    break;
                default:
                    ShowHelp();
                    break;
            }
        }

        private void Menu()
        {
            Console.Write("$ ");
            var command = Console.ReadLine();
            Command(command);
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
    }
}