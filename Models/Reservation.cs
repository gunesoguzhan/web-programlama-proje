using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Reservation
    {
        [Key]
        [Display(Name = "Reservation")]
        public int ReservationId { get; set; }

        [Display(Name = "Reservation Date")]
        public DateTime ReservationDate { get; set; }

        [Display(Name = "Return Date")]
        public DateTime ReturnDate { get; set; }

        [Display(Name = "Number Of Days")]
        [Range(0, int.MaxValue)]
        public int Days { get; set; }

        [Display(Name = "Total Price")]
        [Range(0, double.MaxValue)]
        public double TotalPrice { get; set; }

        [Display(Name = "Reservation Status")]
        public ReservationStatus ReservationStatus { get; set; }

        public string UserId { get; set; }
        
        public int CarId { get; set; }
        
        public int? ReturnOfficeId { get; set; }

        [ForeignKey("UserId")]
        public UserDetails User { get; set; }

        [ForeignKey("CarId")]
        public Car Car { get; set; }
        
        [ForeignKey("ReturnOfficeId")]
        public Office ReturnOffice { get; set; }
    }

    public enum ReservationStatus
    {
        reserved,
        complated
    }
}
