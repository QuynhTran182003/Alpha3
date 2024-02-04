using Alpha3.Data_Tier;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha3.Bussiness_Tier
{
    public class Trip : IBaseClass<Trip>
    {
        private int id;
        private int id_transport;
        private int id_hotel;
        private int id_departCity;
        private int id_destinationCity;
        private DateTime date_depart;
        private DateTime date_return;
        private float price;
        private int capacity;
        public int Id { get => id; set => id = value; }
        public int Id_transport { get => id_transport; set => id_transport = value;}
        public int Id_hotel { get => id_hotel; set => id_hotel = value;}
        public int Id_departCity { get => id_departCity; set => id_departCity = value;}
        public int Id_destinationCity { get => id_destinationCity; set => id_destinationCity = value;}
        public DateTime Date_depart { get => date_depart; set => date_depart = value;}
        public DateTime Date_return { get => date_return; set => date_return = value;}
        public float Price { get => price; set => price = value; }
        public int Capacity { get => capacity; set => capacity = value; }

        public Trip()
        {
        }
        public Trip(int id)
        {
            Id = id;
            Capacity = 0;
        }

        public Trip(int id_transport, int id_hotel, int id_departCity, int id_destinationCity, DateTime date_depart, DateTime date_return, float price, int capa)
        {
            Id_transport = id_transport;
            Id_hotel = id_hotel;
            Id_departCity = id_departCity;
            Id_destinationCity = id_destinationCity;
            if (date_return > date_depart)
            {
                Date_depart = date_depart;
                Date_return = date_return;
            }
            else
            {
                MessageBox.Show("Date_return must be after Date_depart.");
            }
            Price = price;
            Capacity = capa;
        }

        public int GetReservedDB()
        {
            TripDAO tripDAO = new TripDAO();
            return tripDAO.GetReserved(this.id);

        }
        public int GetAvailability()
        {
            int availability = Capacity - GetReservedDB();
            return availability;
        }
        public void AddToDB()
        {
            
            TripDAO tripDAO = new TripDAO();
            tripDAO.Save(this);
            //error handling
        }
        
        public Trip GetTripByIdDB(int id)
        {

            TripDAO tripDAO = new TripDAO();
            Trip trip = tripDAO.GetTripById(id);
            return trip;
            //error handling
        }
        
        public void UpdateDB()
        {
            TripDAO tripDAO = new TripDAO();
            tripDAO.Update(this.id, this);
            //error handling
        }

        public void Delete(int id)
        {
            TripDAO tripDAO = new TripDAO();
            tripDAO.Delete(id);
            //error handling

        }

        public void GetAllDB(DataGridView dataGridView)
        {
            TripDAO tripDAO = new TripDAO();
            tripDAO.GetAll(dataGridView);
            //error handling

        }
    }
}
