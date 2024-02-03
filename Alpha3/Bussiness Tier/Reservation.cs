using Alpha3.Data_Tier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha3.Bussiness_Tier
{
    public class Reservation : IBaseClass<Reservation>
    {
        private int id;
        private int id_client;
        private int id_trip;
        private int number_pple;
        private DateTime date_reservation;
        private bool status = false;
        public int Id { get => id; set => id = value; }

        public int Id_client { get => id_client; set => id_client = value; }
        public int Number_pple { get => number_pple; set => number_pple = value; }

        public int Id_Trip { get => id_trip; set => id_trip = value; }
        public DateTime DateReservation { get => date_reservation; set => date_reservation = value; }

        public bool Status { get => status; set => status = value; }

        public Reservation(){}
        public Reservation(int id)
        {
            Id = id;
        }

        public Reservation(int id_client, int id_trip, int number_pple, DateTime date_reservation, bool status)
        {
            Id_client = id_client;
            Number_pple = number_pple;
            Id_Trip = id_trip;
            DateReservation = date_reservation;
            Status = status;
        }

        public Reservation(int id_client, int id_trip, int number_pple, DateTime date_reservation)
        {
            Id_client = id_client;
            Number_pple = number_pple;
            Id_Trip = id_trip;
            DateReservation = date_reservation;
        }

        public Reservation(int id_client, int id_trip, int number_pple)
        {
            Id_client = id_client;
            Number_pple = number_pple;
            Id_Trip = id_trip;
            DateReservation = DateTime.Now.Date;
        }

        private bool checkCapacityTrip(int numPple)
        {
            Trip trip = new TripDAO().GetTripById(this.Id_Trip);
            if(trip.GetAvailability() >= numPple)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AddToDB()
        {
            if (checkCapacityTrip(this.Number_pple))
            {
                ReservationDAO reservationDAO = new ReservationDAO();
                reservationDAO.Save(this);
            }
            else
            {
                MessageBox.Show("Overlimit");
            }
            //error handling
        }

        public void UpdateDB(int id)
        {
            ReservationDAO reservationDAO = new ReservationDAO();

            reservationDAO.Update(id, this);
            //error handling
        }

        public void Delete(int id)
        {
            ReservationDAO reservationDAO = new ReservationDAO();
            reservationDAO.Delete(id);
            //error handling

        }

        public void GetAllDB(DataGridView dataGridView)
        {
            ReservationDAO reservationDAO = new ReservationDAO();
            reservationDAO.GetAll(dataGridView);
            //error handling

        }

        public void GetReservationById(int id)
        {
            ReservationDAO reservationDAO = new ReservationDAO();
            reservationDAO.GetReservationById(id);
            //error handling

        }

        public float GetReport()
        {
            ReservationDAO reservationDAO = new ReservationDAO();
            return reservationDAO.GetReportDB();
            //error handling

        }

        public float GetPaid()
        {
            ReservationDAO reservationDAO = new ReservationDAO();
            return reservationDAO.GetPaidDB();
            //error handling

        }

        public float GetUnpaid()
        {
            ReservationDAO reservationDAO = new ReservationDAO();
            return reservationDAO.GetUnpaidDB();
            //error handling

        }
    }
}
