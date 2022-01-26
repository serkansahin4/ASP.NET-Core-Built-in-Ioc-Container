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
    public class ReservationManager : IReservationService
    {
        private IReservationDal _reservationDal;
        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }
        public void Add(Reservation Reservation)
        {
            _reservationDal.Add(Reservation);
        }

        public void Delete(int id)
        {
            _reservationDal.Delete(_reservationDal.Get(x => x.Id == id));
        }

        public List<Reservation> GetAllReservations()
        {
            return _reservationDal.GetList();
        }

        public Reservation GetById(int id)
        {
            return _reservationDal.Get(x => x.Id == id);
        }

        public void Update(Reservation reservation)
        {
            _reservationDal.Update(reservation);
        }
    }
}
