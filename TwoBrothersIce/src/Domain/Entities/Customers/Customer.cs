using TwoBrothersIce.src.src.Domain.Entities.Customers;

namespace TwoBrothersIce.src.Domain.Entities.Customers
{
    public class Customer
    {
        public int Id { get; set; }
        public int CpfCnpj { get; set; }
        public string CompanyName { get; set; }
        public string FantasyName { get; set; }
        public Wallet Wallet { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
