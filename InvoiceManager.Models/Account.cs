using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InvoiceManager.Constants.Enums;

namespace InvoiceManager.Models
{
    public class Account : BaseModel
    {
        [Required]
        public AccountTypes Type { get; set; }
        
        [Required]
        public string Code { get; set; }
        
        public string VatCode { get; set; }
        
        [Required]
        public string Currency { get; set; }
        
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        
        public List<Invoice> Invoices { get; set; }
        
        public List<Client> Clients { get; set; }
        
        public List<BankAccount> BankAccounts { get; set; }
    }
}