/* ICommand.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

namespace App.Core.Command
{
    public interface ICommand
    {
        bool IsMatch(string[] args);
        void Execute(string[] args);
    }
}
