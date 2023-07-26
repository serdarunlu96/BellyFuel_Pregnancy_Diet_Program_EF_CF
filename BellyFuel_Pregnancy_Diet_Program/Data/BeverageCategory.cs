using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellyFuel_Pregnancy_Diet_Program.Data
{
    public class BeverageCategory
    {
      
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; } 

        public virtual ICollection<Beverage> Beverages { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
