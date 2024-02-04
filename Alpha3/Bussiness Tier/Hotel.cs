using Alpha3.Data_Tier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha3.Bussiness_Tier
{
    public class Hotel: IBaseClass<Hotel>
    {
        private int id;
        private string name;
        private string street;
        private int number1;
        private int number2;
        private string postcode;
        private int quality;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Street { get => street; set => street = value; }
        public int Number1 { get => number1; set => number1 = value; }
        public int Number2 { get => number2; set => number2 = value; }
        public string Postcode { get => postcode; set => postcode = value; }
        public int Quality { get => quality; set => quality = value; }

        public Hotel()
        {
        }
        public Hotel(int id)
        {
            Id = id;
        }

        public Hotel(string name, string street, int number1, int number2, string postcode, int quality)
        {
            Name = name;
            Street = street;
            Number1 = number1;
            Number2 = number2;
            Postcode = postcode;
            Quality = quality;
        }

        public void AddToDB()
        {
            try
            {
                HotelDAO hotelDAO = new HotelDAO();
                hotelDAO.Save(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in AddToDB: {ex.Message}");
            }
        }

        public void UpdateDB(int id)
        {
            try
            {
                HotelDAO hotelDAO = new HotelDAO();
                hotelDAO.Update(id, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in UpdateDB: {ex.Message}");
            }
        }

        public void Delete(int id)
        {
            try
            {
                HotelDAO hotelDAO = new HotelDAO();
                hotelDAO.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Delete: {ex.Message}");
            }
        }

        public void GetAllDB(DataGridView dataGridView)
        {
            try
            {
                HotelDAO hotelDAO = new HotelDAO();
                hotelDAO.GetAll(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in GetAllDB: {ex.Message}");
            }
        }

    }
}
