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
        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            clienPanel1.Visible=false;
            reservationPanel1.Visible = false;
            tripPanel1.Visible = true;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            clienPanel1.Visible = false;
            tripPanel1.Visible = false;
            reservationPanel1.Visible = true;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            NewClientForm newClientForm = new NewClientForm();
            newClientForm.ShowDialog();
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {
            clienPanel1.LoadClient();
            //tripPanel1.LoadTrip();
            //reservationPanel1.LoadReservation();
        }
    }
}
