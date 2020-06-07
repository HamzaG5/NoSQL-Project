using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NoSql_DAL;
using NoSql_Model;

namespace NoSql_Logic
{
	public class Dashboard_Service
	{
		Ticket_DAO ticketCollection = new Ticket_DAO();

		public List<Ticket> GetAllTickets()
		{
			try
			{
				List<Ticket> tickets = ticketCollection.DB_Get_All_Tickets();
				return tickets;
			}
			catch (Exception)
			{
				//throw new Exception("could't connect to the database");
				return null;
			}
		}

		public List<Ticket> GetTicketsByStatus(string status)
		{
			List<Ticket> allTickets = GetAllTickets();

			List<Ticket> ticketsByStatus = new List<Ticket>();

			foreach (Ticket ticket in allTickets) {
				if(ticket.Status.ToLower() == status.ToLower())
				{
					ticketsByStatus.Add(ticket);
				}
			}

			return ticketsByStatus;
		}
	}
}
