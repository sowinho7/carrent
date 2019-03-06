using CarRental.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Services.Interfaces
{
    public interface IInvoicesService
    {
        bool AddInvoice(Invoices Invoice);
        bool EditInvoice(Invoices Invoice, int Id);
        bool DeleteInvoice(int Id);
        Invoices GetInvoice(int Id);
        List<Invoices> GetInvoice();
    }
}
