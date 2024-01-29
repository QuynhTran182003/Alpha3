using Alpha3.Presentation_Tier;
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
            tripPanel1.Visible = false;
            reservationPanel1.Visible = false;
            clienPanel1.Visible = true;
            clienPanel1.LoadClient();
        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            clienPanel1.Visible=false;
            reservationPanel1.Visible = false;
            tripPanel1.Visible = true;
            //tripPanel1.LoadTrip();

        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            clienPanel1.Visible = false;
            tripPanel1.Visible = false;
            reservationPanel1.Visible = true;
            // reservationPanel1.LoadReservation();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            NewClientForm newClientForm = new NewClientForm(clienPanel1);
            newClientForm.ShowDialog();
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {
        }
    }
}
