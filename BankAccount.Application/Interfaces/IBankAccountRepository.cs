namespace BankAccount.Application.Interfaces
{
    public interface IBankAccountRepository
    {
        Task<int> AddBankAccount(Account account);  
        Task<IEnumerable<Account>> GetAllBankAccounts();   
    }
}
