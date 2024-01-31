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
        public NewTripForm()
        {
            InitializeComponent();
            
        }

        private void btnNewTrip_Click(object sender, EventArgs e)
        {
            string transport = this.comboTransport.Text;
            string hotel = this.comboHotel.Text;
            string depart = this.comboCity.Text;
            string destin = this.comboCity2.Text;
            DateTime dateDepart = this.dateTimePicker1.Value;
            DateTime dateReturn = this.dateTimePicker2.Value;
            float price = float.Parse(this.tBxPrice.Text);


            //MessageBox.Show("New Trip OK!");
            // get id from those strings
            //Trip trip = new Trip(transport, hotel, depart, destin, dateDepart, dateReturn, price);
            //trip.AddToDB();
            this.Hide();
        }

        private void NewTripForm_Load(object sender, EventArgs e)
        {
            this.comboLoad(comboTransport, comboHotel, comboCity, comboCity2);
        }

        private void comboLoad(System.Windows.Forms.ComboBox transport, System.Windows.Forms.ComboBox hotel, System.Windows.Forms.ComboBox city1, System.Windows.Forms.ComboBox city2)
        {
            SqlCommand cmd = new SqlCommand("select [Type] from Transport;", DatabaseSingleton.GetInstance());
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            da.Fill(table);
            comboTransport.Items.Clear();
            foreach (DataRow dr in table.Rows)
            {
                comboTransport.Items.Add(dr["Type"].ToString());
            }

            cmd = new SqlCommand("select [Name] from Hotel;", DatabaseSingleton.GetInstance());
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            table = new DataTable();
            da.Fill(table);
            comboHotel.Items.Clear();
            foreach (DataRow dr in table.Rows)
            {
                comboHotel.Items.Add(dr["Name"].ToString());
            }

            cmd = new SqlCommand("select [Name] from City;", DatabaseSingleton.GetInstance());
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
