using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Revit_MVVM.Core
{
    public static class CoreAssembly
    {
        public static string GetAssembly()
        {
            return Assembly.GetExecutingAssembly().Location;
        }
    }
}
