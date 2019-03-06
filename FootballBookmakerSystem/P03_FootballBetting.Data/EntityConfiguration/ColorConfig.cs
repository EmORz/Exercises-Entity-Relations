using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.EntityConfiguration{
    public class ColorConfig : IEntityTypeConfiguration<Color>
    {
        //public string Name { get; set; }

        //public ICollection<Team> PrimaryKitTeams { get; set; }
        //public ICollection<Team> SecondaryKitTeams { get; set; }
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .IsUnicode();
            builder.HasAlternateKey(x => x.Name);

        }
    }
}