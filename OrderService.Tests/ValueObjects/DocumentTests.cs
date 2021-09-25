using OrderService.Domain.Enums;
using OrderService.Domain.ValueObjects;
using Xunit;

namespace OrderService.Tests.ValueObjects
{
    public class DocumentTests
    {
        [Fact]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            Document doc = new ("123", EDocumentType.CNPJ);
            Assert.False(doc.IsValid());
        }

        [Fact]
        public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            Document doc = new("42424999000146", EDocumentType.CNPJ);
            Assert.True(doc.IsValid());
        }

        [Fact]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            Document doc = new ("123", EDocumentType.CPF);
            Assert.False(doc.IsValid());
        }

        [Fact]
        public void ShouldReturnSuccessWhenCPFIsValid()
        {
            Document doc = new ("71082088064", EDocumentType.CPF);
            Assert.True(doc.IsValid());
        }
    }
}
