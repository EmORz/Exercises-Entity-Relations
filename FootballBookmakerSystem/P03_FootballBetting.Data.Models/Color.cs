﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P03_FootballBetting.Data.Models
{
    public class Color
    {
        //ColorId, Name
        public Color()
        {
            this.PrimaryKitTeams = new HashSet<Team>();
            this.SecondaryKitTeams = new HashSet<Team>();
        }

        [Key]
        public int ColorId { get; set; }

        public string Name { get; set; }

        public ICollection<Team> PrimaryKitTeams { get; set; }
        public ICollection<Team> SecondaryKitTeams { get; set; }


    }
}