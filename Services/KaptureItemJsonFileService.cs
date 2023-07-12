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

		public ObservableCollection<KaptureBoardItemModel> GetKaptureBoardItems()
		{
            string content = @"[
                {
                  ""Title"": ""My First Kapture!"",
                  ""Classification"": ""Tiger"",
                  ""ID"": 1,
                  ""TimePosted"": ""2023-07-09T10:41:52.501Z""
                },
                {
                  ""Title"": ""My Second Kapture!"",
                  ""Classification"": ""Basil"",
                  ""ID"": 2,
                  ""TimePosted"": ""2023-07-09T10:41:52.501Z""
                },
                {
                  ""Title"": ""I'm really proud of this one..."",
                  ""Classification"": ""BettaFish"",
                  ""ID"": 3,
                  ""TimePosted"": ""2023-07-09T10:41:52.501Z""
                }
            ]
            ";

            return JsonSerializer.Deserialize<ObservableCollection<KaptureBoardItemModel>>(content);
			
		}
	}
}

