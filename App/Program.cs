﻿/* Program.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using App.Core.System;
using App.Core.Commands;
using App.Core.Views;

namespace App
{
    static class Program
    {        
        static void Main()
        {
            // add systems
            SystemManager.Add<CommandSystem>();
            SystemManager.Add<ViewSystem>();

            // add commands
            var commands = SystemManager.Get<CommandSystem>();
            commands.Add<HelpCommand>();
            commands.Add<BackCommand>();
            commands.Add<ExitCommand>();

            // add views
            var views = SystemManager.Get<ViewSystem>();
            views.Add<HelpView>();
            views.Add<BackView>();
            views.Add<ExitView>();

            // show help
            SystemManager.Get<ViewSystem>().SetView<HelpView>();

            // app loop
            while (!commands.Get<ExitCommand>().Executing)
            {
                SystemManager.OnUpdate();
            }
        }
    }
}
