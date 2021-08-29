﻿using ProArch.CodingTest.DataModel;
using ProArch.CodingTest.InterfaceRepo;

namespace ProArch.CodingTest.Invoices
{
    public class FailoverInvoiceService : IFailoverInvoiceService
    {
        public FailoverInvoiceCollection GetInvoices(int supplierId)
        {
            return new FailoverInvoiceCollection();
        }
    }
}
