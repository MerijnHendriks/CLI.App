/* ExitCommand.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using System;
using App.Core.System;
using App.Core.Utils;

namespace App.Core.Command
{
    public class ExitCommand : ICommand
    {
        public bool Executing { get; private set; }

        public ExitCommand()
        {
            Executing = false;
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
            Executing = true;
            Console.WriteLine("Terminating app...");
        }
    }
}
