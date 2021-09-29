using OrderService.Shared.Commands;

namespace OrderService.Domain.Commands
{
    public class CreateCustomerCommand : ICommand
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Address { get; private set; }
        public string Number { get; private set; }
    }
}
