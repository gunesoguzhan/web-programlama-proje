using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class UserStatisticDetails
    {
        [Key]
        [Display(Name = "Statistic")]
        public int StaticticsId { get; set; }

        [Required]
        [Display(Name = "Number of rented cars")]
        public int NumberOfRent { get; set; }

        [Required]
        [Display(Name = "Register date")]
        public DateTime DateOfRegister { get; set; }

        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public UserDetails User { get; set; }
    }
}
