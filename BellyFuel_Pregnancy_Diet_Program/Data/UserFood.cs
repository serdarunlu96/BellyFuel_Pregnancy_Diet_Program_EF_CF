using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellyFuel_Pregnancy_Diet_Program.Data
{
    public class UserFood
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Food Food { get; set; }
        public int FoodId { get; set; }
        public virtual Meal Meal { get; set; }
        public int MealId { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
    }
}
