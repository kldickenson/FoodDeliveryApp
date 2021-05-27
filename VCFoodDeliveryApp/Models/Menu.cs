using System;
using System.Collections.Generic;
using System.Linq;


namespace VCFoodDeliveryApp.Models
{
    public class Menu 
    {

      public Menu() {
        this.Items = new HashSet<Item>();
      }
        public string Menu_Id {get; set;}
        public string Meal { get; set; }
        public string Restaurant_Id { get; set; }
        public Restaurant Restaurant { get; set; }
        public ICollection<Item> Items {get; set;}
    }
}
