using Alpha3.Data_Tier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha3.Bussiness_Tier
{
    public class City : IBaseClass<City>
    {
        private int id;
        private string name;
        private string abbreviation;

        // Default constructor
        public City()
        {
        }

        // Constructor with all arguments
        public City(int id, string name, string abbreviation)
        {
            this.id = id;
            this.name = name;
            this.abbreviation = abbreviation;
        }

        // Getter and setter for Id
        public int Id
        {
            get => id;
            set => id = value;
        }

        // Getter and setter for Name
        public string Name
        {
            get => name;
            set => name = value;
        }

        // Getter and setter for Abbreviation
        public string Abbreviation
        {
            get => abbreviation;
            set => abbreviation = value;
        }

        public void AddToDB()
        {
            try
            {
                CityDAO cityDAO = new CityDAO();
                cityDAO.Save(this);
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
                CityDAO cityDAO = new CityDAO();
                cityDAO.Update(id, this);
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
                CityDAO cityDAO = new CityDAO();
                cityDAO.Delete(id);
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
                CityDAO cityDAO = new CityDAO();
                cityDAO.GetAll(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in GetAllDB: {ex.Message}");
            }
        }
    }
}
