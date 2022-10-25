using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit_MVVM.Core
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class TagWallLayersCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog msgWindow = new TaskDialog("info")
            {
                MainContent = "Test Message window from Revit",
                MainIcon = TaskDialogIcon.TaskDialogIconInformation,
                CommonButtons = TaskDialogCommonButtons.Ok
            };

            msgWindow.Show();

            return Result.Succeeded;
        }

        public static string GetPath()
        {
            return typeof(TagWallLayersCommand).Namespace + "." + nameof(TagWallLayersCommand);
        }
    }
}
