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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Alpha3.Presentation_Tier
{
    public partial class NewTripForm : Form
    {
        private TripPanel trippanel;
        public NewTripForm(TripPanel tripPanel)
        {
            InitializeComponent();
            trippanel = tripPanel;
        }

        private void btnNewTrip_Click(object sender, EventArgs e)
        {
                string[] transport = this.comboTransport.Text.Split(' ');
                string[] hotel = this.comboHotel.Text.Split(' ');
                string[] depart = this.comboCity.Text.Split(' ');
                string[] destin = this.comboCity2.Text.Split(' ');

                try{
                    int idTransport = int.Parse(transport[0]);
                    int idHotel = int.Parse(hotel[0]);
                    int idCity1 = int.Parse(depart[0]);
                    int idCity2 = int.Parse(destin[0]);
                    int capacity = (int)(this.numericUpDown1.Value);
                    DateTime dateDepart = this.dateTimePicker1.Value;
                    DateTime dateReturn = this.dateTimePicker2.Value;
                    float price;

                    if (float.TryParse(this.tBxPrice.Text, out price))
                    {
                        Trip trip = new Trip(idTransport, idHotel, idCity1, idCity2, dateDepart, dateReturn, price, capacity);
                        trip.AddToDB();
                        this.trippanel.LoadTrip();
                    }
                    else
                    {
                        MessageBox.Show("Price must be a proper number");
                    }

                    this.Hide();
                } catch (FormatException ex) {
                    MessageBox.Show("All fields must be filled happened. Try again.");

                }


        }

        private void NewTripForm_Load(object sender, EventArgs e)
        {
            this.comboLoad(comboTransport, comboHotel, comboCity, comboCity2);
        }

        private void comboLoad(System.Windows.Forms.ComboBox transport, System.Windows.Forms.ComboBox hotel, System.Windows.Forms.ComboBox city1, System.Windows.Forms.ComboBox city2)
        {
            SqlCommand cmd = new SqlCommand("select concat(transport.Id, ' ',[Type]) as 'Type' from Transport;", DatabaseSingleton.GetInstance());
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            comboTransport.Items.Clear();
            foreach (DataRow dr in table.Rows)
            {
                comboTransport.Items.Add(dr["Type"].ToString());
            }

            cmd = new SqlCommand("select concat(hotel.Id, ' ',[Name]) as 'Name' from Hotel;", DatabaseSingleton.GetInstance());
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            table = new DataTable();
            da.Fill(table);
            comboHotel.Items.Clear();
            foreach (DataRow dr in table.Rows)
            {
                comboHotel.Items.Add(dr["Name"].ToString());
            }

            cmd = new SqlCommand("select concat(city.Id, ' ',[Name]) as 'Name' from City;", DatabaseSingleton.GetInstance());
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            table = new DataTable();
            da.Fill(table);
            comboCity.Items.Clear();
            comboCity2.Items.Clear();
            foreach (DataRow dr in table.Rows)
            {
                comboCity.Items.Add(dr["Name"].ToString());
                comboCity2.Items.Add(dr["Name"].ToString());
            }
        }
    }
}
