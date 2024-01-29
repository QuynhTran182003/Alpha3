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
    public partial class EditClientForm : Form
    {
        public ClienPanel cliPanel;
        public EditClientForm(int id, string n, string sn, string mai, string phone, ClienPanel cliPan)
        {
            InitializeComponent();
            lbId.Text = id.ToString();
            tBxName.Text = n;
            tBxSurname.Text = sn;
            tBxEmail.Text = mai;
            tBxPhone.Text = phone;
            this.cliPanel = cliPan;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = tBxName.Text;
            string surname = tBxSurname.Text;
            string email = tBxEmail.Text;
            string phone = tBxPhone.Text;
            Bussiness_Tier.Client newCli = new Bussiness_Tier.Client(name, surname, email, phone);
            newCli.UpdateDB();
            this.cliPanel.LoadClient();
            
        }
    }
}
