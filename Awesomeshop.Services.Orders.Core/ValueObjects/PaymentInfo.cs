
namespace Awesomeshop.Services.Orders.Core.ValueObjects
{
    public class PaymentInfo
    {
        public PaymentInfo(string cardNumber, string fullName, string expirationDate, string cvv)
        {
            CardNumber = cardNumber;
            FullName = fullName;
            ExpirationDate = expirationDate;
            Cvv = cvv;
        }

        public string CardNumber { get; set; }
        public string FullName { get; set; }
        public string ExpirationDate { get; set; }
        public string Cvv { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is PaymentInfo info &&
                   CardNumber == info.CardNumber &&
                   FullName == info.FullName &&
                   ExpirationDate == info.ExpirationDate &&
                   Cvv == info.Cvv;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CardNumber, FullName, ExpirationDate, Cvv);
        }
    }
}