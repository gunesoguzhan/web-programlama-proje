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
        public int ReservationId { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }
        
        [Range(0, int.MaxValue)]
        public int Days { get; set; }
        
        [Range(0, double.MaxValue)]
        public double TotalPrice { get; set; }

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
