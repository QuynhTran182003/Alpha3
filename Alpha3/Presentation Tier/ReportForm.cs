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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void tripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTripReport();
            this.label1.Text = "Trip";
        }



        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadReservationReport();
            this.label1.Text = "Reservation";

        }

        private void LoadTripReport() { 
            this.tripReport1.Visible = true;
        }
        private void LoadReservationReport() { 
            this.tripReport1.Visible = false;

        }
    }
}
