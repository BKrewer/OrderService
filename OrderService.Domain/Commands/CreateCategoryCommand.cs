using OrderService.Shared.Commands;

namespace OrderService.Domain.Commands
{
    public class CreateCategoryCommand : ICommand
    {
        public string Name { get; set; }
    }
}
