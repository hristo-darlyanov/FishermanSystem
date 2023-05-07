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

        private void btnShowBiggestCatchFromHobbyFishers_Click(object sender, EventArgs e)
        {
            var ds = controller.CustomQuery("select * from [User]"); // Change this to the corresponding query in the excersise
            dgvQueryData.ReadOnly = true;
            dgvQueryData.DataSource = ds.Tables[0];
        }

        private void btnShowExpiringLicenses_Click(object sender, EventArgs e)
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
