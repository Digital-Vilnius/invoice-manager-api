using System.Linq;
using InvoiceManager.Models;
using InvoiceManager.Models.Filters;
using InvoiceManager.Models.Repositories;
using InvoiceManager.Repositories.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoiceManager.Repositories
{
    public class AccountRepository : BaseRepository<Account, AccountsFilter>, IAccountRepository
    {
        public AccountRepository(SqlContext context) : base(context)
        {
        }

        protected override IQueryable<Account> FormatQuery(IQueryable<Account> query)
        {
            return query.Include(account => account.User);
        }
    }
}