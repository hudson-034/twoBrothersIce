using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoBrothersIce.src.src.Domain.Entities.Customers;


namespace TwoBrothersIce.src.Data.Mappings
{
    public class WalletMapping : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasKey(wallet => wallet.Id);

            builder.HasOne(wallet => wallet.Customer)
                .WithOne(customer => customer.Wallet)
                .HasForeignKey<Wallet>(wallet => wallet.CustomerId)
                .HasConstraintName("Fk_customer_wallet")
                .IsRequired(true);
            builder.HasMany(wallet => wallet.PaymentTerms)
                .WithOne(wallet => wallet.Wallet)
                .HasForeignKey(wallet => wallet.WalletId)
                .HasConstraintName("Fk_wallet_payments");
        }
    }
}
