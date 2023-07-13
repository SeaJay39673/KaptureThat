using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;
using DynamicDisplay_ProofOfConcept.Models;

namespace DynamicDisplay_ProofOfConcept.Services
{
	public class KaptureItemJsonFileService
	{
		private string _jsonFileName;

		public KaptureItemJsonFileService(string jsonFileName)
		{
            _jsonFileName = jsonFileName;
		}

		public async Task<string> ReadFromFile()
		{
			using Stream filestream = await FileSystem.Current.OpenAppPackageFileAsync(_jsonFileName);
			using StreamReader reader = new StreamReader(filestream);
			return reader.ReadToEnd();
		}
		public ObservableCollection<KaptureBoardItemModel> GetKaptureBoardItems()
		{
			string json = ReadFromFile().Result;
			var content = JsonSerializer.Deserialize<ObservableCollection<KaptureBoardItemModel>>(json);
			return content;
		}
	}
}

