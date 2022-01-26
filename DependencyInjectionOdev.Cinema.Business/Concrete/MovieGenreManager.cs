using DependencyInjectionOdev.Cinema.Business.Abstract;
using DependencyInjectionOdev.Cinema.DataAccess.Abstract;
using DependencyInjectionOdev.Cinema.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.Business.Concrete
{
    public class MovieGenreManager:IMovieGenreService
    {
        private IMovieGenreDal _movieGenreDal;
        public MovieGenreManager(IMovieGenreDal movieGenreDal)
        {
            _movieGenreDal = movieGenreDal;
        }
        public void Add(MovieGenre movieGenre)
        {
            _movieGenreDal.Add(movieGenre);
        }

        public void Delete(int id)
        {
            _movieGenreDal.Delete(_movieGenreDal.Get(x => x.Id == id));
        }

        public List<MovieGenre> GetAllMovieGenres()
        {
            return _movieGenreDal.GetList();
        }

        public MovieGenre GetById(int id)
        {
            return _movieGenreDal.Get(x => x.Id == id);
        }

        public void Update(MovieGenre movieGenre)
        {
            _movieGenreDal.Update(movieGenre);
        }
    }
}
