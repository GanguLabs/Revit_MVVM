using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit_MVVM.Core
{
    public class TagWallLayersCommandData
    {
        public bool Function { get; set; }
        public bool Name { get; set; }
        public bool Thickness { get; set; }
        public ElementId TextTypeId { get; set; }

        public LengthUnitType UnitType { get; set; }

        public int Decimals { get; set; }

        public TagWallLayersCommandData()
        {

        }
    }
}
