using Microsoft.EntityFrameworkCore;
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
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(MovieDbContext context) : base (context)
        {
            
        }

        public IEnumerable<Actor> GetActors()
        {
            var data = _context.Actors.Include(a => a.Movies).Include(b => b.Biography).Where(a => a.RowStatus == 0).ToList();
            return data;
        }
    }
}
