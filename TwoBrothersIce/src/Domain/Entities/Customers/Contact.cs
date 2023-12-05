using TwoBrothersIce.src.Domain.Enums;

namespace TwoBrothersIce.src.Domain.Entities.Customers
{
    public class Contact
    {
        public int Id { get; set; }
        public string Responsable { get; set; }
        public int Phone { get; set; }
        public ContactType ContactType { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
