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
            throw new NotImplementedException();
        }

        public void Update(int id, Trip newEle)
        {
            throw new NotImplementedException();
        }

        public void GetAll(DataGridView dataView)
        {
            SqlCommand cmd = new SqlCommand("select * from Trip", DatabaseSingleton.GetInstance());
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
