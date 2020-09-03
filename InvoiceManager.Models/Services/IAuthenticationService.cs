using System.Threading.Tasks;
using InvoiceManager.Contracts;
using InvoiceManager.Contracts.Authentication;
using InvoiceManager.Dtos.Authentication;

namespace InvoiceManager.Models.Services
{
    public interface IAuthenticationService
    {
        Task<ResultResponse<LoggedUserDto>> LoginAsync(LoginRequest request);
        Task<ResultResponse<LoggedUserDto>> GetLoggedUserDtoAsync(string refreshToken = null);
        Task<BaseResponse> EditAsync(EditLoggedUserRequest request);
        Task<LoggedUser> GetLoggedUserAsync(string refreshToken = null);
        Task<ResultResponse<LoggedUserDto>> RefreshTokenAsync(RefreshTokenRequest request);
        Task<BaseResponse> RegisterAsync(RegisterRequest request);
    }
}