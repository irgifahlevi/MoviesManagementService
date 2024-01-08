using MoviesManagement.Domain.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Domain.Entities
{
    public class Genre : ModelBase
    {
        public int ID { get; set; }
        public string GenreName { get; set; } = string.Empty;
        public List<Movie>? Movies { get; set; }
    }
}
