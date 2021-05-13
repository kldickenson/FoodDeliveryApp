using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VCFoodDeliveryApp.Models
{
    public class Cart
    {
        [StringLength(450, ErrorMessage = "Too many users created")]
        public string Id { get; set; }


        public string ApplicationUser_Id { get; set; }


        public ApplicationUser ApplicationUser { get; set; }

        public DateTime DeliveryTime { get; set; }


        [DataType(DataType.Currency)]
        public double OrderTotal { get; set; }

    }
}
