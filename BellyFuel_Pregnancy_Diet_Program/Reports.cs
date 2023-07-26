using BellyFuel_Pregnancy_Diet_Program.Context;
using BellyFuel_Pregnancy_Diet_Program.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class Reports : Form
    {
        BellyFuelDbContext db = new BellyFuelDbContext();
        private readonly User user;
        public Reports(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void ListFoodWeekly()

        {
            DateTime selectedDate = dtpReport.Value.Date.AddHours(23).AddMinutes(59);
            DateTime startDate = selectedDate.AddDays(-7);
            DateTime endDate = selectedDate;

            var userFoods = db.UserFoods.Include(uf => uf.Food).Where(uf => uf.Date >= startDate && uf.Date <= endDate).OrderBy(x => x.Date).Select(a => new { Date = a.Date, Name = a.Food.Name, Amount = a.Amount, Meal = a.Meal.MealName }).ToList();

            dgvFoodReportsWeek.DataSource = null;
            dgvFoodReportsWeek.DataSource = userFoods;
        }
        private void ListFoodMonthly()

        {
            DateTime selectedDate = dtpReport.Value.Date.AddHours(23).AddMinutes(59);
            DateTime startDate = selectedDate.AddDays(-30);
            DateTime endDate = selectedDate;

            var userFoods = db.UserFoods.Include(uf => uf.Food).Where(uf => uf.Date >= startDate && uf.Date <= endDate).OrderBy(x => x.Date).Select(a => new { Date = a.Date, Name = a.Food.Name, Amount = a.Amount, Meal = a.Meal.MealName }).ToList();

            dgvFoodReportsMonth.DataSource = null;
            dgvFoodReportsMonth.DataSource = userFoods;
        }

        private void ListBeverageWeekly()

        {
            DateTime selectedDate = dtpReport.Value.Date.AddHours(23).AddMinutes(59);
            DateTime startDate = selectedDate.AddDays(-7);
            DateTime endDate = selectedDate;

            var userBeverages = db.UserBeverages.Include(uf => uf.Beverage).Where(uf => uf.Date >= startDate && uf.Date <= endDate).OrderBy(x => x.Date).Select(a => new { Date = a.Date, Name = a.Beverage.Name, Amount = a.Amount, Meal = a.Meal.MealName }).ToList();

            dgvBevReportsWeek.DataSource = null;
            dgvBevReportsWeek.DataSource = userBeverages;
        }
        private void ListBeverageMonthly()
        {
            DateTime selectedDate = dtpReport.Value.Date.AddHours(23).AddMinutes(59);
            DateTime startDate = selectedDate.AddDays(-30);
            DateTime endDate = selectedDate;

            var userBeverages = db.UserBeverages.Include(uf => uf.Beverage).Where(uf => uf.Date >= startDate && uf.Date <= endDate).OrderBy(x => x.Date).Select(a => new { Date = a.Date, Name = a.Beverage.Name, Amount = a.Amount, Meal = a.Meal.MealName }).ToList();

            dgvBevReportsMonth.DataSource = null;
            dgvBevReportsMonth.DataSource = userBeverages;
        }

        private void dtpReport_ValueChanged(object sender, EventArgs e)
        {
            ListFoodWeekly();
            ListFoodMonthly();
            ListBeverageWeekly();
            ListBeverageMonthly();

        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form r = new CaloryWeight(user);
            r.Show();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form userUI = new UserUI(user);
            userUI.Show();
        }

        private void pbMealManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form meal = new MealManagement(user);
            meal.Show();
        }

        private void pbStatistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form statistics = new Statistics(user);
            statistics.Show();
        }
    }
}
