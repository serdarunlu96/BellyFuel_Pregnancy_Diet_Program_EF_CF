namespace BellyFuel_Pregnancy_Diet_Program
{
    partial class MealManagement
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
            pbAddMeal = new PictureBox();
            pbUpBeverage = new PictureBox();
            label1 = new Label();
            pbDeleteFood = new PictureBox();
            label3 = new Label();
            cmbMealSelect = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cmbFoodSelect = new ComboBox();
            cmbBeverageSelect = new ComboBox();
            numBeverage = new NumericUpDown();
            numFood = new NumericUpDown();
            label8 = new Label();
            panel1 = new Panel();
            label14 = new Label();
            pbUpFood = new PictureBox();
            label13 = new Label();
            pbDeleteBev = new PictureBox();
            label11 = new Label();
            pbLogout = new PictureBox();
            label10 = new Label();
            pbMealManagement = new PictureBox();
            label9 = new Label();
            cboFoodCategory = new ComboBox();
            cboBevCategory = new ComboBox();
            label12 = new Label();
            dgvFoodList = new DataGridView();
            dgvBeverageList = new DataGridView();
            pbFood = new PictureBox();
            pbBeverage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbAddMeal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpBeverage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBeverage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFood).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUpFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteBev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMealManagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoodList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBeverageList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBeverage).BeginInit();
            SuspendLayout();
            // 
            // pbAddMeal
            // 
            pbAddMeal.BackColor = Color.Linen;
            pbAddMeal.Image = Properties.Resources.add;
            pbAddMeal.Location = new Point(20, 120);
            pbAddMeal.Name = "pbAddMeal";
            pbAddMeal.Size = new Size(81, 54);
            pbAddMeal.SizeMode = PictureBoxSizeMode.Zoom;
            pbAddMeal.TabIndex = 5;
            pbAddMeal.TabStop = false;
            pbAddMeal.Click += pbAddMeal_Click;
            // 
            // pbUpBeverage
            // 
            pbUpBeverage.BackColor = Color.Linen;
            pbUpBeverage.Image = Properties.Resources.circular_arrow;
            pbUpBeverage.Location = new Point(13, 543);
            pbUpBeverage.Name = "pbUpBeverage";
            pbUpBeverage.Size = new Size(88, 46);
            pbUpBeverage.SizeMode = PictureBoxSizeMode.Zoom;
            pbUpBeverage.TabIndex = 7;
            pbUpBeverage.TabStop = false;
            pbUpBeverage.Click += pbUpBeverage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(3, 601);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 8;
            label1.Text = "UPDATE BEVERAGE";
            // 
            // pbDeleteFood
            // 
            pbDeleteFood.BackColor = Color.Linen;
            pbDeleteFood.Image = Properties.Resources.delete;
            pbDeleteFood.Location = new Point(17, 230);
            pbDeleteFood.Name = "pbDeleteFood";
            pbDeleteFood.Size = new Size(88, 56);
            pbDeleteFood.SizeMode = PictureBoxSizeMode.Zoom;
            pbDeleteFood.TabIndex = 9;
            pbDeleteFood.TabStop = false;
            pbDeleteFood.Click += pbDeleteFood_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(22, 289);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 10;
            label3.Text = "DELETE FOOD";
            // 
            // cmbMealSelect
            // 
            cmbMealSelect.FormattingEnabled = true;
            cmbMealSelect.Items.AddRange(new object[] { "Select" });
            cmbMealSelect.Location = new Point(472, 88);
            cmbMealSelect.Name = "cmbMealSelect";
            cmbMealSelect.Size = new Size(174, 23);
            cmbMealSelect.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(472, 70);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 16;
            label2.Text = "SELECT MEAL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(382, 185);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 18;
            label4.Text = "FOOD LIST";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(766, 135);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 19;
            label5.Text = "SELECT FOOD";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(27, 177);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 20;
            label6.Text = "ADD MEAL";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(766, 418);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 21;
            label7.Text = "SELECT BEVERAGE";
            // 
            // cmbFoodSelect
            // 
            cmbFoodSelect.FormattingEnabled = true;
            cmbFoodSelect.Location = new Point(807, 153);
            cmbFoodSelect.Name = "cmbFoodSelect";
            cmbFoodSelect.Size = new Size(172, 23);
            cmbFoodSelect.TabIndex = 22;
            // 
            // cmbBeverageSelect
            // 
            cmbBeverageSelect.FormattingEnabled = true;
            cmbBeverageSelect.Location = new Point(807, 436);
            cmbBeverageSelect.Name = "cmbBeverageSelect";
            cmbBeverageSelect.Size = new Size(168, 23);
            cmbBeverageSelect.TabIndex = 23;
            // 
            // numBeverage
            // 
            numBeverage.Location = new Point(766, 436);
            numBeverage.Margin = new Padding(3, 2, 3, 2);
            numBeverage.Name = "numBeverage";
            numBeverage.Size = new Size(36, 23);
            numBeverage.TabIndex = 25;
            // 
            // numFood
            // 
            numFood.Location = new Point(766, 154);
            numFood.Margin = new Padding(3, 2, 3, 2);
            numFood.Name = "numFood";
            numFood.Size = new Size(36, 23);
            numFood.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(382, 472);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 18;
            label8.Text = "BEVERAGE LIST";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(label14);
            panel1.Controls.Add(pbUpFood);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(pbDeleteBev);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pbLogout);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pbMealManagement);
            panel1.Controls.Add(pbAddMeal);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pbDeleteFood);
            panel1.Controls.Add(pbUpBeverage);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1008, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 714);
            panel1.TabIndex = 27;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.DarkGreen;
            label14.Location = new Point(16, 498);
            label14.Name = "label14";
            label14.Size = new Size(88, 15);
            label14.TabIndex = 26;
            label14.Text = "UPDATE FOOD";
            // 
            // pbUpFood
            // 
            pbUpFood.Image = Properties.Resources.circular_arrow;
            pbUpFood.Location = new Point(13, 435);
            pbUpFood.Name = "pbUpFood";
            pbUpFood.Size = new Size(93, 50);
            pbUpFood.SizeMode = PictureBoxSizeMode.Zoom;
            pbUpFood.TabIndex = 25;
            pbUpFood.TabStop = false;
            pbUpFood.Click += pbUpFood_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkGreen;
            label13.Location = new Point(6, 397);
            label13.Name = "label13";
            label13.Size = new Size(106, 15);
            label13.TabIndex = 24;
            label13.Text = "DELETE BEVERAGE";
            // 
            // pbDeleteBev
            // 
            pbDeleteBev.BackColor = Color.Linen;
            pbDeleteBev.Image = Properties.Resources.delete;
            pbDeleteBev.Location = new Point(17, 338);
            pbDeleteBev.Name = "pbDeleteBev";
            pbDeleteBev.Size = new Size(88, 56);
            pbDeleteBev.SizeMode = PictureBoxSizeMode.Zoom;
            pbDeleteBev.TabIndex = 23;
            pbDeleteBev.TabStop = false;
            pbDeleteBev.Click += pbDeleteBev_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(27, 683);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 22;
            label11.Text = "LOGOUT";
            // 
            // pbLogout
            // 
            pbLogout.BackColor = Color.Linen;
            pbLogout.Image = Properties.Resources._switch;
            pbLogout.Location = new Point(18, 632);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(84, 48);
            pbLogout.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogout.TabIndex = 21;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(36, 78);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 6;
            label10.Text = "HOME";
            // 
            // pbMealManagement
            // 
            pbMealManagement.BackColor = Color.Linen;
            pbMealManagement.Image = Properties.Resources.home;
            pbMealManagement.Location = new Point(25, 19);
            pbMealManagement.Name = "pbMealManagement";
            pbMealManagement.Size = new Size(66, 56);
            pbMealManagement.SizeMode = PictureBoxSizeMode.Zoom;
            pbMealManagement.TabIndex = 5;
            pbMealManagement.TabStop = false;
            pbMealManagement.Click += pbMealManagement_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkGreen;
            label9.Location = new Point(472, 135);
            label9.Name = "label9";
            label9.Size = new Size(145, 15);
            label9.TabIndex = 28;
            label9.Text = "SELECT FOOD CATEGORY";
            // 
            // cboFoodCategory
            // 
            cboFoodCategory.FormattingEnabled = true;
            cboFoodCategory.Location = new Point(472, 153);
            cboFoodCategory.Name = "cboFoodCategory";
            cboFoodCategory.Size = new Size(174, 23);
            cboFoodCategory.TabIndex = 29;
            cboFoodCategory.SelectedIndexChanged += cboFoodCategory_SelectedIndexChanged;
            // 
            // cboBevCategory
            // 
            cboBevCategory.FormattingEnabled = true;
            cboBevCategory.Location = new Point(472, 436);
            cboBevCategory.Name = "cboBevCategory";
            cboBevCategory.Size = new Size(174, 23);
            cboBevCategory.TabIndex = 31;
            cboBevCategory.SelectedIndexChanged += cboBevCategory_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.DarkGreen;
            label12.Location = new Point(472, 418);
            label12.Name = "label12";
            label12.Size = new Size(168, 15);
            label12.TabIndex = 30;
            label12.Text = "SELECT BEVERAGE CATEGORY";
            // 
            // dgvFoodList
            // 
            dgvFoodList.AllowUserToAddRows = false;
            dgvFoodList.AllowUserToDeleteRows = false;
            dgvFoodList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFoodList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvFoodList.ColumnHeadersHeight = 29;
            dgvFoodList.Location = new Point(382, 203);
            dgvFoodList.Name = "dgvFoodList";
            dgvFoodList.RowHeadersWidth = 51;
            dgvFoodList.RowTemplate.Height = 25;
            dgvFoodList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFoodList.Size = new Size(597, 193);
            dgvFoodList.TabIndex = 32;
            dgvFoodList.CellClick += dgvFoodList_CellClick;
            dgvFoodList.SelectionChanged += cboFoodCategory_SelectedIndexChanged;
            // 
            // dgvBeverageList
            // 
            dgvBeverageList.AllowUserToAddRows = false;
            dgvBeverageList.AllowUserToDeleteRows = false;
            dgvBeverageList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBeverageList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvBeverageList.ColumnHeadersHeight = 29;
            dgvBeverageList.Location = new Point(382, 500);
            dgvBeverageList.Name = "dgvBeverageList";
            dgvBeverageList.RowHeadersWidth = 51;
            dgvBeverageList.RowTemplate.Height = 25;
            dgvBeverageList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBeverageList.Size = new Size(597, 182);
            dgvBeverageList.TabIndex = 32;
            dgvBeverageList.CellClick += dgvBeverageList_CellClick;
            dgvBeverageList.SelectionChanged += cboBevCategory_SelectedIndexChanged;
            // 
            // pbFood
            // 
            pbFood.Location = new Point(148, 185);
            pbFood.Name = "pbFood";
            pbFood.Size = new Size(214, 211);
            pbFood.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFood.TabIndex = 33;
            pbFood.TabStop = false;
            // 
            // pbBeverage
            // 
            pbBeverage.Location = new Point(148, 472);
            pbBeverage.Name = "pbBeverage";
            pbBeverage.Size = new Size(214, 210);
            pbBeverage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBeverage.TabIndex = 34;
            pbBeverage.TabStop = false;
            // 
            // MealManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.flat_lay_vegetables_white_background_food_diet_concept;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1133, 710);
            Controls.Add(pbBeverage);
            Controls.Add(pbFood);
            Controls.Add(dgvBeverageList);
            Controls.Add(dgvFoodList);
            Controls.Add(cboBevCategory);
            Controls.Add(label12);
            Controls.Add(cboFoodCategory);
            Controls.Add(label9);
            Controls.Add(numFood);
            Controls.Add(numBeverage);
            Controls.Add(cmbBeverageSelect);
            Controls.Add(cmbFoodSelect);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(cmbMealSelect);
            Controls.Add(panel1);
            Name = "MealManagement";
            StartPosition = FormStartPosition.CenterParent;
            Text = "MealManagement";
            ((System.ComponentModel.ISupportInitialize)pbAddMeal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUpBeverage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBeverage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFood).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUpFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteBev).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMealManagement).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoodList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBeverageList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBeverage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbAddMeal;
        private PictureBox pbUpBeverage;
        private Label label1;
        private PictureBox pbDeleteFood;
        private Label label3;
        private ComboBox cmbMealSelect;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbFoodSelect;
        private ComboBox cmbBeverageSelect;
        private NumericUpDown numBeverage;
        private NumericUpDown numFood;
        private Label label8;
        private Panel panel1;
        private Label label9;
        private ComboBox cboFoodCategory;
        private Label label10;
        private PictureBox pbMealManagement;
        private Label label11;
        private PictureBox pbLogout;
        private ComboBox cboBevCategory;
        private Label label12;
        private DataGridView dgvFoodList;
        private DataGridView dgvBeverageList;
        private Label label13;
        private PictureBox pbDeleteBev;
        private Label label14;
        private PictureBox pbUpFood;
        private PictureBox pbFood;
        private PictureBox pbBeverage;
    }
}