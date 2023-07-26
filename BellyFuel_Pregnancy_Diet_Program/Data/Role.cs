using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellyFuel_Pregnancy_Diet_Program.Data
{
    public class Role
    {        
        public int Id { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<User> Users { get; set;}
    }
}
