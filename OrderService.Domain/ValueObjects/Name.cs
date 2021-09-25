using OrderService.Domain.Validators;

namespace OrderService.Domain.ValueObjects
{
    public class Name
    {
        private readonly NameValidator _validator = new();

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public bool IsValid()
        {
            return _validator.Validate(this).IsValid;
        }
    }
}
