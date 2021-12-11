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
        public int StaticticsId { get; set; }

        [Required]
        [Display(Name = "Number of rented cars")]
        public int NumberOfRent { get; set; }
        
        [Required]
        [Display(Name = "Total rent time")]
        public int TotalRentTime { get; set; }

        [Required]
        [Display(Name = "Register year")]
        public int YearOfRegister { get; set; }

        public string UserId { get; set; }

        [ForeignKey("Id")]
        public UserDetails User { get; set; }
    }
}
