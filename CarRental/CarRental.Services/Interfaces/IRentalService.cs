using CarRental.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Services.Interfaces
{
    public interface IRentalService
    {
        bool AddRent(Rental Rent);
        bool EditRent(Rental Rent, int Id);
        bool DeleteRent(int Id);
        Rental GetRent(int Id);
        List<Rental> GetRent();
    }
}
