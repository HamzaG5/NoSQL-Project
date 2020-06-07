using MongoDB.Bson;
using NoSql_DAL;
using NoSql_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSql_Logic
{
    public class User_Service
    {
        User_DAO user_db = new NoSql_DAL.User_DAO();
        #region GetUser 
        public List<User> GetUsers()
        {
            try
            {
                List<User> users = user_db.DB_Get_All_Users();
                return users;
            }
            catch (Exception e)
            {
                //throw new Exception("could't connect to the database");
                throw e;
            }
        }
        #endregion
        public void InserUser(BsonDocument userDocument)
        {
            try
            {
                user_db.InsertData(userDocument, "users");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public User GetUserByID(int id)
        {
            try
            {
                User user = user_db.GetUserById(id);
                return user;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public String GetLastUserID()
        {
            try
            {
                User user = user_db.GetLastUser();
                return user.Id.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public User GetLastUser()
        {
            try
            {
                User user = user_db.GetLastUser();
                return user;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #region Checkuser-check username and password for login brandon

        public User CheckUser(string username, string password)
        {
            try
            {
                User user = user_db.DB_Check_User(username,password);
                return user;
            }
            catch (Exception e)
            {
                //throw new Exception("could't connect to the database");
                throw e;
            }
        }

        public void UpdateUserById(BsonDocument replacement, string id, string field, string value)
        {
            try
            {
                user_db.UpdateUserById(replacement, id, field, value);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        #endregion
        public void DeleteUser(string id)
        {
            try
            {
                user_db.DeleteUser(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
