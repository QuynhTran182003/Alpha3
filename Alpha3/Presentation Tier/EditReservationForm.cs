using Alpha3.Bussiness_Tier;
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
    public partial class EditReservationForm : Form
    {
        private ReservationPanel reservationPanel;
        private int reid;
        public EditReservationForm(int id, string client, string depart, string destin, float total, bool status, ReservationPanel reserPanel)
        {
            InitializeComponent();
            reid = id;
            plhdReserId.Text = id.ToString();
            plhdClient.Text = client;
            plhdDepart.Text = depart;
            plhdDestin.Text = destin;
            plhdTotal.Text = total.ToString();
            if (status)
            {
                radPaid.Checked = true;
                radUnpaid.Checked = false;
            }
            else
            {
                radPaid.Checked = false;
                radUnpaid.Checked = true;
            }
            reservationPanel = reserPanel;
        }

        private void EditReservationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation(reid);
            reservation.Status = radPaid.Checked;
            reservation.UpdateDB();

            this.Hide();
            this.reservationPanel.LoadReservation();
        }
    }
}
