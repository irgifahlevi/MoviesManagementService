using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesManagement.Domain.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        IActorRepository Actor { get; }
        IBiographyRepository Biography { get; }
        IMovieRepository Movie { get; }
        IGenreRepository Genre { get; }
        int Save();
    }
}
