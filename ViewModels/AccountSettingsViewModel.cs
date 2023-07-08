using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DynamicDisplay_ProofOfConcept.ViewModels
{
    internal class AccountSettingsViewModel
    {
        public ICommand Logout { get; }
        public AccountSettingsViewModel() {
            Logout = new Command(async () => {
                await Shell.Current.GoToAsync(state: "//Login");
            });
        }
    }
}
