using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InvoiceManager.Models
{
    public class Invoice : BaseModel
    {
        [Required]
        public string SerialNumber { get; set; }

        [Required]
        public DateTime DueDate { get; set; }
        
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }
        
        [Required]
        public int AccountId { get; set; }
        public Account Account { get; set; }
        
        [Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }
        
        public string Notes { get; set; }
        
        public List<InvoiceItem> InvoiceItems { get; set; }
        
        public List<Payment> Payments { get; set; }
    }
}