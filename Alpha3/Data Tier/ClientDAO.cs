using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alpha3.Bussiness_Tier;

namespace Alpha3.Data_Tier
{
    public class ClientDAO : IDAO<Client>
    {
        public ClientDAO()
        {

        }

        public void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Client where id = @Id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id", id);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client deleted successfully");
            }
            catch (SqlException)
            {
                MessageBox.Show("Unable to delete: Conflict with some tables in DB, which have Client_id as FK");
            }

            DatabaseSingleton.CloseConnection();

        }

        public void GetById(int id, DataGridView dataView)
        {

            SqlCommand cmd = new SqlCommand("select * from Client where id = @Id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id", id);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataView.DataSource = dt;
            DatabaseSingleton.CloseConnection();
        }

        public void GetAll(DataGridView dataView)
        {
            SqlCommand cmd = new SqlCommand("select * from Client", DatabaseSingleton.GetInstance());
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

        public void Save(Client ele)
        {
            SqlCommand cmd = new SqlCommand("insert into Client values(@Name, @Surname, @Email, @Phone)", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Name", ele.Name);
            cmd.Parameters.AddWithValue("@Surname", ele.Surname);
            cmd.Parameters.AddWithValue("@Email", ele.Email);
            cmd.Parameters.AddWithValue("@Phone", ele.Phone);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("client added");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            DatabaseSingleton.CloseConnection();
        }

        public void Update(int id, Client newEle)
        {
            SqlCommand cmd = new SqlCommand("update Client set Name = @Name, Surname = @Surname, Email = @Email, Phone = @Phone where ID = @Id ", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Name", newEle.Name);
            cmd.Parameters.AddWithValue("@Surname", newEle.Surname);
            cmd.Parameters.AddWithValue("@Email", newEle.Email);
            cmd.Parameters.AddWithValue("@Phone", newEle.Phone);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DatabaseSingleton.CloseConnection();
        }
    }
}
