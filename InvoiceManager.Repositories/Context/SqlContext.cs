using InvoiceManager.Constants.Enums;
using InvoiceManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InvoiceManager.Repositories.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Account
            modelBuilder
                .Entity<Account>()
                .Property(account => account.Type)
                .HasConversion(new EnumToStringConverter<AccountTypes>());
            
            modelBuilder.Entity<Account>()
                .HasOne(account => account.User)
                .WithMany(user => user.Accounts)
                .HasForeignKey(account => account.UserId);
            
            // Client
            modelBuilder.Entity<Client>()
                .HasOne(client => client.Account)
                .WithMany(account => account.Clients)
                .HasForeignKey(client => client.AccountId);

            // Invoice
            modelBuilder.Entity<Invoice>()
                .HasOne(invoice => invoice.Account)
                .WithMany(account => account.Invoices)
                .HasForeignKey(invoice => invoice.AccountId);
            
            modelBuilder.Entity<Invoice>()
                .HasOne(invoice => invoice.BankAccount)
                .WithMany(bankAccount => bankAccount.Invoices)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(invoice => invoice.BankAccountId);
            
            modelBuilder.Entity<Invoice>()
                .HasOne(invoice => invoice.Client)
                .WithMany(client => client.Invoices)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(invoice => invoice.ClientId);
            
            // Invoice item
            modelBuilder.Entity<InvoiceItem>()
                .HasOne(invoiceItem => invoiceItem.Invoice)
                .WithMany(invoice => invoice.InvoiceItems)
                .HasForeignKey(invoiceItem => invoiceItem.InvoiceId);
            
            // Payment
            modelBuilder.Entity<Payment>()
                .HasOne(paymeny => paymeny.Invoice)
                .WithMany(invoice => invoice.Payments)
                .HasForeignKey(paymeny => paymeny.InvoiceId);
            
            // Bank account
            modelBuilder.Entity<BankAccount>()
                .HasOne(backAccount => backAccount.Account)
                .WithMany(account => account.BankAccounts)
                .HasForeignKey(backAccount => backAccount.AccountId);
            
            // User
            modelBuilder
                .Entity<User>()
                .Property(user => user.Status)
                .HasConversion(new EnumToStringConverter<UserStatuses>());

            modelBuilder
                .Entity<User>()
                .Property(user => user.Locale)
                .HasConversion(new EnumToStringConverter<Locales>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}