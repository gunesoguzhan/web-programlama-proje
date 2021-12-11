using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class ReturnDetails
    {
        [Key]
        public int ReturnId { get; set; }

        public DateTime ReturnDate { get; set; }

        public int RentId { get; set; }

        public int? OfficeId { get; set; }

        [ForeignKey("RentId")]
        public RentDetails RentDetails { get; set; }

        [ForeignKey("OfficeId")]
        public Office Office { get; set; }
    }
}
