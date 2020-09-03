using System.Threading.Tasks;
using InvoiceManager.Contracts;
using InvoiceManager.Contracts.Invoice;
using InvoiceManager.Dtos.Invoice;

namespace InvoiceManager.Models.Services
{
    public interface IInvoiceService
    {
        Task<ListResponse<InvoicesListItemDto>> ListAsync(ListInvoicesRequest request);
        Task<ResultResponse<InvoiceDto>> GetAsync(int id);
        Task<BaseResponse> AddAsync(AddInvoiceRequest request);
        Task<BaseResponse> EditAsync(EditInvoiceRequest request);
        Task<BaseResponse> DeleteAsync(int id);
    }
}