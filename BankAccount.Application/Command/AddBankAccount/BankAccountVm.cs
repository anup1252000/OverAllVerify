namespace BankAccount.Application.Command.AddBankAccount
{
    public class BankAccountVm
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }
    }
}