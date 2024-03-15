﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BowlingAPI.Data
{
    public class JoinedBowler
    {
        [Key]
        [Required]
        public int BowlerId { get; set; }
        public string? BowlerFirstName { get; set; }
        public string? BowlerMiddleInit { get; set; }
        public string? BowlerLastName { get; set; }
        [ForeignKey("TeamId")]
        public int? TeamId { get; set; }
        public Team? Team { get; set; }
        public string? TeamName { get; set; }
        public string? BowlerAddress { get; set; }
        public string? BowlerCity { get; set; }
        public string? BowlerState { get; set; }
        public string? BowlerZip { get; set; }
        public string? BowlerPhoneNumber { get; set; }
    }
}
