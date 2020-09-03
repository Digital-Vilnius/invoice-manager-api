using System;
using System.Collections.Generic;
using InvoiceManager.Dtos.Client;

namespace InvoiceManager.Dtos.Invoice
{
    public class InvoicesListItemDto : BaseDto
    {
        public string SerialNumber { get; set; }
        
        public ClientsListItemDto Client { get; set; }
        
        public DateTime DueDate { get; set; }
        
        public DateTime Date { get; set; }
        
        public string Notes { get; set; }
        
        public List<InvoicesListItemDto> InvoiceItems { get; set; }
    }
}