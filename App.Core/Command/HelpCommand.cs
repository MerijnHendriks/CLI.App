﻿/* HelpCommand.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using App.Core.System;
using App.Core.View;

namespace App.Core.Command
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
