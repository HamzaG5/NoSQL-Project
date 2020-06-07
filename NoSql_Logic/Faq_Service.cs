using NoSql_DAL;
using NoSql_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSql_Logic
{
    public class Faq_Service
    {
        Faq_DAO faqCollection = new NoSql_DAL.Faq_DAO();

        public List<Faq> GetAllFaq()
        {
            try
            {
                List<Faq> faqList = faqCollection.DB_Get_All_Faq();
                return faqList;
            }
            catch (Exception e)
            {
                //throw new Exception("could't connect to the database");
                throw e;
            }
        }

        public List<Faq> GetSpecificFaq(string field, string value)
        {
            try
            {
                List<Faq> faqList = faqCollection.Db_Get_Specific_Faq(field, value);
                return faqList;
            }
            catch (Exception e)
            {
                //throw new Exception("could't connect to the database");
                throw e;
            }
        }

        public void InsertFaq(Faq faq)
        {
            try
            {
                faqCollection.Db_Insert_Faq(faq);
            }
            catch (Exception e)
            {
                //throw new Exception("could't connect to the database");
                throw e;
            }
        }
    }
}
