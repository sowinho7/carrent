using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.BLL.Entities
{
    public class Invoices
    {
        public int Id { get; set; }
        public int CustId { get; set; }
        public int InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime PaymentDate { get; set; }
        public ICollection<Customers> Customer { get; set; }
    }
}
