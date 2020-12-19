/* Program.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using App.System;
using App.Command;

namespace App
{
    static class Program
    {
        public static bool executing;

        static Program()
        {
            executing = true;
        }
        
        static void Main(string[] args)
        {
            // add systems
            SystemManager.Add<DisplaySystem>();
            SystemManager.Add<CommandSystem>();

            // add commands
            var commands = SystemManager.Get<CommandSystem>();
            commands.Add<HelpCommand>();
            commands.Add<ExitCommand>();
            commands.Add<MakeCertCommand>();

            // show help
            commands.Get<HelpCommand>().Execute(null);

            // app loop
            while (executing)
            {
                SystemManager.OnUpdate();
            }
        }
    }
}
