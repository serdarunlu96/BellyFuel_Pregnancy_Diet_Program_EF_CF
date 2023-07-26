using BellyFuel_Pregnancy_Diet_Program.Context;
using BellyFuel_Pregnancy_Diet_Program.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BellyFuel_Pregnancy_Diet_Program
{
    public partial class FoodManagement : Form
    {
        private readonly User user;
        private readonly BellyFuelDbContext db = new BellyFuelDbContext();

        public FoodManagement(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FoodManagement_Load(object sender, EventArgs e)
        {
            dgvFoodList.RowTemplate.Height = 100;
            dgvFoodList.DefaultCellStyle.NullValue = null;
            dgvFoodList.CellFormatting += dgvFoodList_CellFormatting;
            LoadFoodList();
            LoadFoodCategories();
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                using (Bitmap bitmap = new Bitmap(image)) 
                {
                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                }

                ms.Position = 0; 
                return ms.ToArray();
            }
        }

        private void LoadFoodList()
        {
            dgvFoodList.AutoGenerateColumns = false;
            dgvFoodList.Columns.Clear();

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "Id";
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "Id";
            dgvFoodList.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            dgvFoodList.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn categoryIdColumn = new DataGridViewTextBoxColumn();
            categoryIdColumn.Name = "CategoryId";
            categoryIdColumn.DataPropertyName = "CategoryId";
            categoryIdColumn.HeaderText = "CategoryId";
            dgvFoodList.Columns.Add(categoryIdColumn);

            DataGridViewTextBoxColumn fatColumn = new DataGridViewTextBoxColumn();
            fatColumn.Name = "Fat";
            fatColumn.DataPropertyName = "Fat";
            fatColumn.HeaderText = "Fat";
            dgvFoodList.Columns.Add(fatColumn);

            DataGridViewTextBoxColumn proteinColumn = new DataGridViewTextBoxColumn();
            proteinColumn.Name = "Protein";
            proteinColumn.DataPropertyName = "Protein";
            proteinColumn.HeaderText = "Protein";
            dgvFoodList.Columns.Add(proteinColumn);

            DataGridViewTextBoxColumn sugarColumn = new DataGridViewTextBoxColumn();
            sugarColumn.Name = "Sugar";
            sugarColumn.DataPropertyName = "Sugar";
            sugarColumn.HeaderText = "Sugar";
            dgvFoodList.Columns.Add(sugarColumn);

            DataGridViewTextBoxColumn carbsColumn = new DataGridViewTextBoxColumn();
            carbsColumn.Name = "Carbs";
            carbsColumn.DataPropertyName = "Carbs";
            carbsColumn.HeaderText = "Carbs";
            dgvFoodList.Columns.Add(carbsColumn);

            DataGridViewTextBoxColumn sodiumColumn = new DataGridViewTextBoxColumn();
            sodiumColumn.Name = "Sodium";
            sodiumColumn.DataPropertyName = "Sodium";
            sodiumColumn.HeaderText = "Sodium";
            dgvFoodList.Columns.Add(sodiumColumn);

            DataGridViewTextBoxColumn caloriesColumn = new DataGridViewTextBoxColumn();
            caloriesColumn.Name = "Calories";
            caloriesColumn.DataPropertyName = "Calories";
            caloriesColumn.HeaderText = "Calories";
            dgvFoodList.Columns.Add(caloriesColumn);

            var foods = db.Foods.Include(b => b.Category).ToList();
            dgvFoodList.DataSource = foods;

          
        }

        private void LoadFoodCategories()
        {
            var foodCategories = db.FoodCategories.ToList();
            cboFoodCategory.DataSource = foodCategories;
            cboFoodCategory.DisplayMember = "CategoryName";
            cboFoodCategory.ValueMember = "Id";
        }

        private void pbAddFood_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                MessageBox.Show("Please enter a valid food name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboFoodCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string foodName = txtFoodName.Text.Trim();
            double fatValue, proteinValue, sugarValue, carbsValue, sodiumValue, caloryValue;

            if (!double.TryParse(txtFatValue.Text, out fatValue) ||
                !double.TryParse(txtProteinValue.Text, out proteinValue) ||
                !double.TryParse(txtSugarValue.Text, out sugarValue) ||
                !double.TryParse(txtCarbsValue.Text, out carbsValue) ||
                !double.TryParse(txtSodiumValue.Text, out sodiumValue) ||
                !double.TryParse(txtCaloryValue.Text, out caloryValue))
            {
                MessageBox.Show("Invalid numeric values. Please enter valid numbers for Fat, Protein, Sugar, Carbs, Sodium and Calory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int categoryId = (int)cboFoodCategory.SelectedValue;

            Food newFood = new Food
            {
                Name = foodName,
                Fat = fatValue,
                Protein = proteinValue,
                Sugar = sugarValue,
                Carbs = carbsValue,
                Sodium = sodiumValue,
                Calories = caloryValue,
                CategoryId = categoryId
            };

            if (pbFoodImg.Image != null)
            {
                newFood.Photo = ConvertImageToByteArray(pbFoodImg.Image);
            }

            db.Foods.Add(newFood);
            db.SaveChanges();
            LoadFoodList();
        }

        private void pbDeleteFood_Click(object sender, EventArgs e)
        {
            if (dgvFoodList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a food item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedFoodId = (int)dgvFoodList.SelectedRows[0].Cells["Id"].Value;
            Food selectedFood = db.Foods.Find(selectedFoodId);

            db.Foods.Remove(selectedFood);
            db.SaveChanges();
            LoadFoodList();
        }

        private void pbUpdateFood_Click(object sender, EventArgs e)
        {
            if (dgvFoodList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a food item to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedFoodId = (int)dgvFoodList.SelectedRows[0].Cells["Id"].Value;
            Food selectedFood = db.Foods.Find(selectedFoodId);

            if (string.IsNullOrWhiteSpace(txtFoodName.Text) && string.IsNullOrWhiteSpace(txtFatValue.Text) &&
                string.IsNullOrWhiteSpace(txtProteinValue.Text) && string.IsNullOrWhiteSpace(txtSugarValue.Text) &&
                string.IsNullOrWhiteSpace(txtCarbsValue.Text) && string.IsNullOrWhiteSpace(txtSodiumValue.Text) &&
                string.IsNullOrWhiteSpace(txtCaloryValue.Text))
            {
                MessageBox.Show("Please fill in at least one field to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                selectedFood.Name = txtFoodName.Text;
            }

            double fatValue, proteinValue, sugarValue, carbsValue, sodiumValue, caloryValue;

            if (!string.IsNullOrWhiteSpace(txtFatValue.Text) && double.TryParse(txtFatValue.Text, out fatValue))
            {
                selectedFood.Fat = fatValue;
            }

            if (!string.IsNullOrWhiteSpace(txtProteinValue.Text) && double.TryParse(txtProteinValue.Text, out proteinValue))
            {
                selectedFood.Protein = proteinValue;
            }

            if (!string.IsNullOrWhiteSpace(txtSugarValue.Text) && double.TryParse(txtSugarValue.Text, out sugarValue))
            {
                selectedFood.Sugar = sugarValue;
            }

            if (!string.IsNullOrWhiteSpace(txtCarbsValue.Text) && double.TryParse(txtCarbsValue.Text, out carbsValue))
            {
                selectedFood.Carbs = carbsValue;
            }

            if (!string.IsNullOrWhiteSpace(txtSodiumValue.Text) && double.TryParse(txtSodiumValue.Text, out sodiumValue))
            {
                selectedFood.Sodium = sodiumValue;
            }

            if (!string.IsNullOrWhiteSpace(txtCaloryValue.Text) && double.TryParse(txtCaloryValue.Text, out caloryValue))
            {
                selectedFood.Calories = caloryValue;
            }

            int categoryId = (int)cboFoodCategory.SelectedValue;
            selectedFood.CategoryId = categoryId;

          
            if (pbFoodImg.Image == null)
            {
                MessageBox.Show("Please select an image for the food item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedFood.Photo = ConvertImageToByteArray(pbFoodImg.Image);

            db.SaveChanges();
            LoadFoodList();
        }


        private void pbAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Category name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool categoryExists = db.FoodCategories.Any(bc => bc.CategoryName == categoryName);

            if (categoryExists)
            {
                MessageBox.Show("This category already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FoodCategory newCategory = new FoodCategory
            {
                CategoryName = categoryName
            };

            db.FoodCategories.Add(newCategory);
            db.SaveChanges();
            LoadFoodList();
            LoadFoodCategories();
            cboFoodCategory.SelectedItem = newCategory;
        }

        private void pbDeleteCategory_Click(object sender, EventArgs e)
        {
            FoodCategory selectedCategory = (FoodCategory)cboFoodCategory.SelectedItem;

            if (selectedCategory == null)
            {
                MessageBox.Show("Please select a category to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Entry(selectedCategory).Collection(c => c.Foods).Load();

            if (selectedCategory.Foods.Any())
            {
                MessageBox.Show("Cannot delete a category that contains Foods.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.FoodCategories.Remove(selectedCategory);
            db.SaveChanges();
            LoadFoodList();
            LoadFoodCategories();
        }

        private void pbUpdateCategory_Click(object sender, EventArgs e)
        {
            FoodCategory selectedCategory = (FoodCategory)cboFoodCategory.SelectedItem;

            if (selectedCategory == null)
            {
                MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string categoryName = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Category name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedCategory.CategoryName = categoryName;

            db.SaveChanges();
            LoadFoodList();
            LoadFoodCategories();
            cboFoodCategory.SelectedItem = selectedCategory;
        }

        private void btnImportPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string imagePath = openFileDialog.FileName;
                        pbFoodImg.Image = Image.FromFile(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error importing photo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvFoodList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];

                if (selectedRow.DataBoundItem is Food food)
                {
                    int id = food.Id;
                    string name = food.Name;
                    double fat = food.Fat;
                    double protein = food.Protein;
                    double sugar = food.Sugar;
                    double carbs = food.Carbs;
                    double sodium = food.Sodium;
                    int categoryId = food.CategoryId;

                    txtFoodName.Text = name;
                    txtFatValue.Text = fat.ToString();
                    txtProteinValue.Text = protein.ToString();
                    txtSugarValue.Text = sugar.ToString();
                    txtCarbsValue.Text = carbs.ToString();
                    txtSodiumValue.Text = sodium.ToString();

                    cboFoodCategory.SelectedValue = categoryId;

                    byte[] photoData = food.Photo;
                    if (photoData != null)
                    {
                        try
                        {
                            using (var memoryStream = new MemoryStream(photoData))
                            {
                                pbFoodImg.Image = Image.FromStream(memoryStream);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading photo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            pbFoodImg.Image = null;
                        }
                    }
                    else
                    {
                        pbFoodImg.Image = null;
                    }
                }
            }
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form adminUI = new AdminUI(user);
            adminUI.Show();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form logout = new Logout(user);
            logout.Show();
        }

        private void dgvFoodList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvFoodList.Columns[e.ColumnIndex].Name == "Photo" && e.Value != null && e.Value is byte[])
            {
                byte[] photoData = (byte[])e.Value;
                if (photoData.Length > 0)
                {
                    try
                    {
                        using (var memoryStream = new MemoryStream(photoData))
                        {
                            e.Value = Image.FromStream(memoryStream);
                        }
                    }
                    catch (Exception)
                    {
                        e.Value = null;
                    }
                }
                else
                {
                    e.Value = null;
                }
            }
        }

        private bool ByteArrayCompare(byte[] a1, byte[] a2)
        {
            if (a1 == a2)
                return true;

            if (a1 == null || a2 == null)
                return false;

            if (a1.Length != a2.Length)
                return false;

            for (int i = 0; i < a1.Length; i++)
            {
                if (a1[i] != a2[i])
                    return false;
            }

            return true;
        }
    }
}
