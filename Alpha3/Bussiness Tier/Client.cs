using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Email { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }

        public Client() { }
        public Client(string name, string surname, string email)
        {
            Name = name;
            Surname = surname;
            Email = email;
        }

        public Client(string name, string surname, string email, string phone)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
        }
    }
}
