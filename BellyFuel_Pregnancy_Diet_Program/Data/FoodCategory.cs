using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BellyFuel_Pregnancy_Diet_Program.Data
{
    public class FoodCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; } 

        public virtual ICollection<Food> Foods { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
    }

}

