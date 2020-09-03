using InvoiceManager.Models.Filters;

namespace InvoiceManager.Models.Repositories
{
    public interface IInvoiceRepository : IBaseRepository<Invoice, InvoicesFilter>
    {
        
    }
}