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

        public AdminPanelView()
        {
            InitializeComponent();
        }

        private void RefreshData()
        { 
            this.fishing_SessionTableAdapter.Fill(this.fishermanSystemDBDataSet.Fishing_Session);
            this.boatTableAdapter.Fill(this.fishermanSystemDBDataSet.Boat);
            this.userTableAdapter.Fill(this.fishermanSystemDBDataSet.User);
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
        }

        private void dgvBoats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBoats.CurrentRow;
            int registerId = int.Parse(row.Cells[0].Value.ToString());
            int id = int.Parse(row.Cells[1].Value.ToString());
            lblId.Text = "Selected user ID: " + registerId.ToString();
            lblRemoveRegistryInfo.Text = "Remove currently selected boat with ID: " + id;
        }

        private void dgvFishingInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvFishingInfo.CurrentRow;
            int registerId = int.Parse(row.Cells[0].Value.ToString());
            int id = int.Parse(row.Cells[1].Value.ToString());
            lblId.Text = "Selected user ID: " + registerId.ToString();
            lblRemoveRegistryInfo.Text = "Remove currently selected fishing session with ID: " + id;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            RegisterView register = new RegisterView(true);
            Hide();
            register.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnRemoveRegistry_Click(object sender, EventArgs e)
        {
            
        }
    }
}
