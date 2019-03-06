using CarRental.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Services.Interfaces
{
    public interface ICarsService
    {
        bool AddCar(Cars car);
        bool EditCar(Cars Car, int Id);
        bool DeleteCar(int Id);
        Cars GetCar(int Id);
        List<Cars> GetCar();
    }
}
