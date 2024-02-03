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
    public partial class TripReport : UserControl
    {
        public TripReport()
        {
            InitializeComponent();
        }

        private void TripReport_Load(object sender, EventArgs e)
        {
            TripDAO tripDAO = new TripDAO();
            tripDAO.GetReservedAll(this.dataGridView1);
        }
    }
}
