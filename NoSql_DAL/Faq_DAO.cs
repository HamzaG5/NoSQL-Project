using MongoDB.Bson;
using NoSql_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSql_DAL
{
    public class Faq_DAO : Base
    {
        private string dbName = "faq";

        public List<Faq> DB_Get_All_Faq()
        {
            List<Faq> faqList = new List<Faq>();
            List<BsonDocument> documents = new List<BsonDocument>();

            string dbName = "faq";
            documents = GetDatabaseData(dbName);

            foreach (BsonDocument doc in documents)
            {
                string question = (string)doc[1];
                string answer = (string)doc[2];
                string type = (string)doc[3];

                Faq faq = new Faq(question, answer, type);
                faqList.Add(faq);
            }
            return faqList;
        }

        public List<Faq> Db_Get_Specific_Faq(string field, string value)
        {
            List<Faq> specificFaqList = new List<Faq>();
            List<BsonDocument> specificDocuments = new List<BsonDocument>();

            specificDocuments = GetSpecificDocumentList(dbName, field, value);

            foreach (BsonDocument doc in specificDocuments)
            {
                string question = (string)doc[1];
                string answer = (string)doc[2];
                string type = (string)doc[3];

                Faq faq = new Faq(question, answer, type);
                specificFaqList.Add(faq);
            }
            return specificFaqList;
        }

        public void Db_Insert_Faq(Faq faq)
        {
            BsonDocument faqData = new BsonDocument
            {
                {"question", faq.Question},
                {"answer", faq.Answer},
                {"type", faq.Type},
            };

            InsertData(faqData, dbName);
        }
    }
}
