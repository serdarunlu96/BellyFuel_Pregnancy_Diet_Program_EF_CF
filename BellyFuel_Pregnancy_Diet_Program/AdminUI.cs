using BellyFuel_Pregnancy_Diet_Program.Context;
using BellyFuel_Pregnancy_Diet_Program.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BellyFuel_Pregnancy_Diet_Program
{
    public partial class AdminUI : Form
    {
        private readonly User user;

        BellyFuelDbContext db = new BellyFuelDbContext();
        public AdminUI(User user)
        {
            InitializeComponent();
        }

        private void pbFoodManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form foodManagement = new FoodManagement(user);
            foodManagement.Show();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form logout = new Logout(user);
            logout.Show();
        }

        private void pbBeverageManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form beverageManagement = new BeverageManagement(user);
            beverageManagement.Show();
        }

        private void pbUserManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form userManagement = new UserManagement(user);
            userManagement.Show();
        }
    }
}
