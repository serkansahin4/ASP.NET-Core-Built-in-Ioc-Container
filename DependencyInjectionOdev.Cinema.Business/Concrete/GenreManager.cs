using DependencyInjectionOdev.Cinema.Business.Abstract;
using DependencyInjectionOdev.Cinema.DataAccess.Abstract;
using DependencyInjectionOdev.Cinema.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.Business.Concrete
{
    public class GenreManager:IGenreService
    {
        private IGenreDal _genreDal;
        public GenreManager(IGenreDal genreDal)
        {
            _genreDal = genreDal;
        }
        public void Add(Genre genre)
        {
            _genreDal.Add(genre);
        }

        public void Delete(int id)
        {
            _genreDal.Delete(_genreDal.Get(x => x.Id == id));
        }

        public List<Genre> GetAllGenres()
        {
            return _genreDal.GetList();
        }

        public Genre GetById(int id)
        {
            return _genreDal.Get(x => x.Id == id);
        }

        public void Update(Genre genre)
        {
            _genreDal.Update(genre);
        }
    }
}
