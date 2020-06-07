using NoSql_DAL;
using NoSql_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSql_Logic
{
    public class Ticket_Service
    {
        Ticket_DAO ticketCollection = new Ticket_DAO();

        public List<Ticket> GetTickets()
        {
            try
            {
                List<Ticket> tickets = ticketCollection.DB_Get_All_Open_Tickets();
                return tickets;
            }
            catch (Exception)
            {
                //throw new Exception("could't connect to the database");
                return null;
            }
        }

        public Ticket GetTicket(string field, string value, bool isObjectId)
        {
            try
            {
                Ticket ticket = ticketCollection.Db_Get_Specific_Ticket(field, value, isObjectId);
                return ticket;
            }
            catch (Exception )
            {
                //throw new Exception("could't connect to the database");
                return null;
            }
        }

		public List<Ticket> GetTicketsByWeek(DateTime week)
		{
			try
			{
				List<Ticket> tickets = ticketCollection.DB_Get_All_Open_Tickets();
				return tickets;
			}
			catch (Exception)
			{
				//throw new Exception("could't connect to the database");
				return null;
			}
		}


		public void InsertTicket(Ticket ticket)
        {
            try
            {                
                ticketCollection.Db_Insert_Ticket(ticket);
            }
            catch (Exception e)
            {
                //throw new Exception("could't connect to the database");
                throw e;
            }
        }

        public void DeleteTicket(String selectedTicket)
        {
            try
            {
                ticketCollection.Db_Delete_Ticket(selectedTicket);
            }
            catch (Exception e)
            {
                //throw new Exception("could't connect to the database");
                throw e;
            }
        }

        public void UpdateTicket(String selectedTicketId, string fieldName, string fieldValue, bool isDate)
        {
            try
            {
                ticketCollection.Db_Update_Ticket(selectedTicketId, fieldName, fieldValue, isDate);
            }
            catch (Exception e)
            {
                //throw new Exception("could't connect to the database");
                throw e;
            }
        }
	}
}
