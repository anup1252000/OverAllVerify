using Microsoft.ApplicationInsights;

namespace BankAccount.Infrastructure.Repository
{
    public class BankAccountRepository : IBankAccountRepository
    {
        #region Fields
        private readonly ApplicationDbContext _context;
        private readonly ILogger<BankAccountRepository> _logger;
        private readonly TelemetryClient _telemetryClient;
        #endregion

        #region constructor
        public BankAccountRepository(ApplicationDbContext context,
            ILogger<BankAccountRepository> logger, TelemetryClient telemetryClient)
        {
            _context = context;
            _logger = logger;
            _telemetryClient = telemetryClient;
        }
        #endregion

        #region Methods 
        /// <summary>
        /// Method to add bank account.
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public async Task<int> AddBankAccount(Account account)
        {
            try
            {
                _logger.LogInformation("AddBankAccount method called");
                _logger.LogInformation("AddBankAccount method called with account number {0}", account.AccountNumber);
                _context.Accounts.Add(account);
                await _context.SaveChangesAsync();
                _logger.LogInformation("AddBankAccount method completed with account number {0}", account.AccountNumber);
                return account.AccountID;
            }
            catch (Exception ex)
            {
                _telemetryClient.TrackException(ex);
                throw;
            }
            
        }
        /// <summary>
        /// Method to get all bank accounts.    
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Account>> GetAllBankAccounts()
        {
            try
            {
                _logger.LogInformation("GetAllBankAccounts method called");
                var accounts = await _context.Accounts.ToListAsync();
                _logger.LogInformation($"{accounts.Count} accounts");
                _logger.LogInformation("GetAllBankAccounts method completed");
                return accounts;
            }
            catch (Exception ex)
            {
                _telemetryClient.TrackException(ex);
                throw;
            }
              
        }
        #endregion
    }
}
