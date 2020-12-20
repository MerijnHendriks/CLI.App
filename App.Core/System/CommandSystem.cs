/* CommandSystem.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using System;
using App.Core.Command;
using App.Core.Utils;

namespace App.Core.System
{
    public class CommandSystem : ISystem
    {
        private TypeList<ICommand> list;

        public CommandSystem()
        {
            list = new TypeList<ICommand>();
        }

        public void OnUpdate()
        {
            var args = Console.ReadLine().ToLower().Split(' ');

            foreach (var item in list)
            {
                if (item.IsMatch(args))
                {
                    item.Execute(args);
                    return;
                }
            }

            Console.WriteLine($"{args[0]} is not recognized as an command");
        }

        public T Get<T>() where T : ICommand
        {
            return list.Get<T>();
        }

        public void Add<T>() where T : ICommand, new()
        {
            list.Add<T>();
        }
    }
}
