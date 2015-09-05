using ManyConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webatang.ProjectSynchroniser.CLI.ArgumentCommands
{
    using Webatang.ProjectSynchroniser.Runner;

    public class PathConsoleCommand : ConsoleCommand
    {
        public string ProjectFileNameAndPath { get; private set; }

        public PathConsoleCommand()
        {
            IsCommand("path", "The filename and path to the project being processed");

            HasRequiredOption("p=", "The filename and path to the project being processed", p => ProjectFileNameAndPath = p);
        }

        public override int Run(string[] remainingArguments)
        {
            IProjectSyncroniserRunner runner = new DefaultProjectSynchroniserRunner();

            var project = runner.Process(ProjectFileNameAndPath);

            return 0;
        }
    }
}
