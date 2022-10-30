using Autodesk.Revit.UI;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;


namespace Revit_MVVM.UI
{
    /// <summary>
    /// Interaction logic for FamilyManagerMainPage.xaml
    /// </summary>
    [ContentProperty("Content")]
    public partial class FamilyManagerMainPage : Page, IDisposable, IDockablePaneProvider
    {
        public FamilyManagerMainPage()
        {
            InitializeComponent();
        }

        public void Dispose()
        {
            this.Dispose();
        }

        public void SetupDockablePane(DockablePaneProviderData data)
        {
            data.FrameworkElement = this as FrameworkElement;

            data.InitialState = new DockablePaneState
            {
                DockPosition = DockPosition.Right,
            };
        }
    }
}
