namespace BankAccount.Domain
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string AddressLine { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }  
    }
}
