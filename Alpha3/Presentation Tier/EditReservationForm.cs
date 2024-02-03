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
        public EditReservationForm(int id, ReservationPanel reserPanel)
        {
            InitializeComponent();
            new Reservation().GetReservationById(id);
            reservationPanel = reserPanel;
        }

        private void EditReservationForm_Load(object sender, EventArgs e)
        {

            this.Hide();
            this.reservationPanel.LoadReservation();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
