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
            var ds = controller.CustomQuery("select boat_name, expire_date from [Boat] where expire_date between GETDATE() and DATEADD(month, 1, GETDATE())");
            dgvQueryData.ReadOnly = true;
            dgvQueryData.DataSource = ds.Tables[0];
        }

        private void btnShowBiggestCatchFromHobbyFishers_Click(object sender, EventArgs e)
        {
            var ds = controller.CustomQuery("select u.username, SUM(f.amount_fished_kg) as amount_fished_for_the_last_year from [User] as u inner join [Fishing_Session] as f on (u.register_id = f.register_id) where date_of_fishing_session between GETDATE() and DATEADD(year, 1, GETDATE()) and u.hobby = 1 group by u.username, f.amount_fished_kg order by f.amount_fished_kg");
            dgvQueryData.ReadOnly = true;
            dgvQueryData.DataSource = ds.Tables[0];
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
