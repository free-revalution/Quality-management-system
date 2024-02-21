using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace DALL
{
   public class Inchecklookupmanager
    {
        public DataSet GetIncheckByid(int ID) {
            DataSet ds = new DataSet();
            string sql = string.Format("select ID,InCheckID,MATID, Cmethod,Delivers,Unqualifies,Qualifies,Cresults,Handles,Producer,Cdate,Cdepart from qa_incheck where ID={0}", ID);
            ds = SQLHelper.ExecuteSQLWithFill(sql, "Incheck");
            return ds.Copy();
        }
    }
}
