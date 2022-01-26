using DependencyInjectionOdev.Cinema.Business.Abstract;
using DependencyInjectionOdev.Cinema.DataAccess.Abstract;
using DependencyInjectionOdev.Cinema.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.Business.Concrete
{
    public class MovieManager : IMovieService
    {
        private IMovieDal _movieDal;
        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }
        public void Add(Movie movie)
        {
            _movieDal.Add(movie);
        }

        public void Delete(int id)
        {
            _movieDal.Delete(_movieDal.Get(x=>x.Id==id));
        }

        public List<Movie> GetAllMovies()
        {
            return _movieDal.GetList();
        }

        public Movie GetById(int id)
        {
            return _movieDal.Get(x => x.Id == id);
        }

        public void Update(Movie movie)
        {
            _movieDal.Update(movie);
        }
    }
}
