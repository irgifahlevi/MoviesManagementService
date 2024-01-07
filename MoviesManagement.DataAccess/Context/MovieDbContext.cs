using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesManagement.Domain.Entities;

namespace MoviesManagement.DataAccess.Context
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext>options) : base(options)
        {
            
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Biography> Biographies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor { ID = 1, FirstName = "Johan", LastName = "Malik", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "SYSTEM", RowStatus = 0},
                new Actor { ID = 2, FirstName = "Hannah", LastName = "Lakley", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "SYSTEM", RowStatus = 0 }
                );

            modelBuilder.Entity<Biography>().HasData(
                new Biography { ID = 1, ActorID = 1, Age = 34, Gender = "Male", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "SYSTEM", RowStatus = 0 },
                new Biography { ID = 2, ActorID = 2, Age = 28, Gender = "Female", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "SYSTEM", RowStatus = 0 }
                );
            modelBuilder.Entity<Movie>().HasData(
                new Movie { ID = 1, ActorID = 1, MovieName = "Avatar", Description = "The legend movies", Duration = "2 Hours", Rating = 4.9, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "SYSTEM", RowStatus = 0 },
                new Movie { ID = 2, ActorID = 1, MovieName = "Transformers 3", Description = "In The End", Duration = "1 Hours", Rating = 4.5, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "SYSTEM", RowStatus = 0 },
                new Movie { ID = 3, ActorID = 2, MovieName = "Umbrella", Description = "Zombie world war", Duration = "1.5 Hours", Rating = 4.3, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "SYSTEM", RowStatus = 0 },
                new Movie { ID = 5, ActorID = 2, MovieName = "No Party No Hapy", Description = "The collection funny movies", Duration = "2 Hours", Rating = 4.9, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = "SYSTEM", RowStatus = 0 }
                );
        }
    }
}
