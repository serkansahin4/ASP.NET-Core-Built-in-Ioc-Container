using DependencyInjectionOdev.Cinema.DataAccess.Abstract;
using DependencyInjectionOdev.Cinema.DataAccess.Concrete.EntityFramework.Context;
using DependencyInjectionOdev.Cinema.Entities.ComplexType;
using DependencyInjectionOdev.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.DataAccess.Concrete.EntityFramework
{
    public class EfMovieGenreDal: EfEntityRepositoryBase<MovieGenre, CinemaContext>,IMovieGenreDal
    {
    }
}
