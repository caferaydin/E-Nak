using E_Nak.Domain.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Nak.Persistence.Configurations.Account
{
    internal class IndividualConfiguration : IEntityTypeConfiguration<Individual>
    {
        public void Configure(EntityTypeBuilder<Individual> builder)
        {
            builder.Property(i => i.FirstName).IsRequired(true).HasMaxLength(50);
            builder.Property(i => i.LastName).IsRequired(true).HasMaxLength(30);
            builder.Property(i => i.NationalityId).IsRequired(true).HasMaxLength(11);
            builder.Property(i => i.DateOfBirth).IsRequired(true).HasColumnType("DateTime");

        }
    }
}
