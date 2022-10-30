using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit_MVVM.Core
{
    public static class LengthUnitConverter
    {
        public static double ConvertToMetric(double value, LengthUnitType type, int decimals)
        {
            switch (type)
            {
                case LengthUnitType.millimeter:
                    return Math.Round(value * 304.8, decimals);
                case LengthUnitType.centimeter:
                    return Math.Round(value * 30.48, decimals);
                case LengthUnitType.decimeter:
                    return Math.Round(value * 3.048, decimals);
                case LengthUnitType.meter:
                    return Math.Round(value * 0.3048, decimals);
                case LengthUnitType.kilometer:
                    return Math.Round(value * 0.0003048, decimals);
                default:
                    return value;
            }
        }
    }
}
