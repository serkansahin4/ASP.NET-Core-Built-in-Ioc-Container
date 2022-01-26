using DependencyInjectionOdev.Cinema.Business.Abstract;
using DependencyInjectionOdev.Cinema.Business.Concrete;
using DependencyInjectionOdev.Cinema.DataAccess.Abstract;
using DependencyInjectionOdev.Cinema.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IMovieGenreDal>().To<EfMovieGenreDal>().InSingletonScope();
            Kernel.Bind<IMovieGenreService>().To<MovieGenreManager>().InSingletonScope();

            Kernel.Bind<IReservationDal>().To<EfReservationDal>().InSingletonScope();
            Kernel.Bind<IReservationService>().To<ReservationManager>().InSingletonScope();

            Kernel.Bind<IGenreDal>().To<EfGenreDal>().InSingletonScope();
            Kernel.Bind<IGenreService>().To<GenreManager>().InSingletonScope();

            Kernel.Bind<IMovieDal>().To<EfMovieDal>().InSingletonScope();
            Kernel.Bind<IMovieService>().To<MovieManager>().InSingletonScope();
        }
    }
}
