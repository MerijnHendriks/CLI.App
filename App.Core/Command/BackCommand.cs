/* BackCommand.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using App.Core.System;
using App.Core.View;

namespace App.Core.Command
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
