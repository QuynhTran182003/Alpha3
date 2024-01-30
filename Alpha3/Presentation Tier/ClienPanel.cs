using Alpha3.Bussiness_Tier;
using Alpha3.Data_Tier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha3.Presentation_Tier
{
    public partial class ClienPanel : UserControl
    {
        public ClienPanel()
        {
            InitializeComponent();
        }

        private void btnNewClient_Click(object sender, EventArgs e)
        {
            NewClientForm frm = new NewClientForm(this);
            frm.ShowDialog();
        }

        public void LoadClient()
        {
            ClientDAO clientDAO = new ClientDAO();
            clientDAO.GetAll(this.dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
            string name = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            string surname = dataGridView1.Rows[e.RowIndex].Cells["Surname"].FormattedValue.ToString();
            string email = dataGridView1.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
            string phone = dataGridView1.Rows[e.RowIndex].Cells["Telephone"].FormattedValue.ToString();

            EditClientForm edf = new EditClientForm(id, name, surname, email, phone, this);
            edf.ShowDialog();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                string name = dataGridView1.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                string surname = dataGridView1.Rows[e.RowIndex].Cells["Surname"].FormattedValue.ToString();
                if (MessageBox.Show($"Are u sure to delete client {name} {surname}?", "Delete client", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    {
                        int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                        Client client = new Client(id);

                        client.Delete(id);
                        this.LoadClient();
                    }
                }
            }
        }
    }
}
