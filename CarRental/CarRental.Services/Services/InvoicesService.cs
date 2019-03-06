using CarRental.BLL.Entities;
using CarRental.DAL.EF;
using CarRental.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRental.Services.Services
{
     public class InvoicesService : IInvoicesService
    {
        private ApplicationDbContext<User, Role, int> _ctx;
        public InvoicesService(ApplicationDbContext<User, Role, int> ctx)
        {
            _ctx = ctx;
        }
        public bool AddInvoice(Invoices Invoice)
        {
            try
            {
                _ctx.Invoices.Add(Invoice);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteInvoice(int Id)
        {
            try
            {
                var Invoice = _ctx.Invoices.Single(x => x.Id == Id);
                _ctx.Invoices.Remove(Invoice);
                _ctx.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditInvoice(Invoices Invoice, int Id)
        {
            try
            {
                var OldInvoice = _ctx.Invoices.Single(x => x.Id == Id);
                OldInvoice.CustId = Invoice.CustId;
                OldInvoice.InvoiceNo = Invoice.InvoiceNo;
                OldInvoice.InvoiceDate = Invoice.InvoiceDate;
                OldInvoice.Description = Invoice.Description;
                OldInvoice.Price = Invoice.Price;
                OldInvoice.PaymentDate = Invoice.PaymentDate;


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Invoices GetInvoice(int Id)
        {
            try
            {
                return _ctx.Invoices.Single(x => x.Id == Id);
            }
            catch (Exception)
            {
                return new Invoices();
            }
        }

        public List<Invoices> GetInvoice()
        {
            try
            {
                return _ctx.Invoices.ToList();
            }
            catch (Exception)
            {
                return new List<Invoices>();
            }
        }
    }
}
