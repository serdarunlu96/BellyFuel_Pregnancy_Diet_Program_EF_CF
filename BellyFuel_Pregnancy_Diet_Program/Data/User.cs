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
    public class User
    {
      
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;  
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }  
        public bool IsPregnant { get; set; } 
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public DateTime? RegisteredDate { get; set; } = DateTime.Now;

        public virtual ICollection<UserBeverage> UserBeverages { get; set; }

        public virtual ICollection<UserFood> UserFoods { get; set; }

    }
}
