
using CarRental.BLL.Entities;
using CarRental.DAL.EF;
using CarRental.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Services.Services
{
    public class CarsService: ICarsService
    {
        private ApplicationDbContext<User, Role, int> _ctx;
        public CarsService(ApplicationDbContext<User, Role,int> ctx)
        {
            _ctx = ctx;
        }
        public bool AddCar(Cars Car)
        {
            try
            {
                _ctx.Cars.Add(Car);
                _ctx.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool DeleteCar(int Id)
        {
            try
            {
                var Car = _ctx.Cars.Single(x => x.Id == Id);
                _ctx.Cars.Remove(Car);
                _ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditCar(Cars Car, int Id)
        {
            try
            {
                var OldCar = _ctx.Cars.Single(x => x.Id == Id);
                OldCar.Brand = Car.Brand;
                OldCar.CarModel = Car.CarModel;
                OldCar.ProdDate = Car.ProdDate;
                OldCar.RentPrice = Car.RentPrice;
                OldCar.Bail = Car.Bail;
                OldCar.Doors = Car.Doors;
                OldCar.Type = Car.Type;
                OldCar.Capacity = Car.Capacity;
                OldCar.Fuel = Car.Fuel;
                OldCar.Clim = Car.Clim;
                OldCar.Navi = Car.Navi;
                OldCar.DriveType = Car.DriveType;
                OldCar.Upholestry = Car.Upholestry;
                OldCar.Horsepower = Car.Horsepower;
                OldCar.Description = Car.Description;
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Cars GetCar(int Id)
        {
            try
            {
                return _ctx.Cars.First(x => x.Id == Id);
            }
            catch(Exception)
            {
                return new Cars();
            }
        }

        public List<Cars> GetCar()
        {
            try
            {
                return _ctx.Cars.ToList();
            }
            catch(Exception)
            {
                return new List<Cars>();
            }
        }
    }
}
