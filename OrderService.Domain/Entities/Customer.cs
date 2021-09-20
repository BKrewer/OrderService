namespace OrderService.Domain.Entities
{
    public class Customer
    {
        public Customer(string firstName, string lastName, string email, string document)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Document = document;
        }

        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Document { get; private set; }
    }
}
