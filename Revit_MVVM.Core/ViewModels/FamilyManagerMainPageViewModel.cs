using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Revit_MVVM.Core
{
    public class FamilyManagerMainPageViewModel : BaseViewModel
    {

        public ApplicationPageType CurrentPage { get; set; } = ApplicationPageType.Family;

        public ICommand FamilyBtnCommand { get; set; }
        public ICommand PreferencesBtnCommand { get; set; }

        public FamilyManagerMainPageViewModel()
        {
            FamilyBtnCommand = new RouteCommands(() => CurrentPage = ApplicationPageType.Family);
            PreferencesBtnCommand = new RouteCommands(() => CurrentPage = ApplicationPageType.Preferences);
        }

        private void FamilyBtnExec()
        {
            Message.Display("Family Button Clicked", WindowType.Information);
        }
        private void PreferencesBtnExec()
        {
            Message.Display("Preferences Button Clicked", WindowType.Information);
        }
    }
}
