using InvoiceManager.Models;
using InvoiceManager.Models.Filters;
using InvoiceManager.Models.Repositories;
using InvoiceManager.Repositories.Context;

namespace InvoiceManager.Repositories
{
    public class ClientRepository : BaseRepository<Client, ClientsFilter>, IClientRepository
    {
        public ClientRepository(SqlContext context) : base(context)
        {
        }
    }
}