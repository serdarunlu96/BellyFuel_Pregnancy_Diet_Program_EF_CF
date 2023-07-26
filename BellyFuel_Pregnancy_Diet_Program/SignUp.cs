using BellyFuel_Pregnancy_Diet_Program.Context;
using BellyFuel_Pregnancy_Diet_Program.Control;
using BellyFuel_Pregnancy_Diet_Program.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BellyFuel_Pregnancy_Diet_Program
{
    public partial class SignUp : Form
    {
        BellyFuelDbContext _db = new BellyFuelDbContext();
        private readonly User user;

        public SignUp(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void btnSignUpSU_Click(object sender, EventArgs e)
        {
            string email = txtEmailSU.Text;
            string password = txtPasswordSU.Text;

            if (email == "admin@admin.com")
            {
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("E-mail address cannot be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!email.Contains("@") || !email.Contains(".com"))
                {
                    MessageBox.Show("This is not a proper e-mail address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_db.Users.Any(u => u.Email == email))
                {
                    MessageBox.Show("This e-mail has already been used.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsPasswordValid(password))
                {
                    MessageBox.Show("Password needs to be a minimum of 8 characters and should contain at least 1 lowercase, 1 uppercase, and 1 special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Role adminRole = _db.Roles.FirstOrDefault(r => r.RoleName == "Administrator");
                if (adminRole == null)
                {
                    MessageBox.Show("Administrator role not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User adminUser = new User()
                {
                    Email = email,
                    Password = BellyFuelControl.HashPassword(password),
                    Role = adminRole,
                    Name = txtNameSU.Text,
                    Surname = txtSurnameSU.Text,
                    Age = Convert.ToInt32(txtAgeSU.Text),
                    Height = Convert.ToDouble(txtHeightSU.Text),
                    Weight = Convert.ToDouble(txtWeightSU.Text),
                    IsPregnant = rbYesSU.Checked,
                    RoleId = adminRole.Id
                };

                _db.Users.Add(adminUser);
                _db.SaveChanges();

                MessageBox.Show("Admin user created successfully.");
                this.Close();
                Form loginPage = new LoginPage(adminUser);
                loginPage.Show();
            }
            else
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("E-mail address and password cannot be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(txtNameSU.Text))
                {
                    MessageBox.Show("Name cannot be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(txtSurnameSU.Text))
                {
                    MessageBox.Show("Surname cannot be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (!email.Contains("@") || !email.Contains(".com"))
                {
                    MessageBox.Show("This is not a proper e-mail address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_db.Users.Any(u => u.Email == email))
                {
                    MessageBox.Show("This e-mail has already been used.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!IsPasswordValid(password))
                {
                    MessageBox.Show("Password needs to be a minimum of 8 characters and should contain at least 1 lowercase, 1 uppercase, and 1 special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int age;
                if (!int.TryParse(txtAgeSU.Text, out age))
                {
                    MessageBox.Show("Invalid Age!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double height;
                if (!double.TryParse(txtHeightSU.Text, out height))
                {
                    MessageBox.Show("Invalid Height!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double weight;
                if (!double.TryParse(txtWeightSU.Text, out weight))
                {
                    MessageBox.Show("Invalid Weight!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Role userRole = _db.Roles.FirstOrDefault(r => r.RoleName == "User");
                if (userRole == null)
                {
                    MessageBox.Show("User role not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User newUser = new User()
                {
                    Email = email,
                    Password = BellyFuelControl.HashPassword(password),
                    Role = userRole,
                    Name = txtNameSU.Text,
                    Surname = txtSurnameSU.Text,
                    Age = age,
                    Height = height,
                    Weight = weight,
                    IsPregnant = rbYesSU.Checked,
                    RoleId = userRole.Id
                };

                if (rbYesSU.Checked)
                {
                    newUser.IsPregnant = true;
                }
                else
                {
                    MessageBox.Show("This program is only for pregnants!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _db.Users.Add(newUser);
                _db.SaveChanges();

                MessageBox.Show("User created successfully.");
                this.Close();
                Form loginPage = new LoginPage(newUser);
                loginPage.Show();
            }
        }

        private bool IsPasswordValid(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
                if (char.IsLower(c))
                {
                    hasLowerCase = true;
                }
                if (char.IsSymbol(c) || char.IsPunctuation(c))
                {
                    hasSpecialChar = true;
                }
            }

            return hasUpperCase && hasLowerCase && hasSpecialChar;
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loginPage = new LoginPage(user);
            loginPage.Show();
        }
    }
}

