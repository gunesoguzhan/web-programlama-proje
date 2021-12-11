using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [Required]
        [Display(Name = "Address Title")]
        [MaxLength(30)]
        [MinLength(2, ErrorMessage = "Address title must contain at least two characters.")]
        public string AddressTitle { get; set; }

        [Required]
        [Display(Name = "Address")]
        [MinLength(5, ErrorMessage = "Address must contain at least five characters.")]
        public string AddressText { get; set; }

        public int DistrictId { get; set; }

        [ForeignKey("DistrictId")]
        public District District { get; set; }

        public UserDetails User { get; set; }

        public Office Office { get; set; }
    }
}
