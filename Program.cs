using ConsoleCommands.Commands;
using Oakton;

namespace ConsoleCommands
{
    class Program
    {
        static int Main(string[] args)
        {
            return CommandExecutor
                .ExecuteCommand<NameCommand>(args);
        }
    }
}
