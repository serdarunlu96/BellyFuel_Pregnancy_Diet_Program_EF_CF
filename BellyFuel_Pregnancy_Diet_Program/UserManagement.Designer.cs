namespace BellyFuel_Pregnancy_Diet_Program
{
    partial class UserManagement
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
            label18 = new Label();
            txtAge = new TextBox();
            label16 = new Label();
            txtSurname = new TextBox();
            label15 = new Label();
            txtWeight = new TextBox();
            label13 = new Label();
            txtName = new TextBox();
            panel1 = new Panel();
            label8 = new Label();
            pbUpdateUser = new PictureBox();
            label11 = new Label();
            pbLogout = new PictureBox();
            label12 = new Label();
            label10 = new Label();
            pbHome = new PictureBox();
            pbDeleteUser = new PictureBox();
            label2 = new Label();
            txtHeight = new TextBox();
            dgvUserList = new DataGridView();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUpdateUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).BeginInit();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label18.ForeColor = Color.DarkGreen;
            label18.Location = new Point(545, 22);
            label18.Name = "label18";
            label18.Size = new Size(28, 15);
            label18.TabIndex = 90;
            label18.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(596, 20);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(130, 23);
            txtAge.TabIndex = 89;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.ForeColor = Color.DarkGreen;
            label16.Location = new Point(20, 57);
            label16.Name = "label16";
            label16.Size = new Size(56, 15);
            label16.TabIndex = 84;
            label16.Text = "Surname";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(115, 55);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(129, 23);
            txtSurname.TabIndex = 83;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.ForeColor = Color.DarkGreen;
            label15.Location = new Point(286, 54);
            label15.Name = "label15";
            label15.Size = new Size(46, 15);
            label15.TabIndex = 82;
            label15.Text = "Weight";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(354, 52);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(131, 23);
            txtWeight.TabIndex = 81;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkGreen;
            label13.Location = new Point(20, 26);
            label13.Name = "label13";
            label13.Size = new Size(40, 15);
            label13.TabIndex = 80;
            label13.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(115, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(129, 23);
            txtName.TabIndex = 79;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Linen;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pbUpdateUser);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pbLogout);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pbHome);
            panel1.Controls.Add(pbDeleteUser);
            panel1.Location = new Point(837, -1);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 603);
            panel1.TabIndex = 69;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkGreen;
            label8.Location = new Point(24, 360);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 32;
            label8.Text = "UPDATE USER";
            // 
            // pbUpdateUser
            // 
            pbUpdateUser.Image = Properties.Resources.circular_arrow;
            pbUpdateUser.Location = new Point(21, 308);
            pbUpdateUser.Name = "pbUpdateUser";
            pbUpdateUser.Size = new Size(93, 50);
            pbUpdateUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbUpdateUser.TabIndex = 31;
            pbUpdateUser.TabStop = false;
            pbUpdateUser.Click += pbUpdateUser_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkGreen;
            label11.Location = new Point(36, 513);
            label11.Name = "label11";
            label11.Size = new Size(54, 15);
            label11.TabIndex = 22;
            label11.Text = "LOGOUT";
            // 
            // pbLogout
            // 
            pbLogout.BackColor = Color.Linen;
            pbLogout.Image = Properties.Resources._switch;
            pbLogout.Location = new Point(24, 462);
            pbLogout.Name = "pbLogout";
            pbLogout.Size = new Size(84, 48);
            pbLogout.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogout.TabIndex = 21;
            pbLogout.TabStop = false;
            pbLogout.Click += pbLogout_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.DarkGreen;
            label12.Location = new Point(21, 228);
            label12.Name = "label12";
            label12.Size = new Size(77, 15);
            label12.TabIndex = 30;
            label12.Text = "DELETE USER";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkGreen;
            label10.Location = new Point(50, 98);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 6;
            label10.Text = "HOME";
            // 
            // pbHome
            // 
            pbHome.BackColor = Color.Linen;
            pbHome.Image = Properties.Resources.home;
            pbHome.Location = new Point(36, 38);
            pbHome.Name = "pbHome";
            pbHome.Size = new Size(66, 56);
            pbHome.SizeMode = PictureBoxSizeMode.Zoom;
            pbHome.TabIndex = 5;
            pbHome.TabStop = false;
            pbHome.Click += pbHome_Click;
            // 
            // pbDeleteUser
            // 
            pbDeleteUser.BackColor = Color.Linen;
            pbDeleteUser.Image = Properties.Resources.delete;
            pbDeleteUser.Location = new Point(24, 169);
            pbDeleteUser.Name = "pbDeleteUser";
            pbDeleteUser.Size = new Size(88, 56);
            pbDeleteUser.SizeMode = PictureBoxSizeMode.Zoom;
            pbDeleteUser.TabIndex = 29;
            pbDeleteUser.TabStop = false;
            pbDeleteUser.Click += pbDeleteUser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(286, 23);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 76;
            label2.Text = "Height";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(354, 20);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(131, 23);
            txtHeight.TabIndex = 75;
            // 
            // dgvUserList
            // 
            dgvUserList.AllowUserToAddRows = false;
            dgvUserList.AllowUserToDeleteRows = false;
            dgvUserList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvUserList.ColumnHeadersHeight = 29;
            dgvUserList.Location = new Point(20, 124);
            dgvUserList.Name = "dgvUserList";
            dgvUserList.ReadOnly = true;
            dgvUserList.RowHeadersWidth = 51;
            dgvUserList.RowTemplate.Height = 25;
            dgvUserList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUserList.Size = new Size(792, 279);
            dgvUserList.TabIndex = 72;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(18, 106);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 68;
            label4.Text = "USER LIST";
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.flat_lay_colourful_composition_vegetables_with_copy_space;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(971, 600);
            Controls.Add(label18);
            Controls.Add(txtAge);
            Controls.Add(label16);
            Controls.Add(txtSurname);
            Controls.Add(label15);
            Controls.Add(txtWeight);
            Controls.Add(label13);
            Controls.Add(txtName);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(txtHeight);
            Controls.Add(dgvUserList);
            Controls.Add(label4);
            Name = "UserManagement";
            Text = "UserManagement";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUpdateUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeleteUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label18;
        private TextBox txtAge;
        private Label label16;
        private TextBox txtSurname;
        private Label label15;
        private TextBox txtWeight;
        private Label label13;
        private TextBox txtName;
        private Panel panel1;
        private Label label8;
        private PictureBox pbUpdateUser;
        private Label label11;
        private PictureBox pbLogout;
        private Label label12;
        private Label label10;
        private PictureBox pbHome;
        private PictureBox pbDeleteUser;
        private Label label2;
        private TextBox txtHeight;
        private DataGridView dgvUserList;
        private Label label4;
    }
}