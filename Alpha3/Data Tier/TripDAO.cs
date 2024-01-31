using Alpha3.Bussiness_Tier;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha3.Data_Tier
{
    public class TripDAO : IDAO<Trip>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void GetById(int id, DataGridView dataview)
        {
            throw new NotImplementedException();
        }

        public void Save(Trip ele)
        {
            SqlCommand cmd = new SqlCommand("" +
                "INSERT INTO Trip (Id_transport, Id_hotel, Id_departCity, Id_destinationCity, Date_depart, Date_return, Price)\r\nVALUES\r\n    (@Id_Trans, @Id_Hotel, @Id_Depart, @Id_Destination, @Date_depart, '@Date_return, @Price);", 
                DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id_Trans", ele.Id_transport);
            cmd.Parameters.AddWithValue("@Id_Hotel", ele.Id_hotel);
            cmd.Parameters.AddWithValue("@Id_Depart", ele.Id_departCity);
            cmd.Parameters.AddWithValue("@Id_Destination", ele.Id_destinationCity);
            cmd.Parameters.AddWithValue("@Date_depart", ele.Date_depart);
            cmd.Parameters.AddWithValue("@Date_return", ele.Date_return);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trip added");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            DatabaseSingleton.CloseConnection();
        }

        public void Update(int id, Trip newEle)
        {
            throw new NotImplementedException();
        }

        public void GetAll(DataGridView dataView)
        {
            SqlCommand cmd = new SqlCommand("select \r\nDepartureCity.Name AS DepartureCityName,\r\nDestinationCity.Name AS DestinationCityName, transport.[Type], date_depart, date_return, hotel.name,\r\nhotel.quality, trip.price from trip\r\ninner join transport on trip.id_transport = transport.id\r\ninner join hotel on trip.id_hotel = hotel.id\r\nINNER JOIN City AS DepartureCity ON Trip.Id_departCity = DepartureCity.ID\r\nINNER JOIN City AS DestinationCity ON Trip.Id_destinationCity = DestinationCity.ID;", DatabaseSingleton.GetInstance());
            //SqlCommand cmd = new SqlCommand("select * from Trip", DatabaseSingleton.GetInstance());
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
            dataView.DataSource = dt;

            DatabaseSingleton.CloseConnection();

        }
    }
}
