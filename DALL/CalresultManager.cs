using MODELL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
   public class CalresultManager
    {
        public bool AddCalresult(Calresult calresult)
        {
            string sql = string.Format("insert into qa_calresult values({0},'{1}',{2},'{3}','{4}','{5}','{6}')",
                  calresult.Id,
                  calresult.Fid,
                  calresult.Samid,
                  calresult.Samavg,
                  calresult.Samexam,
                  calresult.Maxv,
                  calresult.Minv
                );
            bool isTrue = SQLHelper.ExecuteCUDSQL(sql);
            return isTrue;
        }
        public bool UpdateCalresult(Calresult calresult)
        {

            string sql = string.Format("update  qa_calresult set Fid='{1}',Samid={2},Samavg='{3}',Samexam='{4}',Maxv='{5}',Minv='{6}'where Id={0} ",
                   calresult.Id,
                  calresult.Fid,
                  calresult.Samid,
                  calresult.Samavg,
                  calresult.Samexam,
                  calresult.Maxv,
                  calresult.Minv
                );
            bool isTrue = SQLHelper.ExecuteCUDSQL(sql);
            return isTrue;
        }
        public DataSet GetCalresults()
        {
            return SQLHelper.ExecuteSQLWithFill("select *from qa_calresult", "Calresult");
        }
        public bool DeleteCalresult(int id)
        {
            return SQLHelper.ExecuteCUDSQL(string.Format("delete from qa_calresult where id={0}", id));
        }
    }
}
