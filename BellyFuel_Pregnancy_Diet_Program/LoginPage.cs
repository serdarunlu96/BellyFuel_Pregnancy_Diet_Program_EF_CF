using BellyFuel_Pregnancy_Diet_Program.Context;
using BellyFuel_Pregnancy_Diet_Program.Data;
using BellyFuel_Pregnancy_Diet_Program.SeedData;
using BellyFuel_Pregnancy_Diet_Program.Control;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Eventing.Reader;

namespace BellyFuel_Pregnancy_Diet_Program
{
    public partial class LoginPage : Form
    {
        private readonly User user;
        BellyFuelDbContext _db = new BellyFuelDbContext();

        public LoginPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text == "")
            {
                MessageBox.Show("E-mail address cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_db.Users.Where(e => e.Email == txtEmail.Text).Count() == 0)
            {
                MessageBox.Show("This E-mail is not registered!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var user = _db.Users.Include(u => u.Role).FirstOrDefault(u => u.Email == txtEmail.Text);
            if (user != null && user.Password == BellyFuelControl.HashPassword(txtPassword.Text))
            {

                if (user.Role.RoleName == "Administrator")
                {
                    this.Hide();
                    Form adminForm = new AdminUI(user);
                    adminForm.Show();
                }
                else
                {
                    this.Hide();
                    Form userUi = new UserUI(user);
                    userUi.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong Password or E-mail address. Please check and re-enter!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form signUp = new SignUp(user);
            signUp.Show();

        }
    }
}


