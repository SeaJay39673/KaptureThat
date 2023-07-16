using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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

        public KaptureBoardViewModel()
        {
            _jsonFileService = new("../Resources/Raw/TestingKaptureBoardItems.json");
            _jsonFileService = new("TestingKaptureBoardItems.json");
            _kaptureBoardItems = _jsonFileService.GetKaptureBoardItems();
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}