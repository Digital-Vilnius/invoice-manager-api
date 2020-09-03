using System.Threading.Tasks;

namespace InvoiceManager.Models.Repositories
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}