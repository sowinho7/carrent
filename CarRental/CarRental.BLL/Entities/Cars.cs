using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Entities
{
    public class Cars
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string CarModel { get; set; }
        public DateTime ProdDate { get; set; }
        public int RentPrice { get; set; }
        public int Bail { get; set; }
        public int Doors { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public string Fuel { get; set; }
        public bool Clim { get; set; }
        public bool Navi { get; set; }
        public string DriveType { get; set; }
        public string Upholestry { get; set; }
        public int Horsepower { get; set; }
        public string Description { get; set; }
        public Rental Rent { get; set; }

    }
}
