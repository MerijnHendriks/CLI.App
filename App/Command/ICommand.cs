/* ICommand.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

namespace App.Command
{
    public interface ICommand
    {
        public bool IsMatch(string[] args);
        public void Execute(string[] args);
    }
}
