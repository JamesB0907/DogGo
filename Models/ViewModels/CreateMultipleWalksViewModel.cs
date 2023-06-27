using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DogGo.Models.ViewModels
{
    public class CreateWalksViewModel
    {
        public List<Walker>? Walkers { get; set; }

        [Display(Name = "Select Walker")]
        public int SelectedWalkerId { get; set; }

        public List<Dog>? Dogs { get; set; }

        [Display(Name = "Select Dogs (Hold CTRL for multiple)")]
        public List<int>? SelectedDogIds { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Duration (in minutes)")]
        public int Duration { get; set; }
    }
}
