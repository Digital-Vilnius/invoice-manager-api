using InvoiceManager.Dtos.User;

namespace InvoiceManager.Dtos.Authentication
{
    public class LoggedUserDto
    {
        public UserDto User { get; set; }

        public string RefreshToken { get; set; }
        
        public string Token { get; set; }
    }
}