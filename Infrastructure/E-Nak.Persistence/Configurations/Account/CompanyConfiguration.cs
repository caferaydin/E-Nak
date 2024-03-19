using E_Nak.Domain.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Nak.Persistence.Configurations.Account
{
    internal class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(c => c.CompanyName).IsRequired(true).HasMaxLength(255);
            builder.Property(c => c.TaxNumber).IsRequired(true).HasMaxLength(12);
            builder.Property(c => c.TaxAdministrator).IsRequired(true).HasMaxLength(255);




        }
    }
}
