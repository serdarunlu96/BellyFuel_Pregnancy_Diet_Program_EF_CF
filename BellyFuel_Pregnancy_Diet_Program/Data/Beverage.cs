using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellyFuel_Pregnancy_Diet_Program.Data
{
    public class Beverage
    {     
        public int Id { get; set; }

        public string Name { get; set; }

        [MaxLength(-1)] 
        public byte[]? Photo { get; set; } = null;

        [ForeignKey("BeverageCategory")]
        public int CategoryId { get; set; }
        public virtual BeverageCategory Category { get; set; } = null!;
        public virtual ICollection<UserBeverage> UserBeverages { get; set; }

        public double Calories { get; set; }
        public double Fat { get; set; }
        public double Protein { get; set; }
        public double Sugar { get; set; }
        public double Carbs { get; set; }
        public double Sodium { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
