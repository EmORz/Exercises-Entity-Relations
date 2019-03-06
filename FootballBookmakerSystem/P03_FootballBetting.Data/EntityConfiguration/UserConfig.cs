using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.EntityConfiguration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.Property(x => x.Username)
                .IsUnicode()
                .IsRequired();

            builder.Property(x => x.Password)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(x => x.Email)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(x => x.Name)
                .IsRequired()
                .IsUnicode();

        }
    }
}