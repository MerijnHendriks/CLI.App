/* HelpCommand.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using App.Core.System;
using App.Core.Views;

namespace App.Core.Commands
{
    public class HelpCommand : ICommand
    {
        public bool IsMatch(string[] args)
        {
            return args[0] == "help";
        }

        public void Execute(string[] args)
        {
            SystemManager.Get<ViewSystem>().SetView<HelpView>();
        }
    }
}
