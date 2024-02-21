using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELL;
using System.Data;
namespace DALL
{
   public class FcheckManager
    {
        public bool AddFcheck(Fcheck fcheck)
        {
            string sql = string.Format("insert into qa_fcheck values({0},'{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}','{9}','{10}')",
                 fcheck.ID,
                 fcheck.FCheckID,
                 fcheck.MATID,
                 fcheck.Checktype,
                 fcheck.Cnums,
                 fcheck.Unqseason,
                 fcheck.Corrective,
                 fcheck.Comments,
                 fcheck.Fcdate,
                 fcheck.Approval,
                 fcheck.Mark
                );
            bool isTrue = SQLHelper.ExecuteCUDSQL(sql);
            return isTrue;
        }
        public bool UpdateFcheck(Fcheck fcheck)
        {

            string sql = string.Format("update  qa_fcheck set FCheckID='{1}',MATID='{2}',Checktype='{3}',Cnums={4},Unqseason='{5}',Corrective='{6}',Comments='{7}',Fcdate='{8}',Approval='{9}',Mark='{10}'where ID={0} ",
                fcheck.ID,
                 fcheck.FCheckID,
                 fcheck.MATID,
                 fcheck.Checktype,
                 fcheck.Cnums,
                 fcheck.Unqseason,
                 fcheck.Corrective,
                 fcheck.Comments,
                 fcheck.Fcdate,
                 fcheck.Approval,
                 fcheck.Mark

                );
            bool isTrue = SQLHelper.ExecuteCUDSQL(sql);
            return isTrue;
        }
        public DataSet GetFchecks()
        {
            return SQLHelper.ExecuteSQLWithFill("select *from qa_fcheck", "Fcheck");
        }
        public bool DeleteFcheck(int id)
        {
            return SQLHelper.ExecuteCUDSQL(string.Format("delete from qa_fcheck where id={0}", id));
        }
    }
}
