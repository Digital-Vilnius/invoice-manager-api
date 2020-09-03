using System.Threading.Tasks;
using InvoiceManager.Contracts;
using InvoiceManager.Contracts.Client;
using InvoiceManager.Dtos.Client;

namespace InvoiceManager.Models.Services
{
    public interface IClientService
    {
        Task<ListResponse<ClientsListItemDto>> ListAsync(ListClientsRequest request);
        Task<ResultResponse<ClientDto>> GetAsync(int id);
        Task<BaseResponse> AddAsync(AddClientRequest request);
        Task<BaseResponse> EditAsync(EditClientRequest request);
        Task<BaseResponse> DeleteAsync(int id);
    }
}