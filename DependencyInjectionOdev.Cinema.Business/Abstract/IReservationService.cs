using DependencyInjectionOdev.Cinema.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionOdev.Cinema.Business.Abstract
{
    public interface IReservationService
    {
        List<Reservation> GetAllReservations();
        Reservation GetById(int id);
        void Update(Reservation reservation);
        void Delete(int id);
        void Add(Reservation reservation);
    }
}
