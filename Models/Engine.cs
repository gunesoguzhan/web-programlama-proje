using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Engine
    {
        [Key]
        public int EngineId { get; set; }

        [Required]
        [Display(Name = "Engine")]
        public string EngineName { get; set; }

        [Required]
        [Display(Name = "Horse Power")]
        [Range(0, 10000)]
        public int EngineHorsePower { get; set; }

        [Required]
        [Display(Name = "Engine Volume")]
        [Range(0, 10000)]
        public int EngineVolume { get; set; }

        [Required]
        [Display(Name = "Fuel")]
        public EngineFuelType EngineFuelType { get; set; }

        public ICollection<Car> Cars { get; set; }
    }

    public enum EngineFuelType
    {
        Gasoline,
        Diesel,
        Lpg,
        Electric,
        Hybrit
    }
}
