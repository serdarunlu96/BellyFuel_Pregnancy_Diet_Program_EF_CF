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
    public partial class Statistics : Form
    {
        BellyFuelDbContext db = new BellyFuelDbContext();
        private readonly User user;
        public Statistics(User user)
        {
            InitializeComponent();
            this.user = user;
        }


        private void Statistics_Load(object sender, EventArgs e)
        {
            ShowFoodConsumption();
            ShowMostConsumedFoods();
            ShowBevConsumption();
            ShowMostConsumedBevs();
        }


        private void ShowFoodConsumption()
        {
            var foodConsumption = db.UserFoods
                .Where(userFood => userFood.UserId == user.Id)
                .Select(userFood => new
                {
                    FoodCategory = userFood.Food.Category,
                    FoodName = userFood.Food.Name,
                    MealName = userFood.Meal.MealName,
                    Amount = userFood.Amount
                })
                .OrderBy(userFood => userFood.FoodName)
                .ToList();

            dgvFoodConsumption.DataSource = foodConsumption;
        }

        private void ShowBevConsumption()
        {
            var bevConsumption = db.UserBeverages
                .Where(userBeverages => userBeverages.UserId == user.Id)
                .Select(userBeverages => new
                {
                    BeverageCategory = userBeverages.Beverage.Category,
                    BeverageName = userBeverages.Beverage.Name,
                    MealName = userBeverages.Meal.MealName,
                    Amount = userBeverages.Amount
                })
                .OrderBy(userBeverages => userBeverages.BeverageName)
                .ToList();

            dgvBevConsumption.DataSource = bevConsumption;
        }

        private void ShowMostConsumedFoods()
        {
            var mostConsumedFood = db.UserFoods
            .Where(userFood => userFood.UserId == user.Id)
            .Join(db.Foods, userFood => userFood.FoodId, food => food.Id, (userFood, food) => new { userFood, food })
            .AsEnumerable()
            .GroupBy(entry => entry.food)
            .OrderByDescending(group => group.Sum(entry => entry.userFood.Amount))
            .Select(group => new
            {
                FoodName = group.Key.Name,
                Amount = group.Sum(entry => entry.userFood.Amount)
            })
            .FirstOrDefault();


            if (mostConsumedFood != null)
            {
                dgvMostConFood.DataSource = new List<object> { mostConsumedFood };
            }
            else
            {
                dgvMostConFood.DataSource = null;
            }


        }


        private void ShowMostConsumedBevs()
        {
            var mostConsumedBevs = db.UserBeverages
           .Where(userBevs => userBevs.UserId == user.Id)
           .Join(db.Beverages, userBevs => userBevs.BeverageId, beverage => beverage.Id, (userBevs, beverage) => new { userBevs, beverage })
           .AsEnumerable()
           .GroupBy(entry => entry.beverage)
           .OrderByDescending(group => group.Sum(entry => entry.userBevs.Amount))
           .Select(group => new
           {
               BeverageName = group.Key.Name,
               Amount = group.Sum(entry => entry.userBevs.Amount)
           })
           .FirstOrDefault();


            if (mostConsumedBevs != null)
            {
                dgvMostConBev.DataSource = new List<object> { mostConsumedBevs };
            }
            else
            {
                dgvMostConBev.DataSource = null;
            }
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form userUI = new UserUI(user);
            userUI.Show();
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form reports = new Reports(user);
            reports.Show();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form logout = new Logout(user);
            logout.Show();
        }
    }
}
