using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Country
    {
        [Key]
        [Display(Name = "Country")]
        public int CountryId { get; set; }

        [Required]
        [Display(Name = "Country Name")]
        [MaxLength(30)]
        [MinLength(2, ErrorMessage = "Country name must contain at least two characters.")]
        public string CountryName { get; set; }

        public ICollection<Province> Provinces { get; set; }
    }
}
