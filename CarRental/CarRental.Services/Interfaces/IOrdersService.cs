using CarRental.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Services.Interfaces
{
    public interface IOrdersService
    {
        bool AddOrder(Orders Order);
        bool EditOrder(Orders Order, int Id);
        bool DeleteOrder(int Id);
        Customers GetCustomer(int Id);
        Orders GetOrder(int Id);

        Orders GetOrderByNo(string ServiceNo);
        
        List<Orders> GetOrder();
        List<Customers> GetCustomer();
       
    }
}
