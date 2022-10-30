using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.UI;
using Revit_MVVM.UI;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Revit_MVVM
{
    public class Main : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            var ui = new SetupInterface(application);

            application.ControlledApplication.ApplicationInitialized += DockablePaneRegisters;

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            throw new NotImplementedException();
        }

        private void DockablePaneRegisters(object sender, Autodesk.Revit.DB.Events.ApplicationInitializedEventArgs e)
        {
            var familyManagerRegisterCommand = new RegisterFamiyManagerCommand();

            familyManagerRegisterCommand.Execute(new UIApplication(sender as Application));
        }
    }
}
