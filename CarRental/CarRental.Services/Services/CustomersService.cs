using CarRental.BLL.Entities;
using CarRental.DAL.EF;
using CarRental.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Services.Services
{
        public class CustomersService : ICustomersService
    {
        private ApplicationDbContext<User, Role, int> _ctx;
        public CustomersService(ApplicationDbContext<User, Role, int> ctx)
        {
            _ctx = ctx;
        }
        public bool AddCustomer(Customers Customer)
        {
            try
            {
                _ctx.Customers.Add(Customer);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteCustomer(int Id)
        {
            try
            {
                var Customer = _ctx.Customers.Single(x => x.Id == Id);
                _ctx.Customers.Remove(Customer);
                _ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditCustomer(Customers Customer, int Id)
        {
            try
            {
                var OldCustomer = _ctx.Customers.Single(x => x.Id == Id);
                OldCustomer.Name = Customer.Name;
                OldCustomer.Surname = Customer.Surname;
                OldCustomer.Country = Customer.Country;
                OldCustomer.City = Customer.City;
                OldCustomer.Address = Customer.Address;
                OldCustomer.ZipCode = Customer.ZipCode;
                OldCustomer.DocType = Customer.DocType;
                OldCustomer.DocNo = Customer.DocNo;
                OldCustomer.CustCarBrand = Customer.CustCarBrand;
                OldCustomer.CustCarModel = Customer.CustCarModel;
                OldCustomer.CustCarProdDate = Customer.CustCarProdDate;
                OldCustomer.CustCarCapacity = Customer.CustCarCapacity;
                OldCustomer.CustCarHorsepower = Customer.CustCarHorsepower;
                OldCustomer.CustCarVin = Customer.CustCarVin;
                OldCustomer.CustCarDescription = Customer.CustCarDescription;
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Customers GetCustomer(int Id)
        {
            try
            {
                return _ctx.Customers.First(x => x.Id == Id);
            }
            catch (Exception)
            {
                return new Customers();
            }
        }

        public List<Customers> GetCustomer()
        {
            try
            {
                return _ctx.Customers.ToList();
            }
            catch (Exception)
            {
                return new List<Customers>();
            }
        }
    }
}
