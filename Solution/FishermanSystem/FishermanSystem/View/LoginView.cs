using FishermanSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishermanSystem.View
{
    public partial class LoginView : Form
    {
        DatabaseController dbController = new DatabaseController();

        public LoginView()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            RegisterView rv = new RegisterView();
            Hide();
            rv.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var users = dbController.ReadAllUsers();
            bool correctUsername = false;
            bool correctPassword = false;
            foreach (var item in users)
            {
                if (username == item.username)
                {
                    correctUsername = true;
                    if (password == item.password)
                    {
                        correctPassword = true;
                    }
                }
            }
            if (correctUsername)
            {
                if (correctPassword)
                {
                    MainView mainpage = new MainView();
                    Hide();
                    mainpage.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
            else
            {
                MessageBox.Show("Wrong username");
            }
        }
    }
}
