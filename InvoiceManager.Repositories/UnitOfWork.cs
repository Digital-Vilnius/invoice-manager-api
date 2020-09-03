using System.Threading.Tasks;
using InvoiceManager.Models.Repositories;
using InvoiceManager.Repositories.Context;

namespace InvoiceManager.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SqlContext _context;
        
        public UnitOfWork(SqlContext context)
        {
            _context = context;
        }
        
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}