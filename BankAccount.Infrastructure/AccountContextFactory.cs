namespace BankAccount.Infrastructure
{
    public class AccountContextFactory: IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();   
            optionsBuilder.UseSqlServer
                ("Data Source=localhost;Initial Catalog=BankAccount;Persist Security Info=True;User ID=sa;Password=strongPassword123#;TrustServerCertificate=Yes"); 
            return new ApplicationDbContext( optionsBuilder.Options);
        }
    }   
}
