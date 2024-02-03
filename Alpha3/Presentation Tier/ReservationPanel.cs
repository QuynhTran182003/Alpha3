using Alpha3.Bussiness_Tier;
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                if (MessageBox.Show($"Are u sure to delete reservation {id}?", "Delete client", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    {
                        Reservation r = new Reservation(id);

                        r.Delete(id);
                        this.LoadReservation();
                    }
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
            string client = dataGridView1.Rows[e.RowIndex].Cells["Client"].FormattedValue.ToString();
            string departure = dataGridView1.Rows[e.RowIndex].Cells["Departure"].FormattedValue.ToString();
            string destination = dataGridView1.Rows[e.RowIndex].Cells["Destination"].FormattedValue.ToString();
            float total = (float) Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Total (CZK)"].FormattedValue.ToString());
            //todo
            bool a = (bool) dataGridView1.Rows[e.RowIndex].Cells["Status"].FormattedValue;

            Console.WriteLine(a);
            /*EditReservationForm erf = new EditReservationForm(this);
            erf.ShowDialog()*/
        }
    }
}
