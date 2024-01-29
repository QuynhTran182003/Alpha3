using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alpha3.Data_Tier;
using Alpha3.Bussiness_Tier;

namespace Alpha3.Presentation_Tier
{
    public partial class NewClientForm : Form
    {
        private ClienPanel clientPanel;
        public NewClientForm(ClienPanel clienPanel)
        {
            InitializeComponent();
            clientPanel = clienPanel;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Here add to db
            string name = this.tBxName.Text;
            string surname = this.tBxSurname.Text;
            string email = this.tBxEmail.Text;
            string phone = tBxPhone.Text;
            Client c = new Client(name, surname, email, phone);
            c.AddToDB();
            this.Hide();
            this.clientPanel.LoadClient();
        }
    }
}
