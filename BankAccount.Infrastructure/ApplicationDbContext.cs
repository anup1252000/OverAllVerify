namespace BankAccount.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Document> Documents { get; set; }  
        public DbSet<Customer> Customers { get; set; }  
    }
}