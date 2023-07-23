namespace BankAccount.Domain
{
    public class Document
    {
        public int DocumentID { get; set; }
        public int AccountID { get; set; }
        public required string DocumentName { get; set; }
        public required string DocumentFile { get; set; }

        // Navigation property for BankAccount
        public Account Account { get; set; }
    }
}
