using System;
using System.Collections.ObjectModel;

namespace DynamicDisplay_ProofOfConcept.Models
{
	public class AccountModel
	{
		string Name { get; set; }
		string Bio { get; set; }
		ImageSource ProfilePicture { get; set; }
		ObservableCollection<KaptureBoardItemModel> Posts { get; set; }

		public AccountModel(string name, string bio, ImageSource profilePicture, ObservableCollection<KaptureBoardItemModel> posts)
		{
			Name = name;
			Bio = bio;
			ProfilePicture = profilePicture;
			Posts = posts;
		}
	}
}

