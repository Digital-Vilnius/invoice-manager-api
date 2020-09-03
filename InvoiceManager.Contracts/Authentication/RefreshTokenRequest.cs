using System.ComponentModel.DataAnnotations;

namespace InvoiceManager.Contracts.Authentication
{
    public class RefreshTokenRequest : BaseRequest
    {
        public string RefreshToken { get; set; }
    }
}