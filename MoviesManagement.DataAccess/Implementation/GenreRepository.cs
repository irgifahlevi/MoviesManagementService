using MoviesManagement.DataAccess.Context;
using MoviesManagement.Domain.Entities;
using MoviesManagement.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.DataAccess.Implementation
{
    public class GenreRepository : GenericRepository<Genre> , IGenreRepository
    {
        public GenreRepository(MovieDbContext context) : base(context)
        {
            
        }
    }
}
