using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revit_MVVM.Core
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    public class TagWallLayersCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Document doc = uiDoc.Document;

            // check if the current Revit File is a Project, not a Revit Family
            if (doc.IsFamilyDocument)
            {
                Message.Display("Cant use command in family document", WindowType.Warning);
                return Result.Cancelled;
            }

            Autodesk.Revit.DB.View activeView = uiDoc.ActiveView;

            bool canCreateTextNoteInView = false;

            switch (activeView.ViewType)
            {
                case ViewType.FloorPlan:
                    canCreateTextNoteInView = true;
                    break;
                case ViewType.CeilingPlan:
                    canCreateTextNoteInView = true;
                    break;
                case ViewType.Detail:
                    canCreateTextNoteInView = true;
                    break;
                case ViewType.Elevation:
                    canCreateTextNoteInView = true;
                    break;
                case ViewType.Section:
                    canCreateTextNoteInView = true;
                    break;
            }

            var userInfo = new TagWallLayersCommandData();

            if (!canCreateTextNoteInView)
            {
                Message.Display("Text Note element can't be created in current view", WindowType.Error);
                return Result.Cancelled;
            }

            using (var window = new TagWallLayersForm(uiDoc))
            {
                window.ShowDialog();

                if (window.DialogResult == DialogResult.Cancel)
                {
                    return Result.Cancelled;
                }

                userInfo = window.GetInformaion();
            }

            var selFilter = new SelectionFilterCategory("Walls");
            var selectionReference = uiDoc.Selection.PickObject(ObjectType.Element, selFilter, "Select one basic wall.");
            Element selectionElement = doc.GetElement(selectionReference);

            Wall wall = selectionElement as Wall;

            if (wall.IsStackedWall)
            {
                Message.Display("Wall you selectced is of category Stacked Wall.\nIt's not supported byy this command.", WindowType.Warning);
                return Result.Cancelled;
            }

            var layers = wall.WallType.GetCompoundStructure().GetLayers();

            var msg = new StringBuilder();

            foreach (var layer in layers)
            {
                var material = doc.GetElement(layer.MaterialId) as Material;

                msg.AppendLine();

                if (userInfo.Function)
                    msg.Append(layer.Function.ToString());

                if (userInfo.Name)
                    msg.Append(" " + material.Name);

                if (userInfo.Thickness)
                    msg.Append(" " + layer.Width.ToString());
            }

            var textNoteOptions = new TextNoteOptions
            {
                VerticalAlignment = VerticalTextAlignment.Top,
                HorizontalAlignment = HorizontalTextAlignment.Left,
                TypeId = userInfo.TextTypeId,
            };

            using (var transaction = new Transaction(doc))
            {
                transaction.Start("Tag Wall Layers Command");

                if (activeView.ViewType == ViewType.Elevation || activeView.ViewType == ViewType.Section)
                {
                    var plane = Plane.CreateByNormalAndOrigin(activeView.ViewDirection, activeView.Origin);
                    var sketchPlane = SketchPlane.Create(doc, plane);
                    activeView.SketchPlane = sketchPlane;
                }
                var pt = uiDoc.Selection.PickPoint("Pick location to place Text Note.");

                var textNote = TextNote.Create(doc, activeView.Id, pt, msg.ToString(), textNoteOptions);

                transaction.Commit();
            }

            return Result.Succeeded;
        }

        public static string GetPath()
        {
            return typeof(TagWallLayersCommand).Namespace + "." + nameof(TagWallLayersCommand);
        }
    }
}
