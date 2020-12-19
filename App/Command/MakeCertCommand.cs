/* MakeCertCommand.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using System;
using App.System;
using App.Utils;

namespace App.Command
{
    public class MakeCertCommand : ICommand
    {
        public MakeCertCommand()
        {
            SystemManager.Get<CommandSystem>()
                         .Get<HelpCommand>()
                         .Add("makecert: generate selfsigned cert");
        }

        public bool IsMatch(string[] args)
        {
            return args[0] == "makecert";
        }

        public void Execute(string[] args)
        {
            Console.WriteLine("Generating selfsigned cert...");
            CertUtil.MakeSelfSigned();
            Console.WriteLine("Done");
        }
    }
}
