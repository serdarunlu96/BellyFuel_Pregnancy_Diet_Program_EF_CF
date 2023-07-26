using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellyFuel_Pregnancy_Diet_Program.Data
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [MaxLength(-1)] 
        public byte[]? Photo { get; set; } = null;

        [ForeignKey("FoodCategory")]
        public int CategoryId { get; set; }
        public virtual FoodCategory Category { get; set; } = null!;
        public double Calories { get; set; }
        public double Fat { get; set; }
        public double Protein { get; set; }
        public double Sugar { get; set; }
        public double Carbs { get; set; }
        public double Sodium { get; set; }

        public virtual ICollection<UserFood> UserFoods { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }


}
