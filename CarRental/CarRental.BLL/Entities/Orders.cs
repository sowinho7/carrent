using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public string ServiceNo { get; set; }
      
        public int CustId { get; set; }
        public string ServiceType { get; set; }
        public bool Parking { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public DateTime Date2 { get; set; }
        public string Description2 { get; set; }
        public DateTime Date3 { get; set; }
        public string Description3 { get; set; }
        public DateTime Date4 { get; set; }
        public string Description4 { get; set; }
        public DateTime Date5 { get; set; }
        public string Description5 { get; set; }
        public DateTime Date6 { get; set; }
        public string Description6 { get; set; }
        public DateTime Date7 { get; set; }
        public string Description7 { get; set; }
        public DateTime Date8 { get; set; }
        public string Description8 { get; set; }
        public DateTime Date9 { get; set; }
        public string Description9 { get; set; }
        public DateTime Date10 { get; set; }
        public string Description10 { get; set; }






        public ICollection<Customers> Customer { get; set; } 
        
    }
}
