﻿using System.Collections.Generic;

namespace DogGo.Models
{
    public class Walk
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public int WalkerId { get; set; }
        public Walker Walker { get; set; }
        public List<Dog> Dogs { get; set; }
        public int DogId { get; set; }
    }
}