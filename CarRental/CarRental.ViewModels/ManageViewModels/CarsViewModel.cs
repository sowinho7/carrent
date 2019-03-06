using CarRental.BLL.Entities;
using System.Collections.Generic;

namespace CarRental.ViewModels.ManageViewModels
{
    public class CarsViewModel
    {
        public Cars Car{ get; set; }
        public List<Cars> Carslist { get; set; }
    }
}
