using System.ComponentModel.DataAnnotations;
using InvoiceManager.Constants.Enums;

namespace InvoiceManager.Contracts
{
    public class Sort
    {
        [Required]
        public SortTypes Type { get; set; }
        
        [Required]
        public string Column { get; set; }
    }
}