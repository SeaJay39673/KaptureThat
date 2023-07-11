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

		public IEnumerable<KaptureBoardItemModel> GetKaptureBoardItems()
		{
			var test = FileSystem.Current.AppDataDirectory;
			using (var jsonFileReader = File.OpenText(_jsonFileName))
			{
				return JsonSerializer.Deserialize<KaptureBoardItemModel[]>(jsonFileReader.ReadToEnd());
			}
		}
	}
}

