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
    public partial class NewTripForm : Form
    {
        public NewTripForm()
        {
            InitializeComponent();
        }

        private void btnNewTrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Trip OK!");
            this.Hide();
        }
    }
}
