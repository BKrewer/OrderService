using OrderService.Domain.Enums;
using OrderService.Domain.Validators;

namespace OrderService.Domain.ValueObjects
{
    public class Document
    {
        private readonly DocumentValidator _validator = new();

        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        public bool IsValid()
        {
            return _validator.Validate(this).IsValid;
        }
    }
}
