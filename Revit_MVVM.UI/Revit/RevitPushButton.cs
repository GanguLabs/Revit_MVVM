using Autodesk.Revit.UI;
using Revit_MVVM.Core;
using Revit_MVVM.Res;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit_MVVM.UI
{
    public static class RevitPushButton
    {

        public static PushButton Create(RevitPushButtonDataModel data)
        {
            string btndataName = Guid.NewGuid().ToString();

            PushButtonData btnData = new PushButtonData(btndataName, data.Label, CoreAssembly.GetAssembly(), data.CommandNamespacePath)
            {
                LargeImage = ResourceImage.GetIcon(data.IconImageName)
            };

            return data.Panel.AddItem(btnData) as PushButton;
        }
    }
}
