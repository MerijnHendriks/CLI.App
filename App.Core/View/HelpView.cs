/* HelpView.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

namespace App.Core.View
{
    public class HelpView : AView
    {
        public HelpView()
        {
            Add("help: show this menu");
            Add("back: revert to previous view");
        }
    }
}
