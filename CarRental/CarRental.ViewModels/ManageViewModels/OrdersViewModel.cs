using CarRental.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.ViewModels.ManageViewModels
{
    public class OrdersViewModel
    {
        public Orders Order { get; set; }
        public List<Orders> OrderList { get; set; }

       

        public Customers Cust { get; set; }
        public List<Customers> CustList { get; set; }
    }
}
