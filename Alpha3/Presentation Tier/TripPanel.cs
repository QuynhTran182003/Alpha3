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
    public partial class TripPanel : UserControl
    {
        public TripPanel()
        {
            InitializeComponent();
        }

        private void btnNewTrip_Click(object sender, EventArgs e)
        {
            NewTripForm ntf = new NewTripForm(this);
            ntf.ShowDialog();
        }

        public void LoadTrip()
        {
            TripDAO tripDAO = new TripDAO();
            tripDAO.GetAll(this.dataGridView1);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
                if (MessageBox.Show($"Are u sure to delete trip {id}?", "Delete client", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    {
                        Trip tr = new Trip(id);
                        tr.Delete(id);
                        this.LoadTrip();
                    }
                }
            }
        }
    }
}
