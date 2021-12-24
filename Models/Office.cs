using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Office
    {
        [Key]
        [Display(Name = "Office")]
        public int OfficeId { get; set; }

        [Required]
        [Display(Name = "Office Name")]
        public string OfficeName { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [Phone(ErrorMessage = "The phone number does not conform to the format.")]
        public string OfficePhone { get; set; }

        [Required]
        [Display(Name = "E-mail Address")]
        [EmailAddress(ErrorMessage = "The e-mail address does not conform to the format.")]
        public string OfficeEmailAddress { get; set; }

        public int AddressId { get; set; }

        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        public ICollection<Car> Cars { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
