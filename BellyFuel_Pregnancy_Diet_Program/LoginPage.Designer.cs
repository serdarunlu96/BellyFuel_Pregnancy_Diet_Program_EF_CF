namespace BellyFuel_Pregnancy_Diet_Program
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSignUp = new Button();
            btnLogin = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            lblYazi = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.ForestGreen;
            label1.Location = new Point(505, 216);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(505, 250);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(592, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(152, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(592, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(152, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Linen;
            btnSignUp.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSignUp.ForeColor = Color.ForestGreen;
            btnSignUp.Location = new Point(450, 444);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(98, 29);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Linen;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.ForestGreen;
            btnLogin.Location = new Point(618, 287);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 28);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(580, 130);
            label3.Name = "label3";
            label3.Size = new Size(172, 20);
            label3.TabIndex = 25;
            label3.Text = "BellyFuel: Pregnancy Diet ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.pregnancy;
            pictureBox1.Location = new Point(618, 37);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // lblYazi
            // 
            lblYazi.BackColor = Color.White;
            lblYazi.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblYazi.ForeColor = Color.FromArgb(34, 40, 49);
            lblYazi.Location = new Point(416, 422);
            lblYazi.Margin = new Padding(4, 0, 4, 0);
            lblYazi.Name = "lblYazi";
            lblYazi.Size = new Size(176, 19);
            lblYazi.TabIndex = 26;
            lblYazi.Text = "Don't have an account?";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.flat_lay_vegetables_white_background_food_diet_concept;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(959, 587);
            Controls.Add(lblYazi);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogin);
            Controls.Add(btnSignUp);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BellFuel : Pregnancy Diet Program";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSignUp;
        private Button btnLogin;
        private Label label3;
        private PictureBox pictureBox1;
        private Label lblYazi;
    }
}