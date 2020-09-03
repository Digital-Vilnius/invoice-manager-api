using System.Collections.Generic;
using InvoiceManager.Constants.Enums;

namespace InvoiceManager.Dtos.Account
{
    public class AccountsListItemDto : BaseDto
    {
        public string Type { get; set; }
        
        public string Code { get; set; }
        
        public string VatCode { get; set; }
        
        public string Currency { get; set; }
    }
}