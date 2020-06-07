using MongoDB.Bson;
using NoSql_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSql_DAL
{
    public class User_DAO : Base 
    {
        private string dbName = "users";
        public List<User> DB_Get_All_Users()
        {
            List<User> users = new List<User>();
            List<BsonDocument> document = new List<BsonDocument>();            
            document = GetDatabaseData(dbName);
            foreach (BsonDocument doc in document)
            {
                int id = int.Parse(doc[0].ToString());
                string firstName = (string)doc[1];
                string lastName = (string)doc[2];
                string email = (string)doc[3];
                string userName = (string)doc[4];
                string password = (string)doc[5];
                string type = (string)doc[6];
                string ticket = (string)doc[7]; //there is an issue here i need to add an objcetId
                User user = new User(id, firstName, lastName, userName, email, password, type, ticket);
                users.Add(user);
            }
            return users;
        }

        public User DB_Check_User(string usersName, string userPassword)
        {
           BsonDocument userDocument = GetSpecificDocument(dbName, "userName", usersName, false);    //grabbing one specifc record where username = passed argument        


            string password = (string)userDocument[5];
            if (password==userPassword)
            {
                int id = int.Parse(userDocument[0].ToString());
                string firstName = (string)userDocument[1];
                string lastName = (string)userDocument[2];
                string email = (string)userDocument[3];
                string userName = (string)userDocument[4];
                string type = (string)userDocument[6];
                string ticket = (string)userDocument[7];
                User user = new User(id, firstName, lastName, userName, email, password, type, ticket);
                return user;
            }                           
                                    
                return null;
        }
        public User GetLastUser()
        {
            List<BsonDocument> doc = new List<BsonDocument>();
            string dbName = "users";
            doc = GetDatabaseData(dbName);
            int lastDocument = doc.Count() - 1;
            int id = (int)doc[lastDocument][0];
            string firstName = (string)doc[lastDocument][1];
            string email = (string)doc[lastDocument][3];
            string userName = (string)doc[lastDocument][4];
            string lastName = (string)doc[lastDocument][2];
            string ticket = (string)doc[lastDocument][7];
            string password = (string)doc[lastDocument][5];
            string type = (string)doc[lastDocument][6];
            User user = new User(id, firstName, lastName, userName, email, password, type, ticket);
            return user;
        }
        public User GetUserById(int id)
        {
            User userEmpty = new User();
            List<BsonDocument> doc = GetDatabaseData("users");
            foreach (var item in doc)
            {
                if ((int)item[0] == id)
                {
                    string firstName = (string)item[1];
                    string lastName = (string)item[2];
                    string email = (string)item[3];
                    string userName = (string)item[4];
                    string password = (string)item[5];
                    string type = (string)item[6];
                    string ticket = (string)item[7];
                    User user = new User(id, firstName, lastName, userName, email, password, type, ticket);
                    return user;
                }                
            }
            return userEmpty;
        }
        public void UpdateUserById(BsonDocument document, string id, string field, string value)
        {
            UpdateUserData("users", document, id, field, value);
        }
        public void DeleteUser(string id)
        {
            DeleteUserByID("users", id);
        }
    }
}
