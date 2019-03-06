using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRental.BLL.Entities;
using CarRental.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Web.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly IInvoicesService _invoicesService;
        
        public InvoicesController(IInvoicesService invoicesService)
        {
            this._invoicesService = invoicesService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddInvoice()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInvoice(Invoices invoice)
        {
           _invoicesService.AddInvoice(invoice);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult EditInvoice( int id)
        {
            var model = _invoicesService.GetInvoice(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult EditInvoice(Invoices invoice, int id)
        {
            _invoicesService.EditInvoice(invoice, id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult DeleteInvoice(int id)
        {
            _invoicesService.DeleteInvoice(id);
            return RedirectToAction("Index");
        }
    }
}