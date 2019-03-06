﻿using System.Diagnostics;
using DataAccessLayer.Core.Interfaces.UoW;
using CarRental.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CarRental.Web.Controllers
{

    public abstract class BaseController : Controller
    {
        protected readonly IUnitOfWork Uow;
        protected readonly ILogger Logger;
        protected BaseController(IUnitOfWork uow, ILoggerFactory loggerFactory)
        {
            Uow = uow;
            Logger = loggerFactory.CreateLogger<BaseController>();
        }

        // GET: /<controller>/
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        }
    }
}
