using System.ComponentModel.DataAnnotations;

namespace P03_FootballBetting.Data.Models
{
    public class Country
    {
        //CountryId, Name
        [Key]
        public int CountryId { get; set; }

        public string Name { get; set; }
    }
}