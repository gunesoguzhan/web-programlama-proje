using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Province
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Province code")]
        public int ProvinceId { get; set; }

        [Required]
        [Display(Name = "Province")]
        [MaxLength(50)]
        [MinLength(2, ErrorMessage = "Province name must contain at least two characters.")]
        public string ProvinceName { get; set; }

        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }

        public ICollection<District> Districts { get; set; }
    }
}
