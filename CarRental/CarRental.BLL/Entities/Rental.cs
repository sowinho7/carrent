using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarRental.BLL.Entities
{
    public class Rental
    {
        [Key]
        public int Id { get; set; }
        
        public int CarId { get; set; }

        public int CustId { get; set; }
        public DateTime RentStart { get; set; }
        public DateTime RentFinish { get; set; }

        [Required]
        public string RentType { get; set; }
        public int Price { get; set; }

        public ICollection<Cars> Car { get; set; }
        public ICollection<Customers> Customer { get; set; }
    }
}
