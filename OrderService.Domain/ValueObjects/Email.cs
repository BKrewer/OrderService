
using OrderService.Domain.Validators;

namespace OrderService.Domain.ValueObjects
{
    public class Email
    {
        private readonly EmailValidator _validator = new();

        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; private set; }

        public bool IsValid()
        {
            return _validator.Validate(this).IsValid;
        }
    }
}
