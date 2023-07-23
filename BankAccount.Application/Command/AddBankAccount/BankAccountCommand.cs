
namespace BankAccount.Application.Command.AddBankAccount
{
    public class BankAccountCommand:IRequest<int>
    {
        public required BankAccountVm BankAccountVm { get; set; }
    }
}
