using BellyFuel_Pregnancy_Diet_Program.Context;
using BellyFuel_Pregnancy_Diet_Program.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BellyFuel_Pregnancy_Diet_Program.SeedData
{
    public class BellyFuelDbContextSeed
    {

        public static void Seed()
        {
            using (var db = new BellyFuelDbContext())
            {

                #region Roles

                if (db.Roles.Any())
                    return;

                var admin = new Role() { RoleName = "Administrator" };
                var user = new Role() {  RoleName = "User" };

                var roles = new Role[] { admin, user };

                db.AddRange(roles);
                db.SaveChanges();

                #endregion

                #region FoodCategories

                if (db.FoodCategories.Any())
                    return;

                var fruits = new FoodCategory() { CategoryName = "Fruits", Description = "Fruit" }; // meyve yiyecek  -- ID 5

                var vegetables = new FoodCategory() { CategoryName = "Vegetables", Description = "Vegetable" }; // Sebze yiyecek  -- ID 6

                var desserts = new FoodCategory() { CategoryName = "Desserts", Description = "Desserts" }; // Tatlı yiyecek  -- ID 7

                var meats = new FoodCategory() { CategoryName = "Meats", Description = "Meat" }; // etli yiyecek  -- ID 8


                var foodcategories = new FoodCategory[] { fruits, vegetables, desserts, meats };

                db.AddRange(foodcategories);
                db.SaveChanges();

                #endregion

                #region BeverageCategories

                if (db.BeverageCategories.Any())
                    return;

                var softDrink = new BeverageCategory() { CategoryName = "SoftDrink", Description = "SoftDrink" }; // gazlı ıcecek  -- ID 1
                var coldDrink = new BeverageCategory() { CategoryName = "ColdDrink", Description = "ColdDrink" }; // soguk ıcecek  -- ID 2
                var hotDrink = new BeverageCategory() { CategoryName = "HotDrink", Description = "HotDrink" }; // sıcak ıcecek  -- ID 3
                var nonSoftDrink = new BeverageCategory() { CategoryName = "NonSoftDrink", Description = "NonSoftDrink" }; // gazlı olmayan ıcecek  -- ID 4


                var bevcategories = new BeverageCategory[] { softDrink, coldDrink, hotDrink, nonSoftDrink };

                db.AddRange(bevcategories);
                db.SaveChanges();

                #endregion

                #region Beverages

                if (db.Beverages.Any())
                    return;

                var water = new Beverage() { Name = "Water", Photo = null, CategoryId = 4, Calories = 0, Fat = 0, Protein = 0, Sugar = 0, Carbs = 0, Sodium = 0 };
                var milk = new Beverage() { Name = "Milk", Photo = null, CategoryId = 1, Calories = 103, Fat = 2.4, Protein = 8, Sugar = 12, Carbs = 12, Sodium = 0.107 };
                var orangeJuice = new Beverage() { Name = "Orange Juice", Photo = null, CategoryId = 2, Calories = 112, Fat = 0.5, Protein = 2, Sugar = 20, Carbs = 26, Sodium = 0 };
                var lemonade = new Beverage() { Name = "Lemonade", Photo = null, CategoryId = 2, Calories = 120, Fat = 0, Protein = 0, Sugar = 30, Carbs = 31, Sodium = 0.02 };
                var greenTea = new Beverage() { Name = "Green Tea", Photo = null, CategoryId = 3, Calories = 0, Fat = 0, Protein = 0, Sugar = 0, Carbs = 0, Sodium = 0 };
                var ayran = new Beverage() { Name = "Ayran", Photo = null, CategoryId = 2, Calories = 80, Fat = 3, Protein = 5, Sugar = 6, Carbs = 8, Sodium = 0.152 };
                var soda = new Beverage() { Name = "Soda", Photo = null, CategoryId = 1, Calories = 0, Fat = 0, Protein = 0, Sugar = 0, Carbs = 0, Sodium = 0 };


                var beverages = new Beverage[] { water, milk, orangeJuice, lemonade, greenTea, ayran, soda };

                db.AddRange(beverages);
                db.SaveChanges();


                #endregion

                #region Foods

                if (db.Foods.Any())
                    return;

                var apple = new Food() { Name = "Apple", Photo = null, CategoryId = 1, Calories = 95, Fat = 0, Protein = 0.5, Sugar = 19, Carbs = 25, Sodium = 0 };
                var orange = new Food() { Name = "Orange", Photo = null, CategoryId = 1, Calories = 36, Fat = 0.1, Protein = 0.7, Sugar = 7, Carbs = 8, Sodium = 0.001 };
                var zucchini = new Food() { Name = "Zucchini", Photo = null, CategoryId = 2, Calories = 55, Fat = 1, Protein = 3.9, Sugar = 8.1, Carbs = 10.1, Sodium = 0 };
                var carrot = new Food() { Name = "Carrot", Photo = null, CategoryId = 2, Calories = 25, Fat = 0, Protein = 1, Sugar = 3, Carbs = 6, Sodium = 0.42 };
                var pea = new Food() { Name = "Pea", Photo = null, CategoryId = 2, Calories = 25, Fat = 0, Protein = 1, Sugar = 2, Carbs = 4, Sodium = 0.05 };
                var chicken = new Food() { Name = "Chicken", Photo = null, CategoryId = 4, Calories = 211, Fat = 7, Protein = 36, Sugar = 0, Carbs = 0, Sodium = 0.42 };
                var beef = new Food() { Name = "Beef", Photo = null, CategoryId = 4, Calories = 170, Fat = 8, Protein = 23, Sugar = 0, Carbs = 0, Sodium = 75 };
                var salmon = new Food() { Name = "Salmon", Photo = null, CategoryId = 4, Calories = 0, Fat = 0, Protein = 0, Sugar = 0, Carbs = 0, Sodium = 0 };
                var baklava = new Food() { Name = "Baklava", Photo = null, CategoryId = 3, Calories = 200, Fat = 12, Protein = 2, Sugar = 12, Carbs = 22, Sodium = 0.05 };
                var chocolate = new Food() { Name = "Chocolate", Photo = null, CategoryId = 3, Calories = 110, Fat = 7, Protein = 1, Sugar = 12, Carbs = 12, Sodium = 0.03 };
                var icecream = new Food() { Name = "Icecream", Photo = null, CategoryId = 3, Calories = 200, Fat = 12, Protein = 3, Sugar = 20, Carbs = 25, Sodium = 0.03 };

                var foods = new Food[] { apple, orange, zucchini, carrot, pea, chicken, beef, salmon, baklava, chocolate, icecream };

                db.AddRange(foods);
                db.SaveChanges();


                #endregion

                #region Meals

                if (db.Meals.Any())
                    return;

                Meal breakfast = new Meal() { MealName = "Breakfast" };

                Meal lunch = new Meal() { MealName = "Lunch" };

                Meal dinner = new Meal() { MealName = "Dinner" };

                Meal snacks = new Meal() { MealName = "Snacks" };

                db.Meals.Add(breakfast);

                db.Meals.Add(lunch);

                db.Meals.Add(dinner);

                db.Meals.Add(snacks);

                db.SaveChanges();

                #endregion
            }

        }
    }
}

