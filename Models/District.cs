using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class District
    {
        [Key]
        [Display(Name = "District")]
        public int DistrictId { get; set; }
        
        [Required]
        [Display(Name = "District Name")]
        [MaxLength(50)]
        [MinLength(2, ErrorMessage = "District name must contain at least two characters.")]
        public string DistrictName { get; set; }

        
        public int ProvinceId { get; set; }

        [ForeignKey("ProvinceId")]
        public Province Province { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
