using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.Specialized;
using DynamicDisplay_ProofOfConcept.Models;
using System.Windows.Input;

namespace DynamicDisplay_ProofOfConcept.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        private LoginModel loginModel = new LoginModel();
        public LoginModel LoginModel
        {
            get { return loginModel; }
            set
            {
                loginModel = value;
                OnPropertyChanged(nameof(LoginModel));
            }
        }
        public ICommand Login { get; }
        public LoginViewModel()
        {
            Login = new Command(async (object obj) =>
            {
                // Perform API operation/ DB operation
                var data = LoginModel;

                await Shell.Current.GoToAsync(state: "//KaptureBoard");
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
