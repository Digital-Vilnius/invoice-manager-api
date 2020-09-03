using InvoiceManager.Models.Filters;

namespace InvoiceManager.Models.Repositories
{
    public interface IUserRepository : IBaseRepository<User, BaseFilter>
    {
    }
}