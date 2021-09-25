using OrderService.Domain.Enums;
using OrderService.Domain.Validators;

namespace OrderService.Domain.ValueObjects
{
    public class Document
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        public bool IsValid()
        {
            int length = Number.Length;

            if (Type == EDocumentType.CPF && length == 11)
                return true;

            if (Type == EDocumentType.CNPJ && length == 14)
                return true;

            return false;
        }
    }
}
