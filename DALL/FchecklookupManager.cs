using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DALL
{
   public class FchecklookupManager
    {
        public DataSet GetFcheckByid(int ID)
        {
            DataSet ds = new DataSet();
            string sql = string.Format("select  ID,FCheckID,MATID,Checktype,Cnums,Unqseason,Corrective,Comments,Fcdate,Approval,Mark from qa_fcheck where ID={0}", ID);
            ds = SQLHelper.ExecuteSQLWithFill(sql, "Fcheck");
            return ds.Copy();
        }
    }
}
