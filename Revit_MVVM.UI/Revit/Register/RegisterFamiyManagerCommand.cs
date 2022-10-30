using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Revit_MVVM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Revit_MVVM.UI
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class RegisterFamiyManagerCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            return Result.Succeeded;
        }

        public Result Execute(UIApplication uIApplication)
        {
            var data = new DockablePaneProviderData();
            var managerPage = new FamilyManagerMainPage();

            data.FrameworkElement = managerPage as FrameworkElement;

            var state = new DockablePaneState
            {
                DockPosition = DockPosition.Right,
            };

            var dpid = new DockablePaneId(PaneIdentifiers.GetManagePaneIdentifier());
            uIApplication.RegisterDockablePane(dpid, "Family Manager", managerPage as IDockablePaneProvider);
            
            return Result.Succeeded;
        }
    }
}
