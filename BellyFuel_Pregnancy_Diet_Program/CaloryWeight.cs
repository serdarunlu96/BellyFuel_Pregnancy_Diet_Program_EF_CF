using BellyFuel_Pregnancy_Diet_Program.Context;
using BellyFuel_Pregnancy_Diet_Program.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = BellyFuel_Pregnancy_Diet_Program.Data.User;


namespace BellyFuel_Pregnancy_Diet_Program
{
    public partial class CaloryWeight : Form
    {
        private readonly User user;
        BellyFuelDbContext db = new BellyFuelDbContext();

        public CaloryWeight(User user)
        {
            InitializeComponent();
            this.user = user;
            ShowUserName();
        }

        private void ShowUserName()
        {
            lblName.Text = user.Name;
        }

        private void CaloryWeight_Load(object sender, EventArgs e)
        {
            CalculateCaloriesByMeal();
        }

        private void CalculateCaloriesByMeal()
        {
            DateTime selectedDate = dtpSelectDate.Value.Date;

            using (var db = new BellyFuelDbContext())
            {
                double breakfastFoodCalories = db.UserFoods
                    .Where(m => m.Meal.MealName == "Breakfast")
                    .Where(uf => uf.Date.Date == selectedDate)
                    .Sum(uf => uf.Amount * uf.Food.Calories);

                double lunchFoodCalories = db.UserFoods
                    .Where(m => m.Meal.MealName == "Lunch")
                    .Where(uf => uf.Date.Date == selectedDate)
                    .Sum(uf => uf.Food.Calories * uf.Amount);

                double dinnerFoodCalories = db.UserFoods
                    .Where(m => m.Meal.MealName == "Dinner")
                    .Where(uf => uf.Date.Date == selectedDate)
                    .Sum(uf => uf.Food.Calories * uf.Amount);


                double snackFoodCalories = db.UserFoods
                    .Where(m => m.Meal.MealName == "Snacks")
                    .Where(uf => uf.Date.Date == selectedDate)
                    .Sum(uf => uf.Food.Calories * uf.Amount);


                double breakfastBeverageCalories = db.UserBeverages
                    .Where(m => m.Meal.MealName == "Breakfast")
                    .Where(ub => ub.Date.Date == selectedDate)
                    .Sum(ub => ub.Beverage.Calories * ub.Amount);


                double lunchBeverageCalories = db.UserBeverages
                    .Where(m => m.Meal.MealName == "Lunch")
                    .Where(ub => ub.Date.Date == selectedDate)
                    .Sum(ub => ub.Beverage.Calories * ub.Amount);


                double dinnerBeverageCalories = db.UserBeverages
                    .Where(m => m.Meal.MealName == "Dinner")
                    .Where(ub => ub.Date.Date == selectedDate)
                    .Sum(ub => ub.Beverage.Calories * ub.Amount);


                double snackBeverageCalories = db.UserBeverages
                    .Where(m => m.Meal.MealName == "Snacks")
                    .Where(ub => ub.Date.Date == selectedDate)
                    .Sum(ub => ub.Beverage.Calories * ub.Amount);


                double totalBreakfastCalories = breakfastFoodCalories + breakfastBeverageCalories;
                double totalLunchCalories = lunchFoodCalories + lunchBeverageCalories;
                double totalDinnerCalories = dinnerFoodCalories + dinnerBeverageCalories;
                double totalSnackCalories = snackFoodCalories + snackBeverageCalories;
                double totalCalories = totalBreakfastCalories + totalLunchCalories + totalDinnerCalories + totalSnackCalories;

                lblSnacks.Text = totalSnackCalories.ToString();
                lblBreakfast.Text = totalBreakfastCalories.ToString();
                lblDinner.Text = totalDinnerCalories.ToString();
                lblLunch.Text = totalLunchCalories.ToString();
                lblTotalCalory.Text = totalCalories.ToString();
            }
        }


        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form logout = new Logout(user);
            logout.Show();
        }
        private void pbMealManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form userUI = new UserUI(user);
            userUI.Show();
        }


        private void pbReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form rp = new Reports(user);
            rp.Show();
        }

        private void dtpSelectDate_ValueChanged(object sender, EventArgs e)
        {
            CalculateCaloriesByMeal();
        }

        private void pbMealMan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form mealManagement = new MealManagement(user);
            mealManagement.Show();
        }
    }

}
