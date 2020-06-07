using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

using NoSql_DAL;
using NoSql_Model;

namespace NoSql_Logic
{
	public class Analysis_Service
	{
		Ticket_DAO ticketCollection = new Ticket_DAO();

		public static DateTime Week = DateTime.Today;

		public List<Ticket> GetTickets()
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

		public List<Ticket>[] SortTicketsByDayOfWeek(List<Ticket> tickets, DateTime week)
		{
			//0=Sunday, 1=Monday, 2=Tuesday, 3=Wednesday, 4=Thursday, 5=Friday, 6=Saturday 
			List<Ticket>[] ticketsByDayOfWeek = new List<Ticket>[7];
			for(int i = 0; i < ticketsByDayOfWeek.Length; i++) { ticketsByDayOfWeek[i] = new List<Ticket>(); } // Initialize array.
		

			foreach (Ticket ticket in tickets)
			{
				if (DatesAreInSameWeek(week, ticket.DateReported))
				{
					switch (ticket.DateReported.DayOfWeek)
					{
						case DayOfWeek.Sunday:
							ticketsByDayOfWeek[0].Add(ticket);
							break;
						case DayOfWeek.Monday:
							ticketsByDayOfWeek[1].Add(ticket);
							break;
						case DayOfWeek.Tuesday:
							ticketsByDayOfWeek[2].Add(ticket);
							break;
						case DayOfWeek.Wednesday:
							ticketsByDayOfWeek[3].Add(ticket);
							break;
						case DayOfWeek.Thursday:
							ticketsByDayOfWeek[4].Add(ticket);
							break;
						case DayOfWeek.Friday:
							ticketsByDayOfWeek[5].Add(ticket);
							break;
						case DayOfWeek.Saturday:
							ticketsByDayOfWeek[6].Add(ticket);
							break;
					}
				}
			}

			return ticketsByDayOfWeek;



			// Tool Functions
			bool DatesAreInSameWeek(DateTime date1, DateTime date2) 
			{
				DateTime d1 = StartOfWeek(date1);
				DateTime d2 = StartOfWeek(date2);

				return d1 == d2;
			}
		}



		// Method Tools

		public DateTime StartOfWeek(DateTime dt) // Weeks starts at Monday.
		{
			int diff = (7 + (dt.DayOfWeek - DayOfWeek.Monday)) % 7;
			return dt.AddDays(-diff).Date;
		}

		public DateTime EndOfWeek(DateTime dt) // Weeks ends at Sunday.
		{
			int diff = (7 - (dt.DayOfWeek - DayOfWeek.Sunday)) % 7;
			return dt.AddDays(diff).Date;
		}

		// This presumes that weeks start with Monday.
		public int GetWeekOfYear(DateTime time)
		{
			DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
			if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
			{
				time = time.AddDays(3);
			}

			// Return the week of our adjusted day
			return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
		}
	}
}