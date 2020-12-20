/* BackCommand.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using App.Core.System;

namespace App.Core.Commands
{
    public class BackCommand : ICommand
    {
        public bool IsMatch(string[] args)
        {
            return args[0] == "back";
        }

        public void Execute(string[] args)
        {
            SystemManager.Get<ViewSystem>().RevertView();
        }
    }
}
