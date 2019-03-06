using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.BLL.Entities;
using CarRental.Services.Interfaces;
using CarRental.ViewModels.ManageViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Web.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarsService _carsService;

        public CarsController(ICarsService carsService)
        {
            _carsService = carsService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            var model = _carsService.GetCar();
            
            return View(model);
        }
        [HttpGet]
        public IActionResult GetCar(int Id)
        {
           var model = _carsService.GetCar(Id);

            return View(model);
        }
        [HttpGet]
        public IActionResult AddCar()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddCar(Cars car)
        {
            _carsService.AddCar(car);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditCar(int id)
        {
            var model = _carsService.GetCar(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult EditCar( Cars car, int id)
        {
            _carsService.EditCar(car,id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteCar()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult DeleteCar( int id)
        {
            _carsService.DeleteCar(id);
            return RedirectToAction("Index");
        }

        public IActionResult CarRent()
        {
            return View();
        }
    }
}