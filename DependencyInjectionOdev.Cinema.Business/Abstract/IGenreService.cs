using DependencyInjectionOdev.Cinema.Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.Business.Abstract
{
    public interface IGenreService
    {
        List<Genre> GetAllGenres();
        Genre GetById(int id);
        void Update(Genre genre);
        void Delete(int id);
        void Add(Genre genre);

    }
}
