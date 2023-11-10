using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green, Refactor

        [TestMethod]
        public void Should_return_error_when_CNPJ_is_invalid()
        {
            var document = new Document("123", EDocumentType.CNPJ);

            Assert.IsTrue(document.Invalid);
        }

        [TestMethod]
        public void Should_return_success_when_CNPJ_is_invalid()
        {
            var document = new Document("34110468000150", EDocumentType.CNPJ);
            Assert.IsTrue(document.Valid);
        }

        [TestMethod]
        public void Should_return_error_when_CPF_is_invalid()
        {
            var document = new Document("341", EDocumentType.CPF);
            Assert.IsTrue(document.Invalid);
        }

        // Testar com diversos valores
        [TestMethod]
        [DataTestMethod]
        [DataRow("38636133092")]
        [DataRow("36943585010")]
        [DataRow("07983405090")]
        public void Should_return_success_when_CPF_is_invalid(string cpf)
        {
            var document = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(document.Valid);
        }
    }
}