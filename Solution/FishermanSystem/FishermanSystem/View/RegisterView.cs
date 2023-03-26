using FishermanSystem.Controller;
using FishermanSystem.Model;
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
    public partial class RegisterView : Form
    {
        DatabaseController dbController = new DatabaseController();

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
            bool valid = true; 

            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var boatName = txtBoatName.Text;
            var boatExpiryDate = dtpBoatExpiryDate.Value;
            int boatFuelConsumption;
            var isFuelNum = int.TryParse(txtFuelConsumption.Text, out boatFuelConsumption);
            if (!isFuelNum)
            {
                valid = false;
                MessageBox.Show("Invalid input for fuel. It should be a number");
            }
            var isHobby = 0;
            if (checkBoxHobby.Checked)
            {
                isHobby = 1;
            }

            var user = new User(username, password, isHobby);
            var boat = new Boat(boatName, boatExpiryDate, boatFuelConsumption);

            if (valid)
            {
                dbController.CreateRegister(user, boat);
            }
        }
    }
}
