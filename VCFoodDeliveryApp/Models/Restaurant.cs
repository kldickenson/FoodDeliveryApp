using System;
using System.Collections.Generic;
using System.Linq;


namespace VCFoodDeliveryApp.Models
{
    public class Restaurant 
    {

      public Restaurant() {
        this.Menus = new HashSet<Menu>();
      }
        public string Restaurant_Id {get; set;}
        public string RestaurantName { get; set; }
        public ICollection<Menu> Menus {get; set;}
    }
}
