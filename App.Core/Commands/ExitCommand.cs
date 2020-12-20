/* ExitCommand.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using App.Core.System;
using App.Core.Views;

namespace App.Core.Commands
{
    public class ExitCommand : ICommand
    {
        public bool Executing { get; private set; }

        public ExitCommand()
        {
            Executing = false;
        }

        public bool IsMatch(string[] args)
        {
            return args[0] == "exit";
        }

        public void Execute(string[] args)
        {
            SystemManager.Get<ViewSystem>().SetView<ExitView>();
            Executing = true;
        }
    }
}
