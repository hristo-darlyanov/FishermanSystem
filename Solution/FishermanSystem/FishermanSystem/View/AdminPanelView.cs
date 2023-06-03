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
        AdminPanelController adminPanelController = new AdminPanelController();
        DatabaseController databaseController = new DatabaseController();

        public AdminPanelView()
        {
            InitializeComponent();
        }

        private void RefreshData()
        {
            dgvFishingInfo.DataSource = databaseController.ReadAllFishingSessions();
            dgvUsers.DataSource = databaseController.ReadAllUsers();
            dgvBoats.DataSource = databaseController.ReadAllBoats();
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
            if (selectedRegistryId != null)
            {
                if (selectedRegistry == "user")
                {
                    adminPanelController.RemoveUser(selectedRegistryId);   
                }
            }
            else
            {
                MessageBox.Show("Select a registry to remove");
            }
        }
    }
}
