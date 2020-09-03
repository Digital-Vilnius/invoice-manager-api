using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManager.Models
{
    public class BankAccount : BaseModel
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Iban { get; set; }
        
        [Required]
        public int AccountId { get; set; }
        public Account Account { get; set; }
        
        public List<Invoice> Invoices { get; set; }
    }
}