using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomationSystem.Models
{
    public class ItemInfo
    {
        [Key]
        public int FoodID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        public TypeModel Type { get; set; }

        [Required]
        [ForeignKey("Type")]
        public byte TypeId { get; set; }


        [Required]
        public double Price { get; set; }

    }
}
