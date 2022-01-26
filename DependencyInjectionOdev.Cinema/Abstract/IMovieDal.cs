using DependencyInjectionOdev.Cinema.DataAccess.Concrete.EntityFramework.Context;
using DependencyInjectionOdev.Cinema.Entities.Concrete;
using DependencyInjectionOdev.Core.DataAccess;
using DependencyInjectionOdev.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.DataAccess.Abstract
{
    public interface IMovieDal:IEntityRepository<Movie>
    {
    }
}
