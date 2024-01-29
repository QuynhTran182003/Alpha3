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
            SqlCommand cmd = new SqlCommand("select * from Client", DatabaseSingleton.GetInstance());
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;

            DatabaseSingleton.CloseConnection();
        }

    }
}
