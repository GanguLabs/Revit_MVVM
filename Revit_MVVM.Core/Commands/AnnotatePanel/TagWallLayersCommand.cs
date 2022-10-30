using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
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
            UIDocument uiDoc = commandData.Application.ActiveUIDocument;
            Document doc = uiDoc.Document;

            // check if the current Revit File is a Project, not a Revit Family
            if (doc.IsFamilyDocument)
            {
                Message.Display("Cant use command in family document", WindowType.Warning);
                return Result.Cancelled;
            }

            View activeView = uiDoc.ActiveView;

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
                    Message.Display("This is an Elevation View.\nPlease make sure to set a Workplane to any of the wall faces", WindowType.Information);
                    canCreateTextNoteInView = true;
                    break;
            }

            if (!canCreateTextNoteInView)
            {
                Message.Display("Text Note element can't be created in current view", WindowType.Error);
                return Result.Cancelled;
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

            var pt = uiDoc.Selection.PickPoint("Pick location to place Text Note.");
            var layers = wall.WallType.GetCompoundStructure().GetLayers();

            var msg  = new StringBuilder();

            foreach (var layer in layers)
            {
                var material = doc.GetElement(layer.MaterialId) as Material;

                msg.AppendLine(layer.Function.ToString() + " " + material.Name + " " + layer.Width.ToString());
            }

            var textNoteOptions = new TextNoteOptions
            {
                VerticalAlignment = VerticalTextAlignment.Top,
                HorizontalAlignment = HorizontalTextAlignment.Left,
                TypeId =doc.GetDefaultElementTypeId(ElementTypeGroup.TextNoteType),
            };

            using (var transaction = new Transaction(doc))
            {
                transaction.Start("Tag Wall Layers Command");

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
