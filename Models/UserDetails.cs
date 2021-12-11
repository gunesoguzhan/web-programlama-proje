using Microsoft.AspNetCore.Identity;
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

        [Required]
        [Display(Name = "User Phone Number")]
        [Phone(ErrorMessage = "The phone number does not conform to the format.")]
        public string UserPhoneNumber { get; set; }

        public int AddressId { get; set; }

        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        public UserStatisticDetails UserStatistics { get; set; }

        public ICollection<CampaignDetails> Campaigns { get; set; }

        public ICollection<RentDetails> RentDetails { get; set; }

        public ICollection<ReturnDetails> ReturnDetails { get; set; }
    }
}
