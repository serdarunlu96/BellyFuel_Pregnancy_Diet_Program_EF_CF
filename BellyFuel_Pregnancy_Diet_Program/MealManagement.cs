using BellyFuel_Pregnancy_Diet_Program.Context;
using BellyFuel_Pregnancy_Diet_Program.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BellyFuel_Pregnancy_Diet_Program
{
    public partial class MealManagement : Form
    {

        private readonly User user;
        BellyFuelDbContext db = new BellyFuelDbContext();
        UserFood selectedUserFood;
        UserBeverage selectedUserBeverage;

        public MealManagement(User user)
        {
            InitializeComponent();
            this.user = user;
            ListMeals();
            ListFoods();
            ListBeverages();
            ListFoodCategories();
            ListBeverageCategories();
            ListUserFoods();
            ListUserBeverages();
        }

        private void ListFoodCategories()
        {
            cboFoodCategory.DataSource = db.FoodCategories.ToList();
            


        }

        private void ListBeverageCategories()
        {
            cboBevCategory.DataSource = db.BeverageCategories.ToList();
            
        }

        private void ListBeverages()
        {
            if (!(cboBevCategory.SelectedItem == null))
            {
                var selectedCategory = (BeverageCategory)cboBevCategory.SelectedValue;
                var bev = db.Beverages.Where(bev => bev.CategoryId == selectedCategory.Id).ToList();
                cmbBeverageSelect.DataSource = bev;
              
            }

        }

        private void ListFoods()
        {
            if (!(cboFoodCategory.SelectedItem == null))
            {
                var selectedCategory = (FoodCategory)cboFoodCategory.SelectedValue;
                var foods = db.Foods.Where(food => food.CategoryId == selectedCategory.Id).ToList();
                cmbFoodSelect.DataSource = foods;
               
            }
        }

        private void ListMeals()
        {
            cmbMealSelect.DataSource = db.Meals.ToList();
            
        }


        private void pbAddMeal_Click(object sender, EventArgs e)
        {
            var selectedMeal = (Meal)cmbMealSelect.SelectedItem;
            var selectedFood = (Food)cmbFoodSelect.SelectedItem;
            var selectedBeverage = (Beverage)cmbBeverageSelect.SelectedItem;
            var selectedFoodCategory = (FoodCategory)cboFoodCategory.SelectedItem;
            var selectedBeverageCategory = (BeverageCategory)cboBevCategory.SelectedItem;
            int foodAmount = (int)numFood.Value;
            int beverageAmount = (int)numBeverage.Value;



            if ((selectedFood != null && selectedBeverage == null) || (selectedFood == null && selectedBeverage != null) || (selectedFood != null && selectedBeverage != null))
            {
                UserFood userFood = new UserFood()
                {
                    FoodId = selectedFood.Id,
                    MealId = selectedMeal.Id,
                    Date = DateTime.Now,
                    Amount = foodAmount,
                    UserId = user.Id
                };


                UserBeverage userBeverage = new UserBeverage()
                {
                    BeverageId = selectedBeverage.Id,
                    MealId = selectedMeal.Id,
                    Date = DateTime.Now,
                    Amount = beverageAmount,
                    UserId = user.Id
                };



                if (numBeverage.Value > 0) { db.UserBeverages.Add(userBeverage); }



                if (numFood.Value > 0) { db.UserFoods.Add(userFood); }



                if (numFood.Value > 0 && numBeverage.Value == 0)
                {
                    MessageBox.Show($"{numFood.Value} pcs {cmbFoodSelect.Text} added to {cmbMealSelect.Text} without any drink");
                }
                if (numFood.Value == 0 && numBeverage.Value > 0)
                {
                    MessageBox.Show($"{numBeverage.Value} pcs {cmbBeverageSelect.Text} added to {cmbMealSelect.Text} without any food");
                }
                if (numBeverage.Value > 0 && numFood.Value > 0)
                {
                    MessageBox.Show($"{numFood.Value} pcs {cmbFoodSelect.Text} and {numBeverage.Value} pcs {cmbBeverageSelect.Text} added to {cmbMealSelect.Text}");
                }
                if (numBeverage.Value == 0 && numFood.Value == 0)
                {
                    MessageBox.Show($"Nothing has been added to the {cmbMealSelect.Text}");
                }



                db.SaveChanges();
            }
            else
                MessageBox.Show("Please select any item which you want to update!");




            dgvBeverageList.DataSource = null;
         


            dgvFoodList.DataSource = null;



            var userFoods = db.UserFoods.Where(uu => uu.UserId == user.Id).ToList();
            var userBeverages = db.UserBeverages.Where(uu => uu.UserId == user.Id).ToList();


            ListUserFoods();
            ListUserBeverages();
        }
        private void HideFoodColumns()
        {
            dgvFoodList.Columns[0].Visible = false;
            dgvFoodList.Columns[1].Visible = false;
            dgvFoodList.Columns[2].Visible = false;
            dgvFoodList.Columns[4].Visible = false;
            dgvFoodList.Columns[6].Visible = false;
        }
        private void HideBeverageColumns()
        {
            dgvBeverageList.Columns[0].Visible = false;
            dgvBeverageList.Columns[1].Visible = false;
            dgvBeverageList.Columns[2].Visible = false;
            dgvBeverageList.Columns[3].Visible = false;
            dgvBeverageList.Columns[5].Visible = false;
        }

        private void ListUserFoods()
        {
            dgvFoodList.DataSource = null;
            dgvFoodList.DataSource = db.UserFoods.ToList();


            HideFoodColumns();
            dgvFoodList.Refresh();

        }

        private void ListUserBeverages()
        {
            dgvBeverageList.DataSource = null;
            dgvBeverageList.DataSource = db.UserBeverages.ToList();

            HideBeverageColumns();
            dgvBeverageList.Refresh();
        }


        private void pbMealManagement_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form userUI = new UserUI(user);
            userUI.Show();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form logout = new Logout(user);
            logout.Show();
        }
        private void pbUpFood_Click(object sender, EventArgs e)
        {
            var selectedMeal = (Meal)cmbMealSelect.SelectedItem;
            var selectedFood = (Food)cmbFoodSelect.SelectedItem;
            int foodAmount = (int)numFood.Value;
            if (selectedUserFood != null)
            {
                selectedUserFood.FoodId = selectedFood.Id;
                selectedUserFood.MealId = selectedMeal.Id;
                selectedUserFood.Amount = foodAmount;

                db.SaveChanges();
                ListUserFoods();
            }
            else
                MessageBox.Show("Please select the data which you want to UPDATE!");
        }


        private void pbUpBeverage_Click(object sender, EventArgs e)
        {

            var selectedMeal = (Meal)cmbMealSelect.SelectedItem;
            var selectedBeverage = (Beverage)cmbBeverageSelect.SelectedItem;

            int beverageAmount = (int)numBeverage.Value;
            if (selectedUserBeverage != null)
            {
                selectedUserBeverage.BeverageId = selectedBeverage.Id;
                selectedUserBeverage.MealId = selectedMeal.Id;
                selectedUserBeverage.Amount = beverageAmount;

                db.SaveChanges();
                ListUserBeverages();
            }
            else
                MessageBox.Show("Please select the data which you want to UPDATE!");
        }

        private void cboFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListFoods();
        }

        private void cboBevCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBeverages();
        }

        private void dgvFoodList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUserFood = (UserFood)dgvFoodList.SelectedRows[0].DataBoundItem;
            cboFoodCategory.SelectedItem = selectedUserFood.Food.Category;
            cmbMealSelect.SelectedItem = selectedUserFood.Meal;
            cmbFoodSelect.SelectedItem = selectedUserFood.Food;
            numFood.Value = selectedUserFood.Amount;

           
            if (selectedUserFood.Food.Photo != null)
            {
                using (MemoryStream ms = new MemoryStream(selectedUserFood.Food.Photo))
                {
                    pbFood.Image = Image.FromStream(ms);
                }
            }
            else
            {
               
                pbFood.Image = null;
            }
        }

        private void dgvBeverageList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUserBeverage = (UserBeverage)dgvBeverageList.SelectedRows[0].DataBoundItem;
            cboBevCategory.SelectedItem = selectedUserBeverage.Beverage.Category;
            cmbMealSelect.SelectedItem = selectedUserBeverage.Meal;
            cmbBeverageSelect.SelectedItem = selectedUserBeverage.Beverage;
            numBeverage.Value = selectedUserBeverage.Amount;

           
            if (selectedUserBeverage.Beverage.Photo != null)
            {
                using (MemoryStream ms = new MemoryStream(selectedUserBeverage.Beverage.Photo))
                {
                    pbBeverage.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbBeverage.Image = null;
            }
        }

        private void pbDeleteFood_Click(object sender, EventArgs e)
        {

            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dgvFoodList.SelectedRows)
            {
                selectedRows.Add(row);
            }

            foreach (DataGridViewRow row in selectedRows)
            {
                if (!row.IsNewRow && row.DataBoundItem is UserFood selectedFood)
                {
                    db.UserFoods.Remove(selectedFood);
                }
            }

            db.SaveChanges();

            dgvFoodList.DataSource = db.UserFoods.Where(u => u.UserId == user.Id).ToList();

        }
        private void pbDeleteBev_Click(object sender, EventArgs e)
        {

            List<DataGridViewRow> selectedRows = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dgvBeverageList.SelectedRows)
            {
                selectedRows.Add(row);
            }

            foreach (DataGridViewRow row in selectedRows)
            {
                if (!row.IsNewRow && row.DataBoundItem is UserBeverage selectedBeverage)
                {
                    db.UserBeverages.Remove(selectedBeverage);
                }
            }

            db.SaveChanges();

            dgvBeverageList.DataSource = db.UserBeverages.Where(u => u.UserId == user.Id).ToList();


        }

        private void MealManagement_Load(object sender, EventArgs e)
        {
            dgvFoodList.ClearSelection();
            dgvBeverageList.ClearSelection();
        }
    }
}
