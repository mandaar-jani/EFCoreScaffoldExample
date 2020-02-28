using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreScaffoldExample.Model
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasNoKey();
            builder.Property(e => e.CompanyAddress).IsUnicode(false);
            builder.Property(e => e.CompanyAuthor).IsUnicode(false);
            builder.Property(e => e.CompanyId).ValueGeneratedOnAdd();
            builder.Property(e => e.CompanyName).IsUnicode(false);
            builder.Property(e => e.CreatedBy).IsUnicode(false);
            builder.Property(e => e.UpdatedBy).IsUnicode(false);
        }
    }
}
