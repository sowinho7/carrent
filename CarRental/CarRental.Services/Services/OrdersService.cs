using CarRental.BLL.Entities;
using CarRental.DAL.EF;
using CarRental.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Services.Services
{
    public class OrdersService : IOrdersService
    {

        private ApplicationDbContext<User, Role, int> _ctx;
        public OrdersService(ApplicationDbContext<User, Role, int> ctx)
        {
            _ctx = ctx;
        }
        public bool AddOrder(Orders Order)
        {
            try
            {
                _ctx.Orders.Add(Order);
                _ctx.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
      

        public bool DeleteOrder(int Id)
        {
            try
            {
                var Order = _ctx.Orders.Single(x => x.Id == Id);
                _ctx.Orders.Remove(Order);
                _ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditOrder(Orders Order, int Id)
        {
            try
            {
                var OldOrder = _ctx.Orders.Single(x => x.Id == Id);
                OldOrder.ServiceNo = Order.ServiceNo;
                OldOrder.CustId = Order.CustId;
                OldOrder.ServiceType = Order.ServiceType;
                OldOrder.Parking = Order.Parking;
                OldOrder.Price = Order.Price;
                OldOrder.Date = Order.Date;
                OldOrder.Description = Order.Description;
                OldOrder.Date2 = Order.Date2;
                OldOrder.Description2 = Order.Description2;
                OldOrder.Date3 = Order.Date3;
                OldOrder.Description3 = Order.Description3;
                OldOrder.Date4 = Order.Date4;
                OldOrder.Description4 = Order.Description4;
                OldOrder.Date5 = Order.Date5;
                OldOrder.Description5 = Order.Description5;
                OldOrder.Date6 = Order.Date6;
                OldOrder.Description6 = Order.Description6;
                OldOrder.Date7 = Order.Date7;
                OldOrder.Description7 = Order.Description7;
                OldOrder.Date8 = Order.Date8;
                OldOrder.Description8 = Order.Description8;
                OldOrder.Date9 = Order.Date9;
                OldOrder.Description9 = Order.Description9;
                OldOrder.Date10 = Order.Date10;
                OldOrder.Description10 = Order.Description10;

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
                return _ctx.Customers.Single(x => x.Id == Id);
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

        

        

        public Orders GetOrder(int Id)
        {
            try
            {
                return _ctx.Orders.Single(x => x.Id == Id);
            }
            catch (Exception)
            {
                return new Orders();
            }
        }

        public List<Orders> GetOrder()
        {
            try
            {
                return _ctx.Orders.ToList();
            }
            catch (Exception)
            {
                return new List<Orders>();
            }
        }

        public Orders GetOrderByNo(string ServiceNo)
        {
            try
            {
                return _ctx.Orders.FirstOrDefault(x => x.ServiceNo == ServiceNo);//x.ServiceNo == ServiceNo);//single
            }
            catch (Exception)
            {
                return new Orders();
            }
        }
    }
}
