using Autodesk.Revit.UI;
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

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            throw new NotImplementedException();
        }
    }
}
