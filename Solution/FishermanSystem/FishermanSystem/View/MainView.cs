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
    public partial class MainView : Form
    {
        DatabaseController controller = new DatabaseController();

        public MainView()
        {
            InitializeComponent();
        }

        private void btnShowExpiringLicenses_Click(object sender, EventArgs e)
        {
            var ds = controller.CustomQuery("select boat_name, expire_date from [Boat] where expire_date BETWEEN GETDATE() AND DATEADD(month, 1, GETDATE())");
            dgvQueryData.ReadOnly = true;
            dgvQueryData.DataSource = ds.Tables[0];
        }

        private void btnShowBiggestCatchFromHobbyFishers_Click(object sender, EventArgs e)
        {
            // To do
        }


        private void btnShowFishingInfo_Click(object sender, EventArgs e)
        {
            // To do
        }

        private void btnShowCarbonPrint_Click(object sender, EventArgs e)
        {
            // To do
        }
    }
}
