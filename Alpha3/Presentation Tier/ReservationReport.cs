using Alpha3.Bussiness_Tier;
using Alpha3.Data_Tier;
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
    public partial class ReservationReport : UserControl
    {
        public ReservationReport()
        {
            InitializeComponent();
        }

        private void ReservationReport_Load(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();
            reservation.GetAllDB(this.dataGridView1);
            this.label5.Text = reservation.GetReport().ToString() + "Kc";
            this.lbPaid.Text = reservation.GetPaid().ToString();
            this.lbUnpaid.Text = reservation.GetUnpaid().ToString();
        }
    }
}
