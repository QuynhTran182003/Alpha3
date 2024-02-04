using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alpha3.Bussiness_Tier;

namespace Alpha3.Data_Tier
{
    public class ReservationDAO : IDAO<Reservation>
    {
        public void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Reservation where id = @Id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id", id);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation deleted successfully");
            }
            catch (SqlException)
            {
                MessageBox.Show("Unable to delete the reservation. Please reach out to our support center.");
            }

            DatabaseSingleton.CloseConnection();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Reservation GetReservationById(int id)
        {
            //todo
            SqlCommand cmd = new SqlCommand("select * from Reservation where id = @Id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id", id);
            Reservation r = new Reservation();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {

                    /*tr.Id = (int)reader["ID"];
                    tr.Id_transport = (int)reader["Id_Transport"];
                    tr.Id_hotel = (int)reader["Id_hotel"];
                    tr.Id_departCity = (int)reader["Id_departCity"];
                    tr.Id_destinationCity = (int)reader["Id_destinationCity"];
                    tr.Date_depart = (DateTime)reader["Date_depart"];
                    tr.Date_return = (DateTime)reader["Date_return"];
                    tr.Price = (float)((decimal)reader["Price"]);
                    tr.Capacity = (int)reader["Capacity"];*/
                }

            }
            DatabaseSingleton.CloseConnection();
            return r;
        } 

        public void Update(int id, Reservation newEle)
        {
            SqlCommand cmd = new SqlCommand("update Reservation set Status = @Status where ID = @Id ", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Status", newEle.Status? 1 : 0);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DatabaseSingleton.CloseConnection();
        }

        

        public void Save(Reservation ele)
        {
            SqlCommand cmd = new SqlCommand("insert into Reservation (Id_client, Id_trip, Number_pple, Date_reservation) values (@Id_client, @Id_trip, @Number_pple, SYSDATETIME())", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id_client", ele.Id_client);
            cmd.Parameters.AddWithValue("@Id_trip", ele.Id_Trip);
            cmd.Parameters.AddWithValue("@Number_pple", ele.Number_pple);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation added");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            DatabaseSingleton.CloseConnection();
        }


        public void GetAll(DataGridView dataView)
        {
            SqlCommand cmd = new SqlCommand("select * from ReservationView", DatabaseSingleton.GetInstance());
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

        public float GetReportDB()
        {
            SqlCommand cmd = new SqlCommand("select sum(Reservation.Number_pple * Trip.Price) as 'Total' from Reservation inner join trip on trip.ID = Reservation.Id_trip\r\n", DatabaseSingleton.GetInstance());
            int total = 0;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    total = (int)((decimal)reader["Total"]);
                }
            }
            DatabaseSingleton.CloseConnection();

            return (float)total;
        }

        

        public int GetPaidDB()
        {
            SqlCommand cmd = new SqlCommand("select count(Reservation.ID) as 'Paid' from Reservation where Reservation.Status = 1", DatabaseSingleton.GetInstance());
            int total = 0;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    total = (int)reader["Paid"];
                }
            }
            DatabaseSingleton.CloseConnection();

            return (int)total;
        }


        public int GetUnpaidDB()
        {
            SqlCommand cmd = new SqlCommand("select count(Reservation.ID) as 'Unpaid' from Reservation where Reservation.Status = 0", DatabaseSingleton.GetInstance());
            int total = 0;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    total = (int)reader["Unpaid"];
                }
            }
            DatabaseSingleton.CloseConnection();

            return (int)total;
        }
    }

}
