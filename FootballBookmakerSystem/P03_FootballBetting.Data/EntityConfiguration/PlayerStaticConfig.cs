using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.EntityConfiguration
{
    public class PlayerStaticConfig : IEntityTypeConfiguration<PlayerStatistic>
    {
        public void Configure(EntityTypeBuilder<PlayerStatistic> builder)
        {
        //public int GameId { get; set; }
        //public Game Game { get; set; }

        //public int PlayerId { get; set; }
        //public Player Player { get; set; }

        //public int ScoredGoals { get; set; }

        //public int Assists { get; set; }

        //public int MinutesPlayed { get; set; }
        //

            builder.HasKey(x => new {x.GameId, x.PlayerId});

            builder.HasOne(x => x.Game)
                .WithMany(x => x.PlayerStatistics)
                .HasForeignKey(x => x.GameId);

            builder.HasOne(x => x.Player)
                .WithMany(x => x.PlayerStatistics)
                .HasForeignKey(x => x.PlayerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}