using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha3
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            lbContent.Text = btnClient.Text;

        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            lbContent.Text = btnTrip.Text;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            lbContent.Text = btnReservation.Text;
        }
    }
}
