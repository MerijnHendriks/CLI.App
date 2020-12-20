/* Program.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using App.Core.System;
using App.Core.Command;
using App.Core.View;

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
            commands.Add<ExitCommand>();
            commands.Add<BackCommand>();

            // add views
            var views = SystemManager.Get<ViewSystem>();
            views.Add<HelpView>();
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
