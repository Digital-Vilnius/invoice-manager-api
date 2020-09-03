using System.Threading.Tasks;
using InvoiceManager.Contracts;
using InvoiceManager.Contracts.Account;
using InvoiceManager.Dtos.Account;

namespace InvoiceManager.Models.Services
{
    public interface IAccountService
    {
        Task<ListResponse<AccountsListItemDto>> ListAsync(ListAccountsRequest request);
        Task<ResultResponse<AccountDto>> GetAsync(int id);
        Task<BaseResponse> DeleteAsync(int id);
    }
}