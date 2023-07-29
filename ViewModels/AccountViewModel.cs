using DynamicDisplay_ProofOfConcept.Models;
using DynamicDisplay_ProofOfConcept.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DynamicDisplay_ProofOfConcept.ViewModels
{
    class AccountViewModel : INotifyPropertyChanged
    {
        private KaptureItemJsonFileService _jsonFS;
        public event PropertyChangedEventHandler PropertyChanged;
        private AccountModel _account;

        public AccountModel Account
        {
            get => _account;
            set
            {
                _account = value;
                OnPropertyChanged();
            }
        }

        public double ItemWidth { get; set; }

        public AccountViewModel()
        {
            _jsonFS = new KaptureItemJsonFileService("TestingKaptureBoardItems.json");
            _account = new AccountModel("Kyler Legault",
                "I like betta fish a lot. Let's look at some plants, baby!",
                ImageSource.FromFile("profile.webp"),
                _jsonFS.GetKaptureBoardItems());
            ItemWidth = getScreenWidth() / 4;
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public double getScreenWidth()
        {
            return DeviceDisplay.Current.MainDisplayInfo.Width / DeviceDisplay.Current.MainDisplayInfo.Density;
        }
    }
}
