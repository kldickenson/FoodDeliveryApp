using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VCFoodDeliveryApp.Models
{
    public class Cart
    {
        public string Id { get; set; }

        [Required]
        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }

       
        public ApplicationUser ApplicationUser { get; set; }

        // User will chose when to get the item delivered based on food cook time and distance. I think there will be some calculations involved later
        public DateTime DeliveryTime { get; set; }
        
        public decimal OrderTotal { get; set; }

    }
}
