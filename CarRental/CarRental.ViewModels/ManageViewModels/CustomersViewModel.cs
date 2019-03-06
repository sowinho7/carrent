using CarRental.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.ViewModels.ManageViewModels
{
    public class CustomersViewModel
    {
        public Customers Customer { get; set; }
        public List<Customers> Customerslist { get; set; }
    }
}
