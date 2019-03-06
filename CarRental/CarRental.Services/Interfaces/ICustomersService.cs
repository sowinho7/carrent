using CarRental.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Services.Interfaces
{
    public interface ICustomersService
    {
        bool AddCustomer(Customers Customer);
        bool EditCustomer(Customers Customer, int Id);
        bool DeleteCustomer(int Id);
        Customers GetCustomer(int Id);
        List<Customers> GetCustomer();
    }
}
