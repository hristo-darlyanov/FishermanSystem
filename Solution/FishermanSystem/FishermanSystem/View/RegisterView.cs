using FishermanSystem.Controller;
using FishermanSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishermanSystem.View
{
    public partial class RegisterView : Form
    {
        DatabaseController dbController = new DatabaseController();
        Regex validPassword = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,}$");

        public RegisterView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginView lv = new LoginView();
            Hide();
            lv.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var confirmPassword = txtConfirmPassword.Text;
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var isHobby = 0;
            if (checkBoxHobby.Checked)
            {
                isHobby = 1;
            }

            User user = new User(username, password, firstName, lastName, isHobby);

            if (ValidUser(username, password, confirmPassword, firstName, lastName))
            {
                dbController.CreateRegister(user);
                var mv = new MainView();
                Hide();
                mv.Show();
            }
        }

        private bool ValidUser(string username, string password, string confirmPassword, string firstName, string lastName)
        {
            if (!string.IsNullOrEmpty(username))
            {
                var users = dbController.ReadAllUsers();
                var usernameExists = false;
                foreach (var user in users)
                {
                    if (username == user.username)
                    {
                        usernameExists = true;
                    }
                }
                if (usernameExists)
                {
                    MessageBox.Show("This username already exists. Please choose another name for your profile.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Username cannot be empty");
                return false;
            }
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("First name cannot be empty");
                return false;
            }
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last name cannot be empty");
                return false;
            }
            if (!string.IsNullOrEmpty(password))
            {
                if (validPassword.IsMatch(password))
                {
                    if (password != confirmPassword)
                    {
                        MessageBox.Show("Passwords do not match");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Password must contain at least 8 characters and have at least one of the following:\n" +
                        "At least 1 Uppercase letter\n" +
                        "At least 1 Lowercase letter\n" +
                        "At least 1 digit");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Password cannot be empty");
                return false;
            }
            return true;
        }
    }
}
