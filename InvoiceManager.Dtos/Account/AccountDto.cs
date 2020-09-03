using System.Collections.Generic;

namespace InvoiceManager.Dtos.Account
{
    public class AccountDto : BaseDto
    {
        public string Type { get; set; }
        
        public string Code { get; set; }
        
        public string VatCode { get; set; }
        
        public string Currency { get; set; }
    }
}