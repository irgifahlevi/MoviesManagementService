﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Domain.Entities
{
    internal class Movie
    {
        public  int ID  { get; set; }
        public string MovieName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public double Rating { get; set; } = 0.0;
        public int ActorID { get; set; }
        public Actor? Actor { get; set; }
        public List<Genre>? Genres { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public int RowStatus { get; set; } = 0;
    }
}
