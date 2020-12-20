/* AView.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using System;

namespace App.Core.View
{
    public class AView
    {
        public string Text { get; private set; }

        public void Add(string line)
        {
            Text += line + Environment.NewLine;
        }
    }
}
