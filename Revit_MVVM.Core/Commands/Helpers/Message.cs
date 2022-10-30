using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit_MVVM.Core
{
    public static class Message
    {
        public static void Display(string message, WindowType type)
        {
            string title = "";
            TaskDialogIcon icon = TaskDialogIcon.TaskDialogIconNone;

            switch (type)
            {
                case WindowType.Information:
                    title = "- INFORMATION -";
                    icon = TaskDialogIcon.TaskDialogIconInformation;
                    break;
                case WindowType.Warning:
                    title = "- WARNING -";
                    icon = TaskDialogIcon.TaskDialogIconWarning;
                    break;
                case WindowType.Error:
                    title = "- ERROR -";
                    icon = TaskDialogIcon.TaskDialogIconError;
                    break;
                default:
                    break;
            }

            TaskDialog window = new TaskDialog(title)
            {
                MainContent = message,
                MainIcon = icon,
                CommonButtons = TaskDialogCommonButtons.Ok,

            };

            window.Show();
        }
    }
}
