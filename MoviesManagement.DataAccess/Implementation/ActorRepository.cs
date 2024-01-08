using Microsoft.EntityFrameworkCore;
using MoviesManagement.DataAccess.Context;
using MoviesManagement.Domain.Entities;
using MoviesManagement.Domain.Enum;
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
            var data = _context.Actors.Include(a => a.Movies)
                .Include(b => b.Biography)
                .Where(a => a.RowStatus == (short)RowStatus.IsActive)
            .Select(a => new Actor
             {
                 ID = a.ID,
                 FirstName = a.FirstName,
                 LastName = a.LastName,
                 CreatedBy = a.CreatedBy,
                 Movies = a.Movies.Select(m => new Movie
                 {   
                     ID = m.ID,
                     MovieName = m.MovieName,
                     Description = m.Description,
                     Duration = m.Duration,
                     Rating = m.Rating,
                     ActorID = a.ID,
                     Genres = m.Genres.Select(g => new Genre
                     {
                         ID = g.ID,
                         GenreName = g.GenreName,
                         CreatedAt = g.CreatedAt,
                         UpdatedAt = g.UpdatedAt,
                         RowStatus = g.RowStatus
                     }).ToList(),
                     CreatedAt = m.CreatedAt,
                     UpdatedAt = m.UpdatedAt,
                     RowStatus = m.RowStatus

                 }).ToList(),
                 Biography = new Biography
                 {
                     ID = a.Biography.ID,
                     Description = a.Biography.Description,
                     Age = a.Biography.Age,
                     Gender = a.Biography.Gender,
                     ActorID = a.Biography.ActorID,
                 },
                 CreatedAt = a.CreatedAt,
                 UpdatedAt = a.UpdatedAt,
                 RowStatus = a.RowStatus
             }).ToList();


            return data;
        }    
    }
}
