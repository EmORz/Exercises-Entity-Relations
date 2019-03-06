using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P03_FootballBetting.Data.Models;

namespace P03_FootballBetting.Data.EntityConfiguration
{
    public class BetConfiguration : IEntityTypeConfiguration<Bet>
    {
        public void Configure(EntityTypeBuilder<Bet> builder)
        {

            builder.Property(x => x.Amount)
                .IsRequired();

            builder.Property(x => x.Prediction)
                .IsRequired();

            builder.Property(x => x.DateTime)
                .HasDefaultValue(DateTime.Now);

            builder.Property(x => x.UserId)
                .IsRequired();

            builder.Property(x => x.GameId)
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany(x => x.Bets)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Game)
                .WithMany(x => x.Bets)
                .HasForeignKey(x => x.GameId);
            
        }
    }
}