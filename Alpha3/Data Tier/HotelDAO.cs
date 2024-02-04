using Alpha3.Bussiness_Tier;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha3.Data_Tier
{
    public class HotelDAO : IDAO<Hotel>
    {
        public void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Hotel where id = @Id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id", id);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hotel deleted successfully");
            }
            catch (SqlException)
            {
                MessageBox.Show("Unable to delete the trip which has been reserved by client. You must cancel their reservation first.");
                throw;
            }

            DatabaseSingleton.CloseConnection();
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Hotel ele)
        {
            SqlCommand cmd = new SqlCommand("insert into Hotel values(@Name, @Street, @Number1, @Number2, @Postcode, @Quality)", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Name", ele.Name);
            cmd.Parameters.AddWithValue("@Street", ele.Street);
            cmd.Parameters.AddWithValue("@Number1", ele.Number1);
            cmd.Parameters.AddWithValue("@Number2", ele.Number2 );
            cmd.Parameters.AddWithValue("@Postcode", ele.Postcode);
            cmd.Parameters.AddWithValue("@Quality", ele.Quality);
            try
            {
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Hotel added");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            DatabaseSingleton.CloseConnection();
        }

        public void Update(int id, Hotel newEle)
        {
            throw new NotImplementedException();
        }

        public void GetAll(DataGridView dataView)
        {
            SqlCommand cmd = new SqlCommand("select * from Hotel", DatabaseSingleton.GetInstance());
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
