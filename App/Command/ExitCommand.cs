/* ExitCommand.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using System;
using App.System;

namespace App.Command
{
    public class ExitCommand : ICommand
    {
        public ExitCommand()
        {
            SystemManager.Get<CommandSystem>()
                         .Get<HelpCommand>()
                         .Add("exit: terminates app");
        }

        public bool IsMatch(string[] args)
        {
            return args[0] == "exit";
        }

        public void Execute(string[] args)
        {
            Program.executing = false;
            Console.WriteLine("Terminating app...");
        }
    }
}
