/* View.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using System;

namespace App.Core.Views
{
    public class View
    {
        public string Text { get; private set; }

        public void Add(string line)
        {
            Text += line + Environment.NewLine;
        }
    }
}
