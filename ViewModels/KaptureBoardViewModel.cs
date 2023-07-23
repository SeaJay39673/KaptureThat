using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DynamicDisplay_ProofOfConcept.Models;
using DynamicDisplay_ProofOfConcept.Services;
namespace DynamicDisplay_ProofOfConcept.ViewModels
{
    public class KaptureBoardViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private KaptureItemJsonFileService _jsonFileService;
        private ObservableCollection<KaptureBoardItemModel> _kaptureBoardItems;
        public ObservableCollection<KaptureBoardItemModel> KaptureBoardItems
        {
            get => _kaptureBoardItems;
            set
            {
                _kaptureBoardItems = value;
                OnPropertyChanged();
            }
        }

        private Color _postOpacity;
        public Color PostOpacity
        {
            get => _postOpacity;
            set
            {
                _postOpacity = value;
                OnPropertyChanged();
            }
        }

        public ICommand NavigateToAccount { get; private set; }

        public KaptureBoardViewModel()
        {
            _jsonFileService = new("TestingKaptureBoardItems.json");
            _kaptureBoardItems = _jsonFileService.GetKaptureBoardItems();
            _postOpacity = new Color(255, 0, 0, (float).7);

            NavigateToAccount = new Command(async () => {
                await Shell.Current.GoToAsync("//AccountViewModel");
            });
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}