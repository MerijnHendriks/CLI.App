/* ExitView.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using App.Core.System;

namespace App.Core.View
{
    public class ExitView : AView
    {
        public ExitView()
        {
            Add("Terminanting app...");
            SystemManager.Get<ViewSystem>().Get<HelpView>().Add("exit: terminates app");
        }
    }
}
