using Alpha3.Bussiness_Tier;
using System;
using System.Collections.Generic;
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
                MessageBox.Show("Trip deleted successfully");
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
            throw new NotImplementedException();
        }

        public void Update(int id, Hotel newEle)
        {
            throw new NotImplementedException();
        }
    }
}
