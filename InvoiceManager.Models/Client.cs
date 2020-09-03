using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManager.Models
{
    public class Client : BaseModel
    {
        [Required]
        public string Name { get; set; }
        
        public string VatCode { get; set; }
        
        [Required]
        public string Code { get; set; }
        
        [Required]
        public string Address { get; set; }
        
        public string Email { get; set; }
        
        public string Phone { get; set; }
        
        [Required]
        public int AccountId { get; set; }
        public Account Account { get; set; }
        
        public List<Invoice> Invoices { get; set; }
    }
}