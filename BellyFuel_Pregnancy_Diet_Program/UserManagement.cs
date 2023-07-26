using BellyFuel_Pregnancy_Diet_Program.Context;
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

namespace BellyFuel_Pregnancy_Diet_Program
{
    public partial class UserManagement : Form
    {
        private readonly User user;
        private readonly BellyFuelDbContext db = new BellyFuelDbContext();
        public UserManagement(User user)
        {
            InitializeComponent();
            this.user = user;
            LoadUserList();
        }
        private void LoadUserList()
        {

            var userList = db.Users.Select(user => new
            {
                user.Id,
                user.Email,
                user.Name,
                user.Surname,
                user.Height,
                user.Weight,
                user.Age,
                user.RoleId,
                user.Role.RoleName,
                user.RegisteredDate
            }).ToList();

            dgvUserList.DataSource = userList;

        }

        private void ClearText()
        {
            txtAge.Clear();
            txtHeight.Clear();
            txtWeight.Clear();
            txtName.Clear();
            txtSurname.Clear();
        }

        private void pbDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUserList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a User info to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int selectedUserId = (int)dgvUserList.SelectedRows[0].Cells["Id"].Value;
            User selectedUser = db.Users.Find(selectedUserId);

            if (selectedUser != null && selectedUser.RoleId == 1)
            {
                MessageBox.Show("Admin cannot be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Users.Remove(selectedUser);
            db.SaveChanges();
            LoadUserList();
        }


        private void pbLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form logout = new Logout(user);
            logout.Show();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form adminUI = new AdminUI(user);
            adminUI.Show();
        }

        private void pbUpdateUser_Click(object sender, EventArgs e)
        {
            if (dgvUserList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a User to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            int selectedUserId = (int)dgvUserList.SelectedRows[0].Cells["Id"].Value;
            User selectedUser = db.Users.Find(selectedUserId);



            if (string.IsNullOrWhiteSpace(txtName.Text) && string.IsNullOrWhiteSpace(txtSurname.Text) &&
                string.IsNullOrWhiteSpace(txtHeight.Text) && string.IsNullOrWhiteSpace(txtWeight.Text) &&
                string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Please fill in at least one field to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double height, weight;
            int age;

            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                selectedUser.Name = txtName.Text;
            }



            if (!string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                selectedUser.Surname = txtSurname.Text;
            }



            if (!string.IsNullOrWhiteSpace(txtHeight.Text) && double.TryParse(txtHeight.Text, out height))
            {
                selectedUser.Height = height;
            }



            if (!string.IsNullOrWhiteSpace(txtWeight.Text) && double.TryParse(txtWeight.Text, out weight))
            {
                selectedUser.Weight = weight;
            }



            if (!string.IsNullOrWhiteSpace(txtAge.Text) && int.TryParse(txtAge.Text, out age))
            {
                selectedUser.Age = age;
            }


            db.SaveChanges();
            ClearText();
            LoadUserList();
        }
    }
}
