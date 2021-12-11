using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRent.Models
{
    public class CampaignDetails
    {
        [Key]
        public int CampaignDetailsId { get; set; }

        [Display(Name = "Campaign")]
        public string CampaignName { get; set; }

        [Display(Name = "Details")]
        public string CampaignDetail { get; set; }

        [Display(Name = "Discount")]
        public double CampaignDiscount { get; set; }

        [Display(Name = "Number of campaigns")]
        public int NumberOfCampaigns { get; set; }

        public string UserId { get; set; }

        [ForeignKey("Id")]
        public UserDetails User { get; set; }
    }
}
