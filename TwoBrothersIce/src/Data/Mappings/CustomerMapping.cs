using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoBrothersIce.src.Domain.Entities.Customers;
using TwoBrothersIce.src.src.Domain.Entities.Customers;

namespace TwoBrothersIce.src.Data.Mappings
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(customer => customer.Id);
            builder.Property(customer => customer.CpfCnpj).IsRequired(true);
            builder.Property(customer => customer.CompanyName).HasColumnType("varchar(70)").IsRequired();
            builder.Property(customer => customer.FantasyName).HasColumnType("varchar(50)");

            builder.HasOne(customer => customer.Wallet)
                .WithOne(wallet => wallet.Customer)
                .HasForeignKey<Wallet>(wallet => wallet.CustomerId)
                .HasConstraintName("Fk_customer_wallet")
                .IsRequired(true);
            builder.HasMany(customer => customer.Contacts)
                .WithOne(customer => customer.Customer)
                .HasForeignKey(contact => contact.CustomerId)
                .HasConstraintName("Fk_customer_contacts")
                .IsRequired(true);
        }
    }
}
