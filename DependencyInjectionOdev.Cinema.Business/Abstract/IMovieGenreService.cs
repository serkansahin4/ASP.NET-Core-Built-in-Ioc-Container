using DependencyInjectionOdev.Cinema.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.Business.Abstract
{
    public interface IMovieGenreService
    {
        List<MovieGenre> GetAllMovieGenres();
        MovieGenre GetById(int id);
        void Update(MovieGenre movieGenre);
        void Delete(int id);
        void Add(MovieGenre movieGenre);
    }
}
