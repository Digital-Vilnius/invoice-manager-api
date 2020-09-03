using System.Linq;
using InvoiceManager.Models;
using InvoiceManager.Models.Filters;
using InvoiceManager.Models.Repositories;
using InvoiceManager.Repositories.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoiceManager.Repositories
{
    public class UserRepository : BaseRepository<User, BaseFilter>, IUserRepository
    {
        public UserRepository(SqlContext context) : base(context)
        {
        }

        protected override IQueryable<User> FormatQuery(IQueryable<User> query)
        {
            return query.Include(user => user.Accounts);
        }
    }
}