/* Program.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using App.Core.System;
using App.Core.Command;

namespace App
{
    static class Program
    {        
        static void Main()
        {
            // add systems
            SystemManager.Add<DisplaySystem>();
            SystemManager.Add<CommandSystem>();

            // add commands
            var commands = SystemManager.Get<CommandSystem>();
            commands.Add<HelpCommand>();
            commands.Add<ExitCommand>();

            // show help
            commands.Get<HelpCommand>().Execute(null);

            // app loop
            while (!commands.Get<ExitCommand>().Executing)
            {
                SystemManager.OnUpdate();
            }
        }
    }
}
