using Alpha3.Data_Tier;
using System;
using System.Windows.Forms;

namespace Alpha3.Presentation_Tier
{
    public partial class ReservationPanel : UserControl
    {
        public ReservationPanel()
        {
            InitializeComponent();
        }



        public void LoadReservation()
        {
            ReservationDAO reservationDAO = new ReservationDAO();
            reservationDAO.GetAll(this.dataGridView1);
        }

        private void btnNewRese_Click(object sender, EventArgs e)
        {
            NewReservationForm frm = new NewReservationForm(this);
            frm.ShowDialog();
        }
    }
}
