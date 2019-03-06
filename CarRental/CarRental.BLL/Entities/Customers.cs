using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Entities
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string DocType { get; set; }
        public string DocNo { get; set; }
        public string CustCarBrand { get; set; }
        public string CustCarModel { get; set; }
        public DateTime CustCarProdDate { get; set; }
        public int CustCarCapacity { get; set; }
        public int CustCarHorsepower { get; set; }
        public string CustCarVin { get; set; }
        public string CustCarDescription { get; set; }
        public Invoices Invoice { get; set; }
        
        public Rental Rent  { get; set; }
        public Orders Order { get; set; }
    }
}
