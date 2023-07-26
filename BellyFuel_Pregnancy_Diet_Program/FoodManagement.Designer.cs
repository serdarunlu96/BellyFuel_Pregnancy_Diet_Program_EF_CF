namespace BellyFuel_Pregnancy_Diet_Program
{
    partial class FoodManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvFoodList = new DataGridView();
            cboFoodCategory = new ComboBox();
            label9 = new Label();
            label4 = new Label();
            txtFoodName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCarbsValue = new TextBox();
            pbDeleteCategory = new PictureBox();
            label3 = new Label();
            pbDeleteFood = new PictureBox();
            pbHome = new PictureBox();
            label10 = new Label();
            label12 = new Label();
            pbLogout = new PictureBox();
            label11 = new Label();
            pbUpdateFood = new PictureBox();
            pbUpdateCategory = new PictureBox();
            label14 = new Label();
            label8 = new Label();
            label7 = new Label();
            pbAddCategory = new PictureBox();
            label6 = new Label();
            pbAddFood = new PictureBox();
            panel1 = new Panel();
            label5 = new Label();
            txtFatValue = new TextBox();
            label13 = new Label();
            txtProteinValue = new TextBox();
            label15 = new Label();
            txtSodiumValue = new TextBox();
            label16 = new Label();
            txtSugarValue = new TextBox();
            label17 = new Label();
            txtCategoryName = new TextBox();
            pbFoodImg = new PictureBox();
            btnImportPhoto = new Button();
            label18 = new Label();
            txtCaloryValue = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFoodList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddCategory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddFood).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoodImg).BeginInit();
            SuspendLayout();
            // 
            // dgvFoodList
            // 
            dgvFoodList.AllowUserToAddRows = false;
            dgvFoodList.AllowUserToDeleteRows = false;
            dgvFoodList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoodList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvFoodList.ColumnHeadersHeight = 29;
            dgvFoodList.Location = new Point(12, 202);
            dgvFoodList.Name = "dgvFoodList";
            dgvFoodList.RowHeadersWidth = 51;
            dgvFoodList.RowTemplate.Height = 25;
            dgvFoodList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoodList.Size = new Size(794, 480);
            dgvFoodList.TabIndex = 48;
            dgvFoodList.CellFormatting += dgvFoodList_CellFormatting;
            dgvFoodList.SelectionChanged += dgvFoodList_SelectionChanged;
            // 
            // cboFoodCategory
            // 
            cboFoodCategory.FormattingEnabled = true;
            cboFoodCategory.Location = new Point(480, 38);
            cboFoodCategory.Name = "cboFoodCategory";
            cboFoodCategory.Size = new Size(160, 23);
            cboFoodCategory.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(480, 18);
            label9.Name = "label9";
            label9.Size = new Size(145, 15);
            label9.TabIndex = 44;
            label9.Text = "SELECT FOOD CATEGORY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(12, 175);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 35;
            label4.Text = "FOOD LIST";
            // 
            // txtFoodName
            // 
            txtFoodName.Location = new Point(108, 21);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(100, 23);
            txtFoodName.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 51;
            label1.Text = "Food Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(245, 23);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 53;
            label2.Text = "Carbs Value";
            // 
            // txtCarbsValue
            // 
            txtCarbsValue.Location = new Point(351, 18);
            txtCarbsValue.Name = "txtCarbsValue";
            txtCarbsValue.Size = new Size(100, 23);
            txtCarbsValue.TabIndex = 52;
            // 
            // pbDeleteCategory
            // 
            pbDeleteCategory.BackColor = Color.Linen;
            pbDeleteCategory.Image = Properties.Resources.delete;
            pbDeleteCategory.Location = new Point(21, 449);
            pbDeleteCategory.Name = "pbDeleteCategory";
            pbDeleteCategory.Size = new Size(88, 56);
            pbDeleteCategory.SizeMode = PictureBoxSizeMode.Zoom;
            pbDeleteCategory.TabIndex = 9;
            pbDeleteCategory.TabStop = false;
            pbDeleteCategory.Click += pbDeleteCategory_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(10, 508);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 10;
            label3.Text = "DELETE CATEGORY";
            // 
            // pbDeleteFood
            // 
            pbDeleteFood.BackColor = Color.Linen;
            pbDeleteFood.Image = Properties.Resources.delete;
            pbDeleteFood.Location = new Point(21, 187);
            pbDeleteFood.Name = "pbDeleteFood";
            pbDeleteFood.Size = new Size(88, 56);
            pbDeleteFood.SizeMode = PictureBoxSizeMode.Zoom;
            pbDeleteFood.TabIndex = 29;
            pbDeleteFood.TabStop = false;
            pbDeleteFood.Click += pbDeleteFood_Click;
            // 
            // pbHome
            // 
            pbHome.BackColor = Color.Linen;
            pbHome.Image = Properties.Resources.home;
            pbHome.Location = new Point(33, 16);
            pbHome.Name = "pbHome";
            pbHome.Size = new Size(66, 56);
            pbHome.SizeMode = PictureBoxSizeMode.Zoom;
            pbHome.TabIndex = 5;
            pbHome.TabStop = false;
            pbHome.Click += pbHome_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(44, 75);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 6;
            label10.Text = "HOME";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.DarkGreen;
            label12.Location = new Point(25, 246);
            label12.Name = "label12";
            label12.Size = new Size(83, 15);
            label12.TabIndex = 30;
            label12.Text = "DELETE FOOD";
            // 
            // pbLogout
            // 
            pbLogout.BackColor = Color.Linen;
            pbLogout.Image = Properties.Resources._switch;
            pbLogout.Location = new Point(24, 632);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(84, 48);
            pbLogout.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogout.TabIndex = 21;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(37, 683);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 22;
            label11.Text = "LOGOUT";
            // 
            // pbUpdateFood
            // 
            pbUpdateFood.Image = Properties.Resources.circular_arrow;
            pbUpdateFood.Location = new Point(18, 276);
            pbUpdateFood.Name = "pbUpdateFood";
            pbUpdateFood.Size = new Size(93, 50);
            pbUpdateFood.SizeMode = PictureBoxSizeMode.Zoom;
            pbUpdateFood.TabIndex = 31;
            pbUpdateFood.TabStop = false;
            pbUpdateFood.Click += pbUpdateFood_Click;
            // 
            // pbUpdateCategory
            // 
            pbUpdateCategory.Image = Properties.Resources.circular_arrow;
            pbUpdateCategory.Location = new Point(18, 540);
            pbUpdateCategory.Name = "pbUpdateCategory";
            pbUpdateCategory.Size = new Size(93, 50);
            pbUpdateCategory.SizeMode = PictureBoxSizeMode.Zoom;
            pbUpdateCategory.TabIndex = 25;
            pbUpdateCategory.TabStop = false;
            pbUpdateCategory.Click += pbUpdateCategory_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.DarkGreen;
            label14.Location = new Point(4, 593);
            label14.Name = "label14";
            label14.Size = new Size(115, 15);
            label14.TabIndex = 26;
            label14.Text = "UPDATE CATEGORY";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(21, 329);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 32;
            label8.Text = "UPDATE FOOD";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(20, 422);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 28;
            label7.Text = "ADD CATEGORY";
            // 
            // pbAddCategory
            // 
            pbAddCategory.BackColor = Color.Linen;
            pbAddCategory.Image = Properties.Resources.add;
            pbAddCategory.Location = new Point(28, 366);
            pbAddCategory.Name = "pbAddCategory";
            pbAddCategory.Size = new Size(74, 53);
            pbAddCategory.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddCategory.TabIndex = 27;
            pbAddCategory.TabStop = false;
            pbAddCategory.Click += pbAddCategory_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(30, 159);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 34;
            label6.Text = "ADD FOOD";
            // 
            // pbAddFood
            // 
            pbAddFood.BackColor = Color.Linen;
            pbAddFood.Image = Properties.Resources.add;
            pbAddFood.Location = new Point(27, 108);
            pbAddFood.Name = "pbAddFood";
            pbAddFood.Size = new Size(73, 48);
            pbAddFood.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddFood.TabIndex = 33;
            pbAddFood.TabStop = false;
            pbAddFood.Click += pbAddFood_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(pbAddFood);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pbAddCategory);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(pbUpdateCategory);
            panel1.Controls.Add(pbUpdateFood);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pbLogout);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pbHome);
            panel1.Controls.Add(pbDeleteFood);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pbDeleteCategory);
            panel1.Location = new Point(828, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 714);
            panel1.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(13, 59);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 55;
            label5.Text = "Fat Value";
            // 
            // txtFatValue
            // 
            txtFatValue.Location = new Point(108, 54);
            txtFatValue.Name = "txtFatValue";
            txtFatValue.Size = new Size(100, 23);
            txtFatValue.TabIndex = 54;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkGreen;
            label13.Location = new Point(12, 94);
            label13.Name = "label13";
            label13.Size = new Size(80, 15);
            label13.TabIndex = 57;
            label13.Text = "Protein Value";
            // 
            // txtProteinValue
            // 
            txtProteinValue.Location = new Point(108, 89);
            txtProteinValue.Name = "txtProteinValue";
            txtProteinValue.Size = new Size(100, 23);
            txtProteinValue.TabIndex = 56;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.White;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.ForeColor = Color.DarkGreen;
            label15.Location = new Point(245, 56);
            label15.Name = "label15";
            label15.Size = new Size(82, 15);
            label15.TabIndex = 59;
            label15.Text = "Sodium Value";
            // 
            // txtSodiumValue
            // 
            txtSodiumValue.Location = new Point(351, 54);
            txtSodiumValue.Name = "txtSodiumValue";
            txtSodiumValue.Size = new Size(100, 23);
            txtSodiumValue.TabIndex = 58;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.ForeColor = Color.DarkGreen;
            label16.Location = new Point(13, 126);
            label16.Name = "label16";
            label16.Size = new Size(73, 15);
            label16.TabIndex = 61;
            label16.Text = "Sugar Value";
            // 
            // txtSugarValue
            // 
            txtSugarValue.Location = new Point(108, 121);
            txtSugarValue.Name = "txtSugarValue";
            txtSugarValue.Size = new Size(100, 23);
            txtSugarValue.TabIndex = 60;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label17.ForeColor = Color.DarkGreen;
            label17.Location = new Point(242, 123);
            label17.Name = "label17";
            label17.Size = new Size(93, 15);
            label17.TabIndex = 63;
            label17.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(351, 121);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(100, 23);
            txtCategoryName.TabIndex = 62;
            // 
            // pbFoodImg
            // 
            pbFoodImg.Location = new Point(673, 16);
            pbFoodImg.Name = "pbFoodImg";
            pbFoodImg.Size = new Size(134, 100);
            pbFoodImg.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoodImg.TabIndex = 64;
            pbFoodImg.TabStop = false;
            // 
            // btnImportPhoto
            // 
            btnImportPhoto.Location = new Point(675, 140);
            btnImportPhoto.Name = "btnImportPhoto";
            btnImportPhoto.Size = new Size(132, 23);
            btnImportPhoto.TabIndex = 65;
            btnImportPhoto.Text = "Import Photo";
            btnImportPhoto.UseVisualStyleBackColor = true;
            btnImportPhoto.Click += btnImportPhoto_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.White;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label18.ForeColor = Color.DarkGreen;
            label18.Location = new Point(245, 92);
            label18.Name = "label18";
            label18.Size = new Size(77, 15);
            label18.TabIndex = 67;
            label18.Text = "Calory Value";
            // 
            // txtCaloryValue
            // 
            txtCaloryValue.Location = new Point(351, 89);
            txtCaloryValue.Name = "txtCaloryValue";
            txtCaloryValue.Size = new Size(100, 23);
            txtCaloryValue.TabIndex = 66;
            // 
            // FoodManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.flat_lay_colourful_composition_vegetables_with_copy_space;
            ClientSize = new Size(962, 707);
            Controls.Add(label18);
            Controls.Add(txtCaloryValue);
            Controls.Add(btnImportPhoto);
            Controls.Add(pbFoodImg);
            Controls.Add(label17);
            Controls.Add(txtCategoryName);
            Controls.Add(label16);
            Controls.Add(txtSugarValue);
            Controls.Add(label15);
            Controls.Add(txtSodiumValue);
            Controls.Add(label13);
            Controls.Add(txtProteinValue);
            Controls.Add(label5);
            Controls.Add(txtFatValue);
            Controls.Add(label2);
            Controls.Add(txtCarbsValue);
            Controls.Add(label1);
            Controls.Add(txtFoodName);
            Controls.Add(dgvFoodList);
            Controls.Add(cboFoodCategory);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(label4);
            Name = "FoodManagement";
            Text = "FoodManagement";
            Load += FoodManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFoodList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddCategory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddFood).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoodImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvFoodList;
        private ComboBox cboFoodCategory;
        private Label label9;
        private NumericUpDown numFood;
        private ComboBox cmbFoodSelect;
        private Label label4;
        private TextBox txtFoodName;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox txtCarbsValue;
        private PictureBox pbDeleteCategory;
        private Label label3;
        private PictureBox pbDeleteFood;
        private PictureBox pbHome;
        private Label label10;
        private Label label12;
        private PictureBox pbLogout;
        private Label label11;
        private PictureBox pbUpdateFood;
        private PictureBox pbUpdateCategory;
        private Label label14;
        private Label label8;
        private Label label7;
        private PictureBox pbAddCategory;
        private Label label6;
        private PictureBox pbAddFood;
        private Panel panel1;
        private Label label5;
        private TextBox txtFatValue;
        private Label label13;
        private TextBox txtProteinValue;
        private Label label15;
        private TextBox txtSodiumValue;
        private Label label16;
        private TextBox txtSugarValue;
        private Label label17;
        private TextBox txtCategoryName;
        private PictureBox pbFoodImg;
        private Button btnImportPhoto;
        private Label label18;
        private TextBox txtCaloryValue;
    }
}