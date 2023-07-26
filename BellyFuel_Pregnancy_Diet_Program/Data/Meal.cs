using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BellyFuel_Pregnancy_Diet_Program.Data
{
    public class Meal
    {
        public int Id { get; set; }
        public string MealName { get; set; }
        public virtual ICollection<UserFood> UserFoods { get; set; } = null!;
        public virtual ICollection<UserBeverage> UserBeverages { get; set; } = null!;
        public Meal()
        {
            UserFoods = new List<UserFood>();
            UserBeverages = new List<UserBeverage>();
        }

        public override string ToString()
        {
            return MealName;
        }
    }
}

