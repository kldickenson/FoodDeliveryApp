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

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }

        // User will chose when to get the item delivered based on food cook time and distance. I think there will be some calculations involed later
        public DateTime DeliveryTime { get; set; }


        [DataType(DataType.Currency)]
        public decimal OrderTotal { get; set; }

    }
}
