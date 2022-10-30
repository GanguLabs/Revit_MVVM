using Autodesk.Revit.UI;
using Revit_MVVM.Core;
using Revit_MVVM.Res;
using Revit_MVVM.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit_MVVM
{
    public class SetupInterface
    {
        public SetupInterface(UIControlledApplication app)
        {
            Initialize(app);
        }

        public void Initialize(UIControlledApplication app)
        {
            string tabName = "Revit MVVM";
            app.CreateRibbonTab(tabName);

            var annotationCommandsPanel = app.CreateRibbonPanel(tabName, "Annotation Commands");
            var managerCommandsPanel = app.CreateRibbonPanel(tabName, "Family Manager Commands");

            RevitPushButtonDataModel TagWallButtonData = new RevitPushButtonDataModel
            {
                Label = "Tag Wall\nLayers",
                Panel = annotationCommandsPanel,
                Tooltip = "Tooltip of Revit MVVM plugin",
                CommandNamespacePath = TagWallLayersCommand.GetPath(),
                IconImageName = "revitLogo32.png",
                TooltipImageName = "revitLogo32.png"
            };

            var TagWallButton = RevitPushButton.Create(TagWallButtonData);

            var familyManagerShowButtonData = new RevitPushButtonDataModel
            {
                Label = "Show Family Manager",
                Panel = managerCommandsPanel,
                Tooltip = "Show Family Manager Window",
                CommandNamespacePath= ShowFamilyManagerCommand.GetPath(),
                IconImageName = "revitLogo32.png",
                TooltipImageName = "revitLogo32.png",
            };
            var familyManagerShowButton = RevitPushButton.Create(familyManagerShowButtonData);

            var familyManagerHideButtonData = new RevitPushButtonDataModel
            {
                Label = "Hide Family Manager",
                Panel = managerCommandsPanel,
                Tooltip = "Hide Family Manager Window",
                CommandNamespacePath = HideFamilyManagerCommand.GetPath(),
                IconImageName = "revitLogo32.png",
                TooltipImageName = "revitLogo32.png",
            };
            var familyManagerHideButton = RevitPushButton.Create(familyManagerHideButtonData);

        }
    }
}
