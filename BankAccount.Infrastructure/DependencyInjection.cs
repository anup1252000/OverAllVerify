using BankAccount.Infrastructure.Repository;

namespace BankAccount.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IBankAccountRepository, BankAccountRepository>();
            services.AddDbContext<ApplicationDbContext>(x=>x.UseSqlServer("Data Source=localhost;Initial Catalog=BankAccount;Persist Security Info=True;User ID=sa;Password=strongPassword123#;TrustServerCertificate=Yes"));
            return services;
        }   
    }
}
