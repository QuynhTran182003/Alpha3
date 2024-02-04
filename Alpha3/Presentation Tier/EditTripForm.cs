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
    public partial class EditTripForm : Form
    {
        private TripPanel tripPanel;
        private Trip selectedTrip;
        public EditTripForm(int id, TripPanel trippanel)
        {
            InitializeComponent();
            tripPanel = trippanel;
            selectedTrip = new Trip().GetTripByIdDB(id);
            this.tbOldPrice.Text = selectedTrip.Price.ToString();
            this.tbOldCapa.Text = selectedTrip.Capacity.ToString();
            this.tBxNewPrice.Text = selectedTrip.Price.ToString();
            this.tBxNewCapa.Text = selectedTrip.Capacity.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int capacity = 0;
                selectedTrip.Capacity = int.TryParse(tBxNewCapa.Text, out capacity) ? int.Parse(tBxNewCapa.Text) : capacity;
                selectedTrip.Price = float.Parse(tBxNewPrice.Text);

                this.Hide();
                selectedTrip.UpdateDB();
                this.tripPanel.LoadTrip();
            }
            catch
            {
                MessageBox.Show("Value must be a number");
            }
            
        }
    }
}
