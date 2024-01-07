using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Domain.Entities
{
    internal class Genre
    {
        public int ID { get; set; }
        public string GenreName { get; set; } = string.Empty;
        public List<Movie>? Movies { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public int RowStatus { get; set; } = 0;
    }
}
