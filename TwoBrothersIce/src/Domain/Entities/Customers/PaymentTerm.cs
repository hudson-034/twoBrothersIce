using TwoBrothersIce.src.src.Domain.Entities.Customers;

namespace TwoBrothersIce.src.Domain.Entities.Customers
{
    public class PaymentTerm
    {
        public int Id { get; set; }
        public Enums.PaymentTerm Payment { get; set; }
        public decimal Limit { get; set; }
        public int WalletId { get; set; }
        public virtual Wallet Wallet { get; set; }
    }
}
