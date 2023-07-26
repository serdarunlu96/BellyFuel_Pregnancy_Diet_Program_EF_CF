namespace BellyFuel_Pregnancy_Diet_Program
{
    partial class AdminUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUI));
            label1 = new Label();
            pbLogout = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pbFoodManagement = new PictureBox();
            label8 = new Label();
            pbBeverageManagement = new PictureBox();
            pbUserManagement = new PictureBox();
            label6 = new Label();
            lblName = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoodManagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBeverageManagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUserManagement).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(52, 558);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "LOGOUT";
            // 
            // pbLogout
            // 
            pbLogout.BackColor = Color.Linen;
            pbLogout.Image = Properties.Resources._switch;
            pbLogout.Location = new Point(42, 495);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(84, 60);
            pbLogout.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogout.TabIndex = 1;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(534, 160);
            label3.Name = "label3";
            label3.Size = new Size(210, 29);
            label3.TabIndex = 16;
            label3.Text = "BellyFuel: Pregnancy Diet ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.pregnancy;
            pictureBox1.Location = new Point(562, 46);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(495, 520);
            label4.Name = "label4";
            label4.Size = new Size(265, 82);
            label4.TabIndex = 14;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pbFoodManagement);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pbBeverageManagement);
            panel1.Controls.Add(pbUserManagement);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbLogout);
            panel1.Location = new Point(801, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 604);
            panel1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(17, 392);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 35;
            label2.Text = "USER MANAGEMENT";
            // 
            // pbFoodManagement
            // 
            pbFoodManagement.BackColor = Color.Linen;
            pbFoodManagement.Image = Properties.Resources.food;
            pbFoodManagement.Location = new Point(52, 46);
            pbFoodManagement.Name = "pbFoodManagement";
            pbFoodManagement.Size = new Size(66, 56);
            pbFoodManagement.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoodManagement.TabIndex = 34;
            pbFoodManagement.TabStop = false;
            pbFoodManagement.Click += pbFoodManagement_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(1, 241);
            label8.Name = "label8";
            label8.Size = new Size(147, 15);
            label8.TabIndex = 33;
            label8.Text = "BEVERAGE MANAGEMENT";
            // 
            // pbBeverageManagement
            // 
            pbBeverageManagement.Image = Properties.Resources.MicrosoftTeams_image;
            pbBeverageManagement.Location = new Point(42, 173);
            pbBeverageManagement.Margin = new Padding(3, 2, 3, 2);
            pbBeverageManagement.Name = "pbBeverageManagement";
            pbBeverageManagement.Size = new Size(84, 65);
            pbBeverageManagement.SizeMode = PictureBoxSizeMode.Zoom;
            pbBeverageManagement.TabIndex = 32;
            pbBeverageManagement.TabStop = false;
            pbBeverageManagement.Click += pbBeverageManagement_Click;
            // 
            // pbUserManagement
            // 
            pbUserManagement.BackColor = Color.Linen;
            pbUserManagement.Image = Properties.Resources.user_gear;
            pbUserManagement.Location = new Point(52, 333);
            pbUserManagement.Name = "pbUserManagement";
            pbUserManagement.Size = new Size(66, 56);
            pbUserManagement.SizeMode = PictureBoxSizeMode.Zoom;
            pbUserManagement.TabIndex = 30;
            pbUserManagement.TabStop = false;
            pbUserManagement.Click += pbUserManagement_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(25, 105);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 29;
            label6.Text = "FOOD MANAGEMENT";
            // 
            // lblName
            // 
            lblName.BackColor = Color.White;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblName.ForeColor = Color.Red;
            lblName.Location = new Point(547, 334);
            lblName.Name = "lblName";
            lblName.Size = new Size(172, 53);
            lblName.TabIndex = 19;
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(519, 256);
            label5.Name = "label5";
            label5.Size = new Size(225, 58);
            label5.TabIndex = 18;
            label5.Text = "Welcome !";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AdminUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.flat_lay_vegetables_white_background_food_diet_concept;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(975, 608);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(lblName);
            Controls.Add(label5);
            Name = "AdminUI";
            Text = "Admin UI";
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoodManagement).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBeverageManagement).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUserManagement).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbMealManagement;
        private Label label1;
        private PictureBox pbLogout;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel1;
        private Label label8;
        private PictureBox pbBeverageManagement;
        private Label label7;
        private PictureBox pbReports;
        private Label label6;
        private PictureBox pbCaloryWeight;
        private Label lblName;
        private Label label5;
        private Label label2;
        private PictureBox pbFoodManagement;
        private PictureBox pbUserManagement;
    }
}