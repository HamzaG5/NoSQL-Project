using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSql_Model
{
    public class User
    {
        public int Id { get; private set; }
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Type { get; private set; }
        public string Ticket { get; private set; }

        public User()
        {

        }
        public User(int id, string firstName, string lastName, string UserName, string email, string password, string type, string ticket)
        {
            this.Id = id;
            this.Firstname = firstName;
            this.Lastname = lastName;
            this.UserName = UserName;
            this.Email = email;
            this.Password = password;
            this.Type = type;
            this.Ticket = ticket;
        }

        public override string ToString()
        {
            string msg = $"ID={Id} \n Firstname={Firstname}\n Lastname={Lastname}\n Username={UserName}\n Email={Email}\n Password={Password}\n Type={Type}\n Ticket={Ticket}\n";

            return msg;
        }
    }
}
