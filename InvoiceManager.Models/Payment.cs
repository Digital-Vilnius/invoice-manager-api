using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InvoiceManager.Constants.Enums;

namespace InvoiceManager.Models
{
    public class Payment : BaseModel
    {
        [Required]
        public PaymentTypes PaymentType { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        
        [Required]
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}