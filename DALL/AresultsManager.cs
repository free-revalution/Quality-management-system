using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELL;
using System.Data;

namespace DALL
{
   public class AresultsManager
    {
        public bool AddAresults(Aresults aresults)
        {
            string sql = string.Format("insert into qa_aresults values({0},'{1}','{2}','{3}','{4}')",
               aresults.Id,
               aresults.MATID,
               aresults.Fid,
               aresults.Results,
               aresults.Anadate
                );
            bool isTrue = SQLHelper.ExecuteCUDSQL(sql);
            return isTrue;
        }
        public bool UpdateAresults(Aresults aresults)
        {

            string sql = string.Format("update  qa_aresults set MATID='{1}',Fid='{2}',Results='{3}',Anadate='{4}'where Id={0} ",
                aresults.Id,
               aresults.MATID,
               aresults.Fid,
               aresults.Results,
               aresults.Anadate

                );
            bool isTrue = SQLHelper.ExecuteCUDSQL(sql);
            return isTrue;
        }
        public DataSet GetAresultss()
        {
            return SQLHelper.ExecuteSQLWithFill("select *from qa_aresults", "Aresultst");
        }
        public bool DeleteAresults(int id)
        {
            return SQLHelper.ExecuteCUDSQL(string.Format("delete from qa_aresults where id={0}", id));
        }
    }
}
