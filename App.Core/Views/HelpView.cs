/* HelpView.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

namespace App.Core.Views
{
    public class HelpView : View
    {
        public HelpView()
        {
            Add("help: show this menu");
            Add("back: revert to previous view");
        }
    }
}
