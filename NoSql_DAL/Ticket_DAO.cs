using MongoDB.Bson;
using NoSql_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSql_DAL
{
    public class Ticket_DAO : Base
    {
        private string dbName = "incidents";

		public List<Ticket> DB_Get_All_Tickets()
		{
			List<Ticket> tickets = new List<Ticket>();
			List<BsonDocument> document = GetDatabaseData(dbName);

			foreach (BsonDocument doc in document)
			{
				ObjectId id = (ObjectId)doc[0];
				string subject = (string)doc[1];
				string user = (string)doc[2];
				DateTime dateReported = (DateTime)doc[3];
				string priority = (string)doc[4];
				string status = (string)doc[5];
				string type = (string)doc[6];
				DateTime deadline = (DateTime)doc[7];
				string description = (string)doc[8];

				Ticket ticket = new Ticket(id, subject, user, dateReported, priority, status, type, deadline, description);
				tickets.Add(ticket);
			}
			return tickets;
		}

		public List<Ticket> DB_Get_All_Open_Tickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            List<BsonDocument> document = GetDatabaseData(dbName);

            foreach (BsonDocument doc in document)
            {
                string status = (string)doc[5];
                if (status != "Closed")
                {
                    ObjectId id = (ObjectId)doc[0];
                    string subject = (string)doc[1];
                    string user = (string)doc[2];
                    DateTime dateReported = (DateTime)doc[3];
                    string priority = (string)doc[4];
                    string type = (string)doc[6];
                    DateTime deadline = (DateTime)doc[7];
                    string description = (string)doc[8];

                    Ticket ticket = new Ticket(id, subject, user, dateReported, priority, status, type, deadline, description);
                    tickets.Add(ticket);
                }
            }
            return tickets;
        }

        public Ticket Db_Get_Specific_Ticket(string field, string value, bool isObjectId)
        {
            BsonDocument specificDoc = GetSpecificDocument(dbName, field, value, isObjectId);

            ObjectId id = (ObjectId)specificDoc[0];
            string subject = (string)specificDoc[1];
            string user = (string)specificDoc[2];
            DateTime dateReported = (DateTime)specificDoc[3];
            string priority = (string)specificDoc[4];
            string status = (string)specificDoc[5];
            string type = (string)specificDoc[6];
            DateTime deadline = (DateTime)specificDoc[7];
            string description = (string)specificDoc[8];

            Ticket ticket = new Ticket(id, subject, user, dateReported, priority, status, type, deadline, description);
            return ticket;
        }

		public void Db_Insert_Ticket(Ticket ticket)
        {
            BsonDocument ticketData = new BsonDocument
            {
                {"subject", ticket.Subject},
                {"user", ticket.User},
                {"date", ticket.DateReported},
                {"priority", ticket.Priority},
                {"status", ticket.Status},
                {"type", ticket.Type},
                {"deadline", ticket.Deadline},
                {"description", ticket.Description},
            };

            InsertData(ticketData, dbName);
        }

        public void Db_Delete_Ticket(String selectedTicket)
        {
            ObjectId selectedTicketId = ObjectId.Parse(selectedTicket); // convert to object ID
            DeleteDocument(selectedTicketId, dbName);
        }

        public void Db_Update_Ticket(String selectedTicketId, string fieldName, string fieldValue, bool isDate)
        {
            UpdateDocument(dbName, selectedTicketId, fieldName, fieldValue, isDate);
        }
    }
}
