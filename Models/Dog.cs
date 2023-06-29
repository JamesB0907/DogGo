using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DogGo.Models
{
    public class Dog
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Hmmm... You should really add a Name...")]
        [MaxLength(35)]
        public string Name { get; set; }
        public int OwnerId { get; set; }
        [Required(ErrorMessage = "Please enter a breed. Enter 'Mixed' if unsure.")]
        [MaxLength(35)]
        public string Breed { get; set; }
        public string Notes { get; set; }
        [DisplayName("Photo")]
        public string ImageUrl { get; set; }
        public Owner Owner { get; set; }
    }
}
