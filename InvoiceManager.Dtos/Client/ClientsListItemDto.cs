namespace InvoiceManager.Dtos.Client
{
    public class ClientsListItemDto : BaseDto
    {
        public string Name { get; set; }
        
        public string VatCode { get; set; }
        
        public string Code { get; set; }
        
        public string Address { get; set; }
        
        public string Email { get; set; }
        
        public string Phone { get; set; }
    }
}