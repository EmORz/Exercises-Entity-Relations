using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem.Data.EntityConfiguration
{
    public class ResourceConfiguration :  IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            //o Name(up to 50 characters, unicode)
            //o Url(not unicode)
            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired();

            builder.Property(x => x.Url)
                .IsUnicode(false)
                .IsRequired();

        }
    }
}