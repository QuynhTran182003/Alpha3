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
    public partial class NewReservationForm : Form
    {
        private ReservationPanel panel;
        public NewReservationForm(ReservationPanel reservationPanel)
        {
            InitializeComponent();
            panel = reservationPanel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string[] clientArr = this.cbClient.Text.Split(' ');
            string[] tripArr = this.cbTrip.Text.Split('-');

            int idClient = int.Parse(clientArr[0]);
            int idTrip = int.Parse(tripArr[0]);
            int nbPple = (int) numericUpDown1.Value;

            Reservation reservation = new Reservation(idClient, idTrip, nbPple);
            reservation.AddToDB();
            this.Hide();
            this.panel.LoadReservation();           
        }

        private void NewReservationForm_Load(object sender, EventArgs e)
        {
            this.comboLoad(cbClient, cbTrip);
        }

        private void comboLoad(System.Windows.Forms.ComboBox client, System.Windows.Forms.ComboBox trip)
        {
            SqlCommand cmd = new SqlCommand("select concat(client.Id, ' ', client.Name, ' ', client.Surname) as 'Client' from Client;", DatabaseSingleton.GetInstance());
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            client.Items.Clear();
            foreach (DataRow dr in table.Rows)
            {
                client.Items.Add(dr["Client"].ToString());
            }

            cmd = new SqlCommand("select concat(trip.Id, '-', city.Name) as 'Trip' from Trip inner join city on trip.id_destinationCity = city.Id;", DatabaseSingleton.GetInstance());
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            table = new DataTable();
            da.Fill(table);
            trip.Items.Clear();
            foreach (DataRow dr in table.Rows)
            {
                trip.Items.Add(dr["Trip"].ToString());
            }
        }
    }
}
