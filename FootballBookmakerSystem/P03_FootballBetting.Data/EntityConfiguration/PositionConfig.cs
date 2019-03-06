using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.EntityConfiguration
{
    public class PositionConfig : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
        //public int PositionId { get; set; }

        //public string Name { get; set; }

        //public ICollection<Player> Players { get; set; }
        //
            builder.HasAlternateKey(x => x.Name);

            builder.Property(x => x.Name)
                .IsRequired()
                .IsUnicode();
        }
    }
}