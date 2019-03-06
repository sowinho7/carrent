using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.BLL.Entities;
using CarRental.Services.Interfaces;
using CarRental.ViewModels.ManageViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersService _ordersService;
        

      
        public OrdersController(IOrdersService ordersService )
        {
            this._ordersService = ordersService;
            
        }
        public IActionResult Index()
        {
            OrdersViewModel model = new OrdersViewModel() {
                OrderList = _ordersService.GetOrder()
        };
         
            return View(model);
        }
        [HttpGet]
        public IActionResult GetOrder(int Id)
        {
            var model = new OrdersViewModel();
            model.Order=_ordersService.GetOrder(Id);
            model.Cust = _ordersService.GetCustomer(model.Order.CustId);
            

            return View(model);
        }
        
            
        
        [HttpGet]
        public IActionResult AddOrder()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddOrder(Orders order)
        {
            _ordersService.AddOrder(order);
            return RedirectToAction("Index");
        }

       
      

        [HttpGet]
        public IActionResult EditOrder(int id)
        {
            var model = new OrdersViewModel(); 
              model.Order = _ordersService.GetOrder(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult EditOrder(Orders order, int id)
        {
            _ordersService.EditOrder(order, id);
            return RedirectToAction("Index");
        }

        
       
       

        [HttpGet]
        public ActionResult DeleteOrder()
        {
            return View();
        }
        //[HttpPost]
        public IActionResult DeleteOrder(int id)
        {
            _ordersService.DeleteOrder(id);
            return RedirectToAction("Index");
        }
        
        public ActionResult OrderInfo()
        {
            return View();
        }
        [HttpGet]
        public ActionResult OrderInfoView(string ServiceNo)
        {
            var model = new OrdersViewModel();
            model.Order = _ordersService.GetOrderByNo(ServiceNo);
            return PartialView("szukaj", model);
        }
    }
}