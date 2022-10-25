using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Media.Imaging;

namespace Revit_MVVM.Res
{
    public static class ResourceImage
    {
        public static BitmapImage GetIcon(string name)
        {
            var stream = ResourceAssembly.GetAssembly().GetManifestResourceStream(ResourceAssembly.GetNamespace() + ".Images.Icons." + name);

            var image = new BitmapImage();

            image.BeginInit();
            image.StreamSource = stream;
            image.EndInit();

            return image;
        }
    }
}
