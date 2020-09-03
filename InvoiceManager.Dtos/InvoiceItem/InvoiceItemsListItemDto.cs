namespace InvoiceManager.Dtos.InvoiceItem
{
    public class InvoiceItemsListItemDto : BaseDto
    {
        public string Title { get; set; }
        
        public string Description { get; set; }
       
        public decimal Quantity { get; set; }
        
        public string Measurement { get; set; }
        
        public decimal Vat { get; set; }
        
        public decimal Price { get; set; }
    }
}