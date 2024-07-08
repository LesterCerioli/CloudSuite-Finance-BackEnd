using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CloudSuite.BackBonne.Domain.models.AdviceService;

namespace CloudSuite.Infrastructure.Mapping
{
    public class InvestmentEFCoreMapping : IEntityTypeConfiguration<Investment>
    {
        public void Configure(EntityTypeBuilder<Investment> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id)
                .HasColumnName("id");

            builder.Property(i => i.TaxPayerRegistry)
                .IsRequired()
                .HasColumnName("taxPayerRegistry")
                .HasColumnType("varchar(100)");

            builder.Property(i => i.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasColumnType("varchar(200)");

            builder.Property(i => i.InvestmentProfile)
                .IsRequired()
                .HasColumnName("investmentProfile")
                .HasColumnType("varchar(100)");

            builder.ToTable("msfinance_Investment");
        }
    }
}
