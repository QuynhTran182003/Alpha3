using Alpha3.Data_Tier;
using Alpha3.Presentation_Tier;
using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alpha3.Bussiness_Tier
{
    public class Client : IBaseClass<Client>
    {
        private int id;
        private string name;
        private string surname;
        private string email;
        private string phone;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }

        public Client() { }
        public Client(int id)
        {
            Id = id;
        }
        public Client(string name, string surname, string email)
        {
            try
            {
                if (name == null || surname == null || email == null)
                {
                    MessageBox.Show("Field Email, Name and Surname must be filled in.");
                }
                else
                {
                    Name = name;
                    Surname = surname;
                    Email = email;
                }
            }
            catch
            {
                throw;
            }
            
           
        }
        public Client(string name, string surname, string email, string phone)
        {
            try
            {
                if (name == "" || surname == "" || email == "")
                {
                    MessageBox.Show("Constructor: Field Email, Name and Surname must be filled in.");
                }
                else
                {
                    Name = name;
                    Surname = surname;
                    Email = email;
                    Phone = phone;
                }
            }
            catch {
                throw;
            }
        }
    
        public void AddToDB()
        {
            ClientDAO clientDAO = new ClientDAO();
            clientDAO.Save(this);
            //error handling
        }

        public void UpdateDB(int id)
        {
            ClientDAO clientDAO = new ClientDAO();
            clientDAO.Update(id, this);
            //error handling
        }

        public void Delete(int id)
        {
            ClientDAO clientDAO = new ClientDAO();
            clientDAO.Delete(id);
            //error handling

        }

        public void GetAllDB(DataGridView dataGridView)
        {
            ClientDAO clientDAO = new ClientDAO();
            clientDAO.GetAll(dataGridView);
            //error handling

        }
    }
}
