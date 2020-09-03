using InvoiceManager.Models;
using InvoiceManager.Models.Filters;
using InvoiceManager.Models.Repositories;
using InvoiceManager.Repositories.Context;

namespace InvoiceManager.Repositories
{
    public class InvoiceRepository : BaseRepository<Invoice, InvoicesFilter>, IInvoiceRepository
    {
        public InvoiceRepository(SqlContext context) : base(context)
        {
        }
    }
}