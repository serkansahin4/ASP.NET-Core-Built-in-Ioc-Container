using DependencyInjectionOdev.Cinema.DataAccess.Abstract;
using DependencyInjectionOdev.Cinema.DataAccess.Concrete.EntityFramework.Context;
using DependencyInjectionOdev.Cinema.Entities.Concrete;
using DependencyInjectionOdev.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.DataAccess.Concrete.EntityFramework
{
    public class EfGenreDal:EfEntityRepositoryBase<Genre,CinemaContext>,IGenreDal
    {

    }
}
