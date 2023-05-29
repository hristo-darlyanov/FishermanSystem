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
            int id = int.Parse(row.Cells[0].Value.ToString());
            lblId.Text = "Selected user ID: " + id.ToString();
        }

        private void dgvBoats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvBoats.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            lblId.Text = "Selected user ID: " + id.ToString();
        }

        private void dgvFishingInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvFishingInfo.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            lblId.Text = "Selected user ID: " + id.ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            RegisterView register = new RegisterView(true);
            Hide();
            register.Show();
        }
    }
}
