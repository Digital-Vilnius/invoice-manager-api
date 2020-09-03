using InvoiceManager.Models.Filters;

namespace InvoiceManager.Models.Repositories
{
    public interface IClientRepository : IBaseRepository<Client, ClientsFilter>
    {
        
    }
}