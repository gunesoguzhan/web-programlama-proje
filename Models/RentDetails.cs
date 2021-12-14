using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class RentDetails
    {
        [Key]
        public int RentId { get; set; }

        public DateTime RentDate { get; set; }

        public double TotalPrice { get; set; }

        public string Id { get; set; }

        public int? CarId { get; set; }

        public int? OfficeId { get; set; }

        [ForeignKey("Id")]
        public UserDetails User { get; set; }

        [ForeignKey("CarId")]
        public Car Car { get; set; }

        [ForeignKey("OfficeId")]
        public Office Office { get; set; }

        public ReturnDetails ReturnDetails { get; set; }
    }
}
