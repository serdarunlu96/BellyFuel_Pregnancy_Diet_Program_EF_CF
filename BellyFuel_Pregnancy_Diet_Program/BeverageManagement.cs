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
    public partial class BeverageManagement : Form
    {
        private readonly User user;
        private readonly BellyFuelDbContext db = new BellyFuelDbContext();

        public BeverageManagement(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void BeverageManagement_Load(object sender, EventArgs e)
        {
            dgvBeverageList.RowTemplate.Height = 100;
            dgvBeverageList.DefaultCellStyle.NullValue = null;
            dgvBeverageList.CellFormatting += dgvBeverageList_CellFormatting;
            LoadBeverageList();
            LoadBeverageCategories();
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

        private void LoadBeverageList()
        {
            dgvBeverageList.AutoGenerateColumns = false;
            dgvBeverageList.Columns.Clear();

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "Id";
            idColumn.DataPropertyName = "Id";
            idColumn.HeaderText = "Id";
            dgvBeverageList.Columns.Add(idColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.Name = "Name";
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Name";
            dgvBeverageList.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn categoryIdColumn = new DataGridViewTextBoxColumn();
            categoryIdColumn.Name = "CategoryId";
            categoryIdColumn.DataPropertyName = "CategoryId";
            categoryIdColumn.HeaderText = "CategoryId";
            dgvBeverageList.Columns.Add(categoryIdColumn);

            DataGridViewTextBoxColumn fatColumn = new DataGridViewTextBoxColumn();
            fatColumn.Name = "Fat";
            fatColumn.DataPropertyName = "Fat";
            fatColumn.HeaderText = "Fat";
            dgvBeverageList.Columns.Add(fatColumn);

            DataGridViewTextBoxColumn proteinColumn = new DataGridViewTextBoxColumn();
            proteinColumn.Name = "Protein";
            proteinColumn.DataPropertyName = "Protein";
            proteinColumn.HeaderText = "Protein";
            dgvBeverageList.Columns.Add(proteinColumn);

            DataGridViewTextBoxColumn sugarColumn = new DataGridViewTextBoxColumn();
            sugarColumn.Name = "Sugar";
            sugarColumn.DataPropertyName = "Sugar";
            sugarColumn.HeaderText = "Sugar";
            dgvBeverageList.Columns.Add(sugarColumn);

            DataGridViewTextBoxColumn carbsColumn = new DataGridViewTextBoxColumn();
            carbsColumn.Name = "Carbs";
            carbsColumn.DataPropertyName = "Carbs";
            carbsColumn.HeaderText = "Carbs";
            dgvBeverageList.Columns.Add(carbsColumn);

            DataGridViewTextBoxColumn sodiumColumn = new DataGridViewTextBoxColumn();
            sodiumColumn.Name = "Sodium";
            sodiumColumn.DataPropertyName = "Sodium";
            sodiumColumn.HeaderText = "Sodium";
            dgvBeverageList.Columns.Add(sodiumColumn);

            DataGridViewTextBoxColumn caloriesColumn = new DataGridViewTextBoxColumn();
            caloriesColumn.Name = "Calories";
            caloriesColumn.DataPropertyName = "Calories";
            caloriesColumn.HeaderText = "Calories";
            dgvBeverageList.Columns.Add(caloriesColumn);

            var Beverages = db.Beverages.Include(b => b.Category).ToList();
            dgvBeverageList.DataSource = Beverages;
        }

        private void LoadBeverageCategories()
        {
            var BeverageCategories = db.BeverageCategories.ToList();
            cboBeverageCategory.DataSource = BeverageCategories;
            cboBeverageCategory.DisplayMember = "CategoryName";
            cboBeverageCategory.ValueMember = "Id";
        }

        private void pbAddBeverage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBeverageName.Text))
            {
                MessageBox.Show("Please enter a valid Beverage name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cboBeverageCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string BeverageName = txtBeverageName.Text.Trim();
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

            int categoryId = (int)cboBeverageCategory.SelectedValue;

            Beverage newBeverage = new Beverage
            {
                Name = BeverageName,
                Fat = fatValue,
                Protein = proteinValue,
                Sugar = sugarValue,
                Carbs = carbsValue,
                Sodium = sodiumValue,
                Calories = caloryValue,
                CategoryId = categoryId
            };

            if (pbBeverageImg.Image != null)
            {
                newBeverage.Photo = ConvertImageToByteArray(pbBeverageImg.Image);
            }

            db.Beverages.Add(newBeverage);
            db.SaveChanges();
            LoadBeverageList();
        }

        private void pbDeleteBeverage_Click(object sender, EventArgs e)
        {
            if (dgvBeverageList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Beverage item to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedBeverageId = (int)dgvBeverageList.SelectedRows[0].Cells["Id"].Value;
            Beverage selectedBeverage = db.Beverages.Find(selectedBeverageId);

            db.Beverages.Remove(selectedBeverage);
            db.SaveChanges();
            LoadBeverageList();
        }

        private void pbUpdateBeverage_Click(object sender, EventArgs e)
        {
            if (dgvBeverageList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Beverage item to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedBeverageId = (int)dgvBeverageList.SelectedRows[0].Cells["Id"].Value;
            Beverage selectedBeverage = db.Beverages.Find(selectedBeverageId);

            if (string.IsNullOrWhiteSpace(txtBeverageName.Text) && string.IsNullOrWhiteSpace(txtFatValue.Text) &&
                string.IsNullOrWhiteSpace(txtProteinValue.Text) && string.IsNullOrWhiteSpace(txtSugarValue.Text) &&
                string.IsNullOrWhiteSpace(txtCarbsValue.Text) && string.IsNullOrWhiteSpace(txtSodiumValue.Text) &&
                string.IsNullOrWhiteSpace(txtCaloryValue.Text))
            {
                MessageBox.Show("Please fill in at least one field to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtBeverageName.Text))
            {
                selectedBeverage.Name = txtBeverageName.Text;
            }

            double fatValue, proteinValue, sugarValue, carbsValue, sodiumValue, caloryValue;

            if (!string.IsNullOrWhiteSpace(txtFatValue.Text) && double.TryParse(txtFatValue.Text, out fatValue))
            {
                selectedBeverage.Fat = fatValue;
            }

            if (!string.IsNullOrWhiteSpace(txtProteinValue.Text) && double.TryParse(txtProteinValue.Text, out proteinValue))
            {
                selectedBeverage.Protein = proteinValue;
            }

            if (!string.IsNullOrWhiteSpace(txtSugarValue.Text) && double.TryParse(txtSugarValue.Text, out sugarValue))
            {
                selectedBeverage.Sugar = sugarValue;
            }

            if (!string.IsNullOrWhiteSpace(txtCarbsValue.Text) && double.TryParse(txtCarbsValue.Text, out carbsValue))
            {
                selectedBeverage.Carbs = carbsValue;
            }

            if (!string.IsNullOrWhiteSpace(txtSodiumValue.Text) && double.TryParse(txtSodiumValue.Text, out sodiumValue))
            {
                selectedBeverage.Sodium = sodiumValue;
            }

            if (!string.IsNullOrWhiteSpace(txtCaloryValue.Text) && double.TryParse(txtCaloryValue.Text, out caloryValue))
            {
                selectedBeverage.Calories = caloryValue;
            }

            int categoryId = (int)cboBeverageCategory.SelectedValue;
            selectedBeverage.CategoryId = categoryId;

         
            if (pbBeverageImg.Image == null)
            {
                MessageBox.Show("Please select an image for the Beverage item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            selectedBeverage.Photo = ConvertImageToByteArray(pbBeverageImg.Image);

            db.SaveChanges();
            LoadBeverageList();
        }


        private void pbAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Category name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool categoryExists = db.BeverageCategories.Any(bc => bc.CategoryName == categoryName);

            if (categoryExists)
            {
                MessageBox.Show("This category already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BeverageCategory newCategory = new BeverageCategory
            {
                CategoryName = categoryName
            };

            db.BeverageCategories.Add(newCategory);
            db.SaveChanges();
            LoadBeverageList();
            LoadBeverageCategories();
            cboBeverageCategory.SelectedItem = newCategory;
        }

        private void pbDeleteCategory_Click(object sender, EventArgs e)
        {
            BeverageCategory selectedCategory = (BeverageCategory)cboBeverageCategory.SelectedItem;

            if (selectedCategory == null)
            {
                MessageBox.Show("Please select a category to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Entry(selectedCategory).Collection(c => c.Beverages).Load();

            if (selectedCategory.Beverages.Any())
            {
                MessageBox.Show("Cannot delete a category that contains Beverages.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.BeverageCategories.Remove(selectedCategory);
            db.SaveChanges();
            LoadBeverageList();
            LoadBeverageCategories();
        }

        private void pbUpdateCategory_Click(object sender, EventArgs e)
        {
            BeverageCategory selectedCategory = (BeverageCategory)cboBeverageCategory.SelectedItem;

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
            LoadBeverageList();
            LoadBeverageCategories();
            cboBeverageCategory.SelectedItem = selectedCategory;
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
                        pbBeverageImg.Image = Image.FromFile(imagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error importing photo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvBeverageList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBeverageList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBeverageList.SelectedRows[0];

                if (selectedRow.DataBoundItem is Beverage Beverage)
                {
                    int id = Beverage.Id;
                    string name = Beverage.Name;
                    double fat = Beverage.Fat;
                    double protein = Beverage.Protein;
                    double sugar = Beverage.Sugar;
                    double carbs = Beverage.Carbs;
                    double sodium = Beverage.Sodium;
                    int categoryId = Beverage.CategoryId;

                    txtBeverageName.Text = name;
                    txtFatValue.Text = fat.ToString();
                    txtProteinValue.Text = protein.ToString();
                    txtSugarValue.Text = sugar.ToString();
                    txtCarbsValue.Text = carbs.ToString();
                    txtSodiumValue.Text = sodium.ToString();

                    cboBeverageCategory.SelectedValue = categoryId;

                    byte[] photoData = Beverage.Photo;
                    if (photoData != null)
                    {
                        try
                        {
                            using (var memoryStream = new MemoryStream(photoData))
                            {
                                pbBeverageImg.Image = Image.FromStream(memoryStream);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading photo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            pbBeverageImg.Image = null;
                        }
                    }
                    else
                    {
                        pbBeverageImg.Image = null;
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

        private void dgvBeverageList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBeverageList.Columns[e.ColumnIndex].Name == "Photo" && e.Value != null && e.Value is byte[])
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
