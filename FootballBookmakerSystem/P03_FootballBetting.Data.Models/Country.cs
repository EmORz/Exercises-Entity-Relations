﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P03_FootballBetting.Data.Models
{
    public class Country
    {
        //CountryId, Name

        public Country()
        {
            this.Towns = new HashSet<Town>();
        }
        [Key]
        public int CountryId { get; set; }

        public string Name { get; set; }

        public ICollection<Town> Towns { get; set; }

    }
}