using MoviesManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Domain.Repository
{
    public interface IMovieRepository : IGenericRepository<Movie>
    {
    }
}
