using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha3.Presentation_Tier
{
    public partial class TripPanel : UserControl
    {
        public TripPanel()
        {
            InitializeComponent();
        }

        private void btnNewTrip_Click(object sender, EventArgs e)
        {
            NewTripForm ntf = new NewTripForm();
            ntf.ShowDialog();
        }
    }
}
