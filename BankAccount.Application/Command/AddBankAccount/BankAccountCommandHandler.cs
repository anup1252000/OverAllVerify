using BankAccount.Application.Interfaces;

namespace BankAccount.Application.Command.AddBankAccount
{
    public class BankAccountCommandHandler : IRequestHandler<BankAccountCommand, int>
    {
        public readonly IBankAccountRepository _bankAccountRepository;
        public BankAccountCommandHandler(IBankAccountRepository bankAccountRepository)
        {
            _bankAccountRepository = bankAccountRepository;
        }   
        public async Task<int> Handle(BankAccountCommand request, CancellationToken cancellationToken)
        {
            var account = new Account
            {
                AccountNumber = request.BankAccountVm.AccountNumber,
                AccountType= request.BankAccountVm.AccountType,
                Balance = request.BankAccountVm.Balance
            };
            return await _bankAccountRepository.AddBankAccount(account);
        }
    }
}
