using BellyFuel_Pregnancy_Diet_Program.Data;
using BellyFuel_Pregnancy_Diet_Program.SeedData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BellyFuel_Pregnancy_Diet_Program.Control
{
    public class BellyFuelControl
    {
        public static bool ValidatePassword(string password, string passwordHash)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                string computedHash = Convert.ToBase64String(hashBytes);
                return passwordHash.Equals(computedHash);
            }
        }

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashBytes);
            }
        }


    }
}
