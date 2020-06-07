using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSql_Model
{
    public class Ticket
    {
        public ObjectId Id { get; private set; }
        public string Subject { get; private set; }
        public string User { get; private set; }
        public DateTime DateReported { get; private set; }
        public string Priority { get; private set; }
        public string Status { get; private set; }
        public string Type { get; private set; }
        public DateTime Deadline { get; private set; }
        public string Description { get; private set; }

        public Ticket(string subject, string user, DateTime dateReported, string priority, string status, string type, DateTime deadline, string description)
        {
            this.Subject = subject;
            this.User = user;
            this.DateReported = dateReported;
            this.Priority = priority;
            this.Status = status;
            this.Type = type;
            this.Deadline = deadline;
            this.Description = description;

        }

        public Ticket(ObjectId id, string subject, string user, DateTime dateReported, string priority, string status, string type, DateTime deadline, string description)
        {
            this.Id = id;
            this.Subject = subject;
            this.User = user;
            this.DateReported = dateReported;
            this.Priority = priority;
            this.Status = status;
            this.Type = type;
            this.Deadline = deadline;
            this.Description = description;
        }
    }
}
