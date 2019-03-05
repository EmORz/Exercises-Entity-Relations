using System.ComponentModel.DataAnnotations;

namespace P03_FootballBetting.Data.Models
{
    public class Position
    {
        //PositionId, Name

        [Key]
        public int PositionId { get; set; }

        public string Name { get; set; }

    }
}