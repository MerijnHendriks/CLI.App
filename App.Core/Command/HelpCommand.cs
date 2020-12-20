/* HelpCommand.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using System;
using System.Collections.Generic;

namespace App.Core.Command
{
    public class HelpCommand : ICommand
    {
        private List<string> text;

        public HelpCommand()
        {
            text = new List<string>();
            Add("help: shows this menu");
        }

        public bool IsMatch(string[] args)
        {
            return args[0] == "help";
        }

        public void Execute(string[] args)
        {
            foreach (var line in text)
            {
                Console.WriteLine(line);
            }
        }

        public void Add(string line)
        {
            if (!text.Contains(line))
            {
                text.Add(line);
            }
        }
    }
}
