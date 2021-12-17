﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class UserDetails : IdentityUser
    {
        [Required]
        [Display(Name = "User name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "User surname")]
        public string Surname { get; set; }

        public int? AddressId { get; set; }

        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        public UserStatisticDetails UserStatistics { get; set; }

        public ICollection<CampaignDetails> Campaigns { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
