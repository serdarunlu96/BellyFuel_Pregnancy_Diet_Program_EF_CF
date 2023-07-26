using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellyFuel_Pregnancy_Diet_Program.Data
{
    public class UserBeverage
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Beverage")]
        public int BeverageId { get; set; }
        public virtual Beverage Beverage { get; set; }
        public int MealId { get; set; }
        public virtual Meal Meal { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
    }
}
