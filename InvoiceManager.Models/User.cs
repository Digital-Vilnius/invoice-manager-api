using System.Collections.Generic;
using InvoiceManager.Constants.Enums;

namespace InvoiceManager.Models
{
    public class User : BaseModel
    {
        public string Email { get; set; }
        
        public string FullName { get; set; }

        public Locales Locale { get; set; } = Locales.En;

        public UserStatuses Status { get; set; } = UserStatuses.Unverified;
        
        public byte[] PasswordSalt { get; set; }
        
        public byte[] PasswordHash { get; set; }
        
        public string RefreshToken { get; set; }
        
        public List<Account> Accounts { get; set; }
    }
}