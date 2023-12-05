using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwoBrothersIce.src.Domain.Entities.Customers;

namespace TwoBrothersIce.src.Data.Mappings
{
    public class PaymentTermMapping : IEntityTypeConfiguration<PaymentTerm>
    {
        public void Configure(EntityTypeBuilder<PaymentTerm> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(payment => payment.Limit).HasPrecision(18, 2);
            //builder.Property(payment => payment.Limit).HasColumnType("decimal(18,2)");

            builder.HasOne(payment => payment.Wallet)
                .WithMany(wallet => wallet.PaymentTerms)
                .HasForeignKey(payment => payment.WalletId)
                .HasConstraintName("Fk_wallet_payments");
        }
    }
}
