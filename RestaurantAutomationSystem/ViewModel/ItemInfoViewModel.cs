using RestaurantAutomationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomationSystem.ViewModel
{
    public class ItemInfoViewModel
    {
        public string FoodID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public byte Type { get; set; }

        public IEnumerable<TypeModel> Types { get; set; }

        [Required]
        public string Price { get; set; }

        public double dPrice
        {
            get
            {
                return Price != null? Double.Parse(Price) : 0;
            }
        }

    }


}
