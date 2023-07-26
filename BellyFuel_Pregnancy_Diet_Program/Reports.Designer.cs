namespace BellyFuel_Pregnancy_Diet_Program
{
    partial class Reports
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
            dtpReport = new DateTimePicker();
            dgvFoodReportsWeek = new DataGridView();
            dgvFoodReportsMonth = new DataGridView();
            pbReturn = new PictureBox();
            label2 = new Label();
            pbHome = new PictureBox();
            dgvBevReportsWeek = new DataGridView();
            dgvBevReportsMonth = new DataGridView();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            pbMealManagement = new PictureBox();
            panel1 = new Panel();
            pbStatistics = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFoodReportsWeek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoodReportsMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbReturn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBevReportsWeek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBevReportsMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMealManagement).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStatistics).BeginInit();
            SuspendLayout();
            // 
            // dtpReport
            // 
            dtpReport.Location = new Point(24, 12);
            dtpReport.Name = "dtpReport";
            dtpReport.Size = new Size(296, 23);
            dtpReport.TabIndex = 0;
            dtpReport.ValueChanged += dtpReport_ValueChanged;
            // 
            // dgvFoodReportsWeek
            // 
            dgvFoodReportsWeek.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFoodReportsWeek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodReportsWeek.GridColor = Color.CadetBlue;
            dgvFoodReportsWeek.Location = new Point(24, 73);
            dgvFoodReportsWeek.Name = "dgvFoodReportsWeek";
            dgvFoodReportsWeek.RowHeadersWidth = 51;
            dgvFoodReportsWeek.RowTemplate.Height = 25;
            dgvFoodReportsWeek.Size = new Size(363, 228);
            dgvFoodReportsWeek.TabIndex = 1;
            // 
            // dgvFoodReportsMonth
            // 
            dgvFoodReportsMonth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFoodReportsMonth.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFoodReportsMonth.Location = new Point(24, 333);
            dgvFoodReportsMonth.Name = "dgvFoodReportsMonth";
            dgvFoodReportsMonth.RowHeadersWidth = 51;
            dgvFoodReportsMonth.RowTemplate.Height = 25;
            dgvFoodReportsMonth.Size = new Size(363, 236);
            dgvFoodReportsMonth.TabIndex = 2;
            // 
            // pbReturn
            // 
            pbReturn.BackgroundImageLayout = ImageLayout.Zoom;
            pbReturn.Image = Properties.Resources.greenArrowLeft;
            pbReturn.Location = new Point(33, 482);
            pbReturn.Name = "pbReturn";
            pbReturn.Size = new Size(68, 60);
            pbReturn.SizeMode = PictureBoxSizeMode.StretchImage;
            pbReturn.TabIndex = 23;
            pbReturn.TabStop = false;
            pbReturn.Click += pbReturn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(44, 143);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 25;
            label2.Text = "HOME";
            // 
            // pbHome
            // 
            pbHome.BackColor = Color.Linen;
            pbHome.Image = Properties.Resources.home;
            pbHome.Location = new Point(36, 84);
            pbHome.Name = "pbHome";
            pbHome.Size = new Size(66, 56);
            pbHome.SizeMode = PictureBoxSizeMode.Zoom;
            pbHome.TabIndex = 24;
            pbHome.TabStop = false;
            pbHome.Click += pbHome_Click;
            // 
            // dgvBevReportsWeek
            // 
            dgvBevReportsWeek.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBevReportsWeek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBevReportsWeek.Location = new Point(419, 73);
            dgvBevReportsWeek.Name = "dgvBevReportsWeek";
            dgvBevReportsWeek.RowHeadersWidth = 51;
            dgvBevReportsWeek.RowTemplate.Height = 25;
            dgvBevReportsWeek.Size = new Size(373, 228);
            dgvBevReportsWeek.TabIndex = 26;
            // 
            // dgvBevReportsMonth
            // 
            dgvBevReportsMonth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBevReportsMonth.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBevReportsMonth.Location = new Point(419, 333);
            dgvBevReportsMonth.Name = "dgvBevReportsMonth";
            dgvBevReportsMonth.RowHeadersWidth = 51;
            dgvBevReportsMonth.RowTemplate.Height = 25;
            dgvBevReportsMonth.Size = new Size(373, 236);
            dgvBevReportsMonth.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(24, 55);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 28;
            label4.Text = "FOOD WEEKLY LIST";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(419, 55);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 29;
            label1.Text = "BEVERAGE WEEKLY LIST";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(24, 315);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 30;
            label3.Text = "FOOD MONTHLY LIST";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGreen;
            label5.Location = new Point(419, 315);
            label5.Name = "label5";
            label5.Size = new Size(148, 15);
            label5.TabIndex = 31;
            label5.Text = "BEVERAGE MONTHLY LIST";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(3, 277);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 33;
            label6.Text = "MEAL MANAGEMENT";
            // 
            // pbMealManagement
            // 
            pbMealManagement.BackColor = Color.Linen;
            pbMealManagement.Image = Properties.Resources.food;
            pbMealManagement.Location = new Point(36, 218);
            pbMealManagement.Name = "pbMealManagement";
            pbMealManagement.Size = new Size(66, 56);
            pbMealManagement.SizeMode = PictureBoxSizeMode.Zoom;
            pbMealManagement.TabIndex = 32;
            pbMealManagement.TabStop = false;
            pbMealManagement.Click += pbMealManagement_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(pbStatistics);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pbReturn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pbHome);
            panel1.Controls.Add(pbMealManagement);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(830, -4);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 602);
            panel1.TabIndex = 71;
            // 
            // pbStatistics
            // 
            pbStatistics.BackColor = Color.Linen;
            pbStatistics.Image = Properties.Resources.qualitative_research;
            pbStatistics.Location = new Point(33, 353);
            pbStatistics.Name = "pbStatistics";
            pbStatistics.Size = new Size(66, 56);
            pbStatistics.SizeMode = PictureBoxSizeMode.Zoom;
            pbStatistics.TabIndex = 35;
            pbStatistics.TabStop = false;
            pbStatistics.Click += pbStatistics_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(27, 412);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 34;
            label7.Text = "STATISTICS";
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = Properties.Resources.elevated_view_measuring_tape_healthy_food_white_background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(970, 597);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(dgvBevReportsMonth);
            Controls.Add(dgvBevReportsWeek);
            Controls.Add(dgvFoodReportsMonth);
            Controls.Add(dgvFoodReportsWeek);
            Controls.Add(dtpReport);
            DoubleBuffered = true;
            Name = "Reports";
            Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)dgvFoodReportsWeek).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFoodReportsMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReturn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBevReportsWeek).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBevReportsMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMealManagement).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbStatistics).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpReport;
        private DataGridView dgvFoodReportsWeek;
        private DataGridView dgvFoodReportsMonth;
        private PictureBox pbReturn;
        private Label label2;
        private PictureBox pbHome;
        private DataGridView dgvBevReportsWeek;
        private DataGridView dgvBevReportsMonth;
        private Label label4;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label6;
        private PictureBox pbMealManagement;
        private Panel panel1;
        private PictureBox pbStatistics;
        private Label label7;
    }
}