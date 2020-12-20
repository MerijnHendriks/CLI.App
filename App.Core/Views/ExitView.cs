/* ExitView.cs
 * License: NCSA Open Source
 * Author: Merijn Hendriks
 */

using App.Core.System;

namespace App.Core.Views
{
    public class ExitView : View
    {
        public ExitView()
        {
            Add("Terminanting app...");
            SystemManager.Get<ViewSystem>().Get<HelpView>().Add("exit: terminates app");
        }
    }
}
