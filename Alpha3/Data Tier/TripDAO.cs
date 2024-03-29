﻿using Alpha3.Bussiness_Tier;
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
            SqlCommand cmd = new SqlCommand("delete from Trip where id = @Id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id", id);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trip deleted successfully");
            }
            catch (SqlException)
            {
                MessageBox.Show("Unable to delete the trip which has been reserved by client. You must cancel their reservation first.");
            }

            DatabaseSingleton.CloseConnection();
        }

        public Trip GetTripById(int id)
        {
            SqlCommand cmd = new SqlCommand("select * from Trip where id = @Id", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id", id);
            Trip tr = new Trip();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {

                    tr.Id = (int)reader["ID"];
                    tr.Id_transport = (int)reader["Id_Transport"];
                    tr.Id_hotel = (int)reader["Id_hotel"];
                    tr.Id_departCity = (int)reader["Id_departCity"];
                    tr.Id_destinationCity = (int)reader["Id_destinationCity"];
                    tr.Date_depart = (DateTime)reader["Date_depart"];
                    tr.Date_return = (DateTime)reader["Date_return"];
                    tr.Price = (float)((decimal) reader["Price"]);
                    tr.Capacity = reader["Capacity"] == null? (int)reader["Capacity"]: 0;
                }
                
            }
            DatabaseSingleton.CloseConnection();
            return tr;
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();

        }

        public void Save(Trip ele)
        {
            SqlCommand cmd = new SqlCommand("" +
                "INSERT INTO Trip (Id_transport, Id_hotel, Id_departCity, Id_destinationCity, Date_depart, Date_return, Price, Capacity) VALUES (@Id_Trans, @Id_Hotel, @Id_Depart, @Id_Destination, @Date_depart, @Date_return, @Price, @Capacity);", 
                DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id_Trans", ele.Id_transport);
            cmd.Parameters.AddWithValue("@Id_Hotel", ele.Id_hotel);
            cmd.Parameters.AddWithValue("@Id_Depart", ele.Id_departCity);
            cmd.Parameters.AddWithValue("@Id_Destination", ele.Id_destinationCity);
            cmd.Parameters.AddWithValue("@Date_depart", ele.Date_depart);
            cmd.Parameters.AddWithValue("@Date_return", ele.Date_return);
            cmd.Parameters.AddWithValue("@Price", ele.Price);
            cmd.Parameters.AddWithValue("@Capacity", ele.Capacity);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trip added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DatabaseSingleton.CloseConnection();
        }

        public void Update(int id, Trip newEle)
        {
            SqlCommand cmd = new SqlCommand("update Trip set Price = @Price, Capacity = @Capacity where ID = @Id ", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@Price", newEle.Price);
            cmd.Parameters.AddWithValue("@Capacity", newEle.Capacity);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Trip updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DatabaseSingleton.CloseConnection();
        }

        public void GetAll(DataGridView dataView)
        {
            SqlCommand cmd = new SqlCommand("select * from TripView", DatabaseSingleton.GetInstance());
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

        public int GetReserved(int id_trip)
        {
            SqlCommand cmd = new SqlCommand("select sum(Number_pple) as 'reserved' from Reservation inner join trip on Reservation.Id_trip = trip.ID group by Reservation.Id_trip having reservation.Id_trip = @Id ", DatabaseSingleton.GetInstance());
            cmd.Parameters.AddWithValue("@Id", id_trip);
            int numberReserved = 0;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    numberReserved = (int)reader["reserved"];
                }
            }
            DatabaseSingleton.CloseConnection();

            return numberReserved;
        }
        
        public void GetReservedAll(DataGridView dataGridView)
        {
            SqlCommand cmd = new SqlCommand("select Reservation.Id_trip, sum(Number_pple) as 'Reserved', (trip.capacity - sum(Number_pple)) as 'Available', departurecity.Name as 'Departure', destinationcity.Name as 'Destination' from Reservation " +
                                            "inner join trip on Reservation.Id_trip = trip.ID " +
                                            "inner join city as departurecity on trip.Id_departCity = departurecity.ID " +
                                            "inner join city as destinationcity on trip.Id_destinationCity = destinationcity.ID " +
                                            "group by Reservation.Id_trip, departurecity.Name, destinationcity.Name, trip.capacity " +
                                            "order by sum(Number_pple)", 
                                             DatabaseSingleton.GetInstance());
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
            dataGridView.DataSource = dt;

            DatabaseSingleton.CloseConnection();
        }
    }
}
