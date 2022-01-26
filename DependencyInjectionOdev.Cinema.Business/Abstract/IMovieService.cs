using DependencyInjectionOdev.Cinema.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.Business.Abstract
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();
        Movie GetById(int id);
        void Update(Movie movie);
        void Delete(int id);
        void Add(Movie movie);
    }
}
