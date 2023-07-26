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
    public partial class UserUI : Form
    {
        private readonly User user;
        BellyFuelDbContext db = new BellyFuelDbContext();
        public UserUI(User user)
        {
            InitializeComponent();
            this.user = user;
            ShowUserName();
        }

        private void pbMealManagement_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            Form mealManagement = new MealManagement(user);
            mealManagement.Show();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form logout = new Logout(user);
            logout.Show();
        }

        private void ShowUserName()
        {
            lblName.Text = user.Name;
        }

        private void pbCaloryWeight_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form caloryweight = new CaloryWeight(user);
            caloryweight.Show();
        }

        private void pbReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form report = new Reports(user);
            report.Show();
        }
    }
}
