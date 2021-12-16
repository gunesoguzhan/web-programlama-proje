using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        
        [Required]
        [Display(Name = "Brand")]
        public string CarBrand { get; set; }

        [Required]
        [Display(Name = "Model")]
        public string CarModel { get; set; }

        [Required]
        [Display(Name = "Type")]
        public CarType CarType { get; set; }

        [Required]
        [Display(Name = "Trim Package")]
        public string CarTrimPackage { get; set; }

        [Required]
        [Display(Name = "Seats")]
        [Range(1, 100)]
        public int CarSeats { get; set; }

        [Required]
        [Display(Name = "Doors")]
        [Range(1, 10)]
        public int CarDoors { get; set; }

        [Required]
        [Display(Name = "Color")]
        public string CarColor { get; set; }

        [Required]
        [Display(Name = "Product Year")]
        [Range(1970, 10000)]
        public int CarProductYear { get; set; }

        [Required]
        [Display(Name = "Kilometer")]
        [Range(0, int.MaxValue)]
        public int CarKilometer { get; set; }

        [Required]
        [Display(Name = "Rent Price")]
        [Range(0, double.MaxValue)]
        public double CarRentPrice { get; set; }

        [Required]
        [Display(Name = "Deposit Price")]
        [Range(0, double.MaxValue)]
        public double CarDepositPrice { get; set; }

        [Required]
        [Display(Name = "Minimum Age")]
        [Range(0, int.MaxValue)]
        public int MinimumAge { get; set; }

        public string CarImageUrl { get; set; }

        public string CarCoverImageUrl { get; set; }

        [Required]
        [Display(Name = "Gearbox")]
        public CarTransmissionType CarTransmissionType { get; set; }

        public int EngineId { get; set; }

        public int OfficeId { get; set; }

        [ForeignKey("EngineId")]
        public Engine Engine { get; set; }

        [ForeignKey("OfficeId")]
        public Office Office { get; set; }

        public ICollection<RentDetails> RentDetails { get; set; }

        public ICollection<ReturnDetails> ReturnDetails { get; set; }
    }

    public enum CarType
    {
        Sedan,
        HatchBack,
        Coupe,
        Station,
        Suv,
        Minivan,
        SportsCar
    }

    public enum CarTransmissionType
    {
        Manual,
        Automatic,
        Semi
    }
}
