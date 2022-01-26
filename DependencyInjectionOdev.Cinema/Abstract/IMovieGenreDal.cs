using DependencyInjectionOdev.Cinema.Entities.ComplexType;
using DependencyInjectionOdev.Core.DataAccess;
using DependencyInjectionOdev.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.DataAccess.Abstract
{
    public interface IMovieGenreDal:IEntityRepository<MovieGenre>
    {
    }
}
