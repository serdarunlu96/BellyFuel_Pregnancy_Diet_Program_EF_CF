using BellyFuel_Pregnancy_Diet_Program.Context;
using BellyFuel_Pregnancy_Diet_Program.Data;
using BellyFuel_Pregnancy_Diet_Program.SeedData;

namespace BellyFuel_Pregnancy_Diet_Program
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            BellyFuelDbContextSeed.Seed();
            User user = new User();
            Application.Run(new LoginPage(user));
        }
    }
}