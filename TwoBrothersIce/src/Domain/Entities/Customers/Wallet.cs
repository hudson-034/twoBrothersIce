using TwoBrothersIce.src.Domain.Entities.Customers;

namespace TwoBrothersIce.src.src.Domain.Entities.Customers
{
    public class Wallet
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public virtual List<PaymentTerm> PaymentTerms { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
