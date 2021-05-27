using System;
using System.Collections.Generic;
using System.Linq;


namespace VCFoodDeliveryApp.Models
{
    public class Item 
    {

      public Item() {
        this.Menus = new HashSet<Menu>();
      }
        public string Item_Id {get; set;}
        public string ItemName { get; set; }
        public string Description {get; set;}
        public string Dietary {get; set;}
        public DateTime CookTime {get; set;}
        public decimal Price {get; set;}
        public string Modifications {get; set;}
        public ICollection<Menu> Menus {get; set;}
    }
}
