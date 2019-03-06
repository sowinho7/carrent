using CarRental.BLL.Entities;
using CarRental.DAL.EF;
using CarRental.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Services.Services
{
    public class RentalService : IRentalService
    {
        private ApplicationDbContext<User, Role, int> _ctx;
        public RentalService(ApplicationDbContext<User, Role, int> ctx)
        {
            _ctx = ctx;
        }
        public bool AddRent(Rental Rent)
        {
            try
            {
                _ctx.Rental.Add(Rent);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteRent(int Id)
        {
            try
            {
                var Rent = _ctx.Rental.Single(x => x.Id == Id);
                _ctx.Rental.Remove(Rent);
                _ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditRent(Rental Rent, int Id)
        {
            try
            {
                var OldRent = _ctx.Rental.Single(x => x.Id == Id);
                OldRent.CarId = Rent.CarId;
                OldRent.CustId = Rent.CustId;
                OldRent.RentStart = Rent.RentStart;
                OldRent.RentFinish = Rent.RentFinish;
                OldRent.RentType = Rent.RentType;
                OldRent.Price = Rent.Price;

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Rental GetRent(int Id)
        {
            try
            {
                return _ctx.Rental.Single(x => x.Id == Id);
            }
            catch (Exception)
            {
                return new Rental();
            }
        }

        public List<Rental> GetRent()
        {
            try
            {
                return _ctx.Rental.ToList();
            }
            catch (Exception)
            {
                return new List<Rental>();
            }
        }
    }
}
