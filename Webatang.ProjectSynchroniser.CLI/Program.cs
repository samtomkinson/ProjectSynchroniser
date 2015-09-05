using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webatang.ProjectSynchroniser.CLI
{
    using ManyConsole;

    using Webatang.ProjectSynchroniser.CLI.ArgumentCommands;

    class Program
    {
        static void Main(string[] args)
        {
            var pathConsoleCommand = new PathConsoleCommand();

            ConsoleCommandDispatcher.DispatchCommand(pathConsoleCommand, args, Console.Out);

            //pathConsoleCommand.
        }
    }
}
