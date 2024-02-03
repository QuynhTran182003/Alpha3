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
        public void Update(int id, ReservationDAO newEle)
        {
            throw new NotImplementedException();
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

        public void Update(int id, Reservation newEle)
        {
            throw new NotImplementedException();
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
    }

}
