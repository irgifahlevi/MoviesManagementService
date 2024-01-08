using MoviesManagement.Domain.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Domain.Entities
{
    public class Biography : ModelBase
    {
        public int ID { get; set; }
        public string Description { get; set; } = string.Empty;
        public int? Age { get; set; }
        public string Gender { get; set; } = string.Empty;
        public int ActorID { get; set; }
        public Actor? Actor { get; set; }
    }
}
