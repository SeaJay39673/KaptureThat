using System;
using DynamicDisplay_ProofOfConcept.Models;
using DynamicDisplay_ProofOfConcept.Services;

namespace DynamicDisplay_ProofOfConcept.ViewModels
{
	public class KaptureBoardViewModel
	{

		private KaptureItemJsonFileService _jsonFileService;
		public IEnumerable<KaptureBoardItemModel> KaptureBoardItems;
		public KaptureBoardViewModel()
		{
			_jsonFileService = new("../Resources/Raw/TestingKaptureBoardItems.json");
			KaptureBoardItems = _jsonFileService.GetKaptureBoardItems();
		}
	}
}

