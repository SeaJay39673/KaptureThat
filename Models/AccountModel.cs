using System;
using System.Collections.ObjectModel;

namespace DynamicDisplay_ProofOfConcept.Models
{
    public class AccountModel
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public Byte[] ProfilePicture { get; set; }
        public ObservableCollection<KaptureBoardItemModel> Posts { get; set; }

        public AccountModel(string name, string bio, Byte[] profilePicture, ObservableCollection<KaptureBoardItemModel> posts)
        {
            Name = name;
            Bio = bio;
            ProfilePicture = profilePicture;
            Posts = posts;
        }
    }
}

