using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoBrothersIce.src.Domain.Entities.Customers;

namespace TwoBrothersIce.src.Data.Mappings
{
    public class ContactMapping : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(contact => contact.Id);
            builder.Property(contact => contact.Responsable).HasColumnType("varchar(70)");
            builder.Property(contact => contact.Phone).IsRequired(true);

            builder.HasOne(contact => contact.Customer)
                .WithMany(customer => customer.Contacts)
                .HasForeignKey(contact => contact.CustomerId)
                .HasConstraintName("Fk_customer_contacts");
        }
    }
}
