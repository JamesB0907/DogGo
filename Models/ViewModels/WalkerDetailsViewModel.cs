using DogGo.Models;
using System.Collections.Generic;

namespace DogGo.Models.ViewModels
{
    public class WalkerDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NeighborhoodId { get; set; }
        public string ImageUrl { get; set; }
        public List<Walk> Walks { get; set; }
    }
}
