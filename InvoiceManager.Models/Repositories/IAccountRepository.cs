using InvoiceManager.Models.Filters;

namespace InvoiceManager.Models.Repositories
{
    public interface IAccountRepository : IBaseRepository<Account, AccountsFilter>
    {
    }
}