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
    public partial class AdminPanelView : Form
    {
        int selectedRegistryId;
        string selectedRegistry;
        UserController userController = new UserController();
        BoatController boatController = new BoatController();
        FishingSessionController fishingSessionController = new FishingSessionController();
        DatabaseController databaseController = new DatabaseController();

        public AdminPanelView()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            dgvFishingInfo.DataSource = fishingSessionController.ReadAllFishingSessions();
            dgvUsers.DataSource = userController.ReadAllUsers();
            dgvBoats.DataSource = boatController.ReadAllBoats();
        }

        private void AdminPanelView_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvUsers.CurrentRow;
            int registerId = int.Parse(row.Cells[0].Value.ToString());
            lblId.Text = "Selected user ID: " + registerId.ToString();
            lblRemoveRegistryInfo.Text = "Remove currently selected user and all of its info";

            selectedRegistryId = registerId;
            selectedRegistry = "user";
        }

        private void dgvBoats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBoats.CurrentRow;
            int registerId = int.Parse(row.Cells[0].Value.ToString());
            int id = int.Parse(row.Cells[1].Value.ToString());
            lblId.Text = "Selected user ID: " + registerId.ToString();
            lblRemoveRegistryInfo.Text = "Remove currently selected boat with ID: " + id;

            selectedRegistryId = id;
            selectedRegistry = "boat";
        }

        private void dgvFishingInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvFishingInfo.CurrentRow;
            int registerId = int.Parse(row.Cells[0].Value.ToString());
            int id = int.Parse(row.Cells[1].Value.ToString());
            lblId.Text = "Selected user ID: " + registerId.ToString();
            lblRemoveRegistryInfo.Text = "Remove currently selected fishing session with ID: " + id;

            selectedRegistryId = id;
            selectedRegistry = "fishingSession";
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            RegisterView register = new RegisterView(true);
            Hide();
            register.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnRemoveRegistry_Click(object sender, EventArgs e)
        {
            if (selectedRegistry != null && selectedRegistry != string.Empty)
            {
                if (selectedRegistry == "user")
                {
                    userController.RemoveUser(selectedRegistryId);   
                }
                if (selectedRegistry == "boat")
                {
                    boatController.RemoveBoat(selectedRegistryId);
                }
                if (selectedRegistry == "fishingSession")
                {
                    fishingSessionController.RemoveFishingSession(selectedRegistryId);
                }
                MessageBox.Show("Removed registry from database");
                RefreshData();
            }
            else
            {
                MessageBox.Show("Select a registry to remove");
            }
        }

        private void btnBackToMainView_Click(object sender, EventArgs e)
        {
            MainView mainView = new MainView();
            Hide();
            mainView.Show();
        }
    }
}
