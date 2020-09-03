using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceManager.Models
{
    public class InvoiceItem : BaseModel
    {
        [Required]
        public string Title { get; set; }
        
        public string Description { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Quantity { get; set; }
        
        [Required]
        public string Measurement { get; set; }
        
        [Column(TypeName = "decimal(10,2)")]
        public decimal Vat { get; set; }
        
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        
        [Required]
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}