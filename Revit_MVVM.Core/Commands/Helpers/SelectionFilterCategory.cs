using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit_MVVM.Core
{
    public class SelectionFilterCategory : ISelectionFilter
    {
        private string mCategory = "";

        public SelectionFilterCategory(string category)
        {
            mCategory = category;
        }
        public bool AllowElement(Element elem)
        {
            if(elem.Category != null && elem.Category.Name == mCategory)
            {
                return true;
            }
            return false;
        }

        public bool AllowReference(Reference reference, XYZ position)
        {
            return false;
        }
    }
}
