namespace BankAccount.Domain
{
    public class Account
    {
        public int AccountID { get; set; }
        public required string AccountNumber { get; set; }
        public required string AccountType { get; set; }
        public decimal Balance { get; set; }
        public int CustomerID { get; set; }
        public DateTime OpenDate { get; set; }

        // Navigation property for Customer
        public Customer Customer { get; set; }

        // Navigation property for Document
        public Document Document { get; set; }
    }
}