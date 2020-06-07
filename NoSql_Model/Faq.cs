using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSql_Model
{
    public class Faq
    {
        public string Question { get; private set; }
        public string Answer { get; private set; }
        public string Type { get; private set; }

        public Faq(string question, string answer, string type)
        {
            this.Question = question;
            this.Answer = answer;
            this.Type = type;
        }
    }
}
