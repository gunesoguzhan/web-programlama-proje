using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class Reservation
    {
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Days { get; set; }
        public double TotalPrice { get; set; }
        public string UserId { get; set; }
        public Car Car { get; set; }
        public Office ReturnOffice { get; set; }
    }
}
