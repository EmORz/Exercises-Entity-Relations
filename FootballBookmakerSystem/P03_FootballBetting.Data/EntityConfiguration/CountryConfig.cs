using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.EntityConfiguration
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {

        //public string Name { get; set; }

        //public ICollection<Town> Towns { get; set; }
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasAlternateKey(x => x.Name);

            builder.Property(x => x.Name)
                .IsUnicode()
                .IsRequired();
        }
    }
}