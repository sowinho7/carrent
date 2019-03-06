using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.BLL.Entities;
using CarRental.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomersService _customersService;

        public CustomersController(ICustomersService customersService)
        {
            this._customersService = customersService;
        }

        public IActionResult Index()
        {
            var model = _customersService.GetCustomer();

            return View(model);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customers customer)
        {
            _customersService.AddCustomer(customer);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCustomer(int id)
        {
            var model = _customersService.GetCustomer(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult EditCustomer(int id, Customers customer)
        {
            _customersService.EditCustomer(customer, id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteCustomer()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult DeleteCustomer(int id)
        {
            _customersService.DeleteCustomer(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult GetCustomer (int Id)
        {
            var model = _customersService.GetCustomer(Id);

            return View(model);
        }

    }
}