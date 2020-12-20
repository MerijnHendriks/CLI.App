/* BackView.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using App.Core.System;

namespace App.Core.Views
{
    public class BackView : View
    {
        public BackView()
        {
            SystemManager.Get<ViewSystem>()
                         .Get<HelpView>()
                         .Add("back: revert to previous view");
        }
    }
}
