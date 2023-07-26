namespace BellyFuel_Pregnancy_Diet_Program
{
    partial class UserUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUI));
            pbLogout = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pbMealManagement = new PictureBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            pbReports = new PictureBox();
            label6 = new Label();
            pbCaloryWeight = new PictureBox();
            label5 = new Label();
            lblName = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMealManagement).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCaloryWeight).BeginInit();
            SuspendLayout();
            // 
            // pbLogout
            // 
            pbLogout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbLogout.BackColor = Color.Linen;
            pbLogout.Image = Properties.Resources._switch;
            pbLogout.Location = new Point(37, 496);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(74, 60);
            pbLogout.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogout.TabIndex = 1;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(44, 559);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "LOGOUT";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(8, 84);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 4;
            label2.Text = "MEAL MANAGEMENT";
            // 
            // pbMealManagement
            // 
            pbMealManagement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbMealManagement.BackColor = Color.Linen;
            pbMealManagement.Image = Properties.Resources.food;
            pbMealManagement.Location = new Point(44, 25);
            pbMealManagement.Name = "pbMealManagement";
            pbMealManagement.Size = new Size(67, 56);
            pbMealManagement.SizeMode = PictureBoxSizeMode.Zoom;
            pbMealManagement.TabIndex = 3;
            pbMealManagement.TabStop = false;
            pbMealManagement.Click += pbMealManagement_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(502, 495);
            label4.Name = "label4";
            label4.Size = new Size(262, 93);
            label4.TabIndex = 7;
            label4.Text = resources.GetString("label4.Text");
            label4.TextAlign = ContentAlignment.MiddleCenter;
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
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(534, 160);
            label3.Name = "label3";
            label3.Size = new Size(210, 27);
            label3.TabIndex = 9;
            label3.Text = "BellyFuel: Pregnancy Diet ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pbReports);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pbCaloryWeight);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pbMealManagement);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pbLogout);
            panel1.Location = new Point(824, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 604);
            panel1.TabIndex = 10;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGreen;
            label7.Location = new Point(44, 406);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 31;
            label7.Text = "REPORTS";
            // 
            // pbReports
            // 
            pbReports.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbReports.BackColor = Color.Linen;
            pbReports.Image = Properties.Resources.survey;
            pbReports.Location = new Point(44, 322);
            pbReports.Name = "pbReports";
            pbReports.Size = new Size(77, 80);
            pbReports.SizeMode = PictureBoxSizeMode.Zoom;
            pbReports.TabIndex = 30;
            pbReports.TabStop = false;
            pbReports.Click += pbReports_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(27, 239);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 29;
            label6.Text = "CALORY WEIGHT";
            // 
            // pbCaloryWeight
            // 
            pbCaloryWeight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbCaloryWeight.Image = Properties.Resources.bmi;
            pbCaloryWeight.Location = new Point(44, 174);
            pbCaloryWeight.Margin = new Padding(3, 2, 3, 2);
            pbCaloryWeight.Name = "pbCaloryWeight";
            pbCaloryWeight.Size = new Size(67, 63);
            pbCaloryWeight.SizeMode = PictureBoxSizeMode.Zoom;
            pbCaloryWeight.TabIndex = 28;
            pbCaloryWeight.TabStop = false;
            pbCaloryWeight.Click += pbCaloryWeight_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(519, 256);
            label5.Name = "label5";
            label5.Size = new Size(225, 67);
            label5.TabIndex = 11;
            label5.Text = "Welcome !";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.BackColor = Color.White;
            lblName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblName.ForeColor = Color.Red;
            lblName.Location = new Point(547, 334);
            lblName.Name = "lblName";
            lblName.Size = new Size(172, 53);
            lblName.TabIndex = 12;
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.flat_lay_vegetables_white_background_food_diet_concept;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(972, 604);
            Controls.Add(lblName);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "UserUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserUI";
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMealManagement).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCaloryWeight).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogout;
        private Label label1;
        private Label label2;
        private PictureBox pbMealManagement;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel1;
        private Label label5;
        private Label lblName;
        private Label label6;
        private PictureBox pbCaloryWeight;
        private Label label7;
        private PictureBox pbReports;
    }
}