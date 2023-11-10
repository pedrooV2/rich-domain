using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditPayment : Payment
    {
        public CreditPayment(string cardHolderName, string cardNumber, string lastTransactionNumber, DateTime paidDate, string payer, DateTime expireDate, decimal total, decimal totalPaid, string owner, Document document, Address address, Email email)
            : base(paidDate, expireDate, total, totalPaid, payer, owner, document, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}