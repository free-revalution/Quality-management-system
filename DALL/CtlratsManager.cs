using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELL;
using System.Data;

namespace DALL
{
    public class CtlratsManager
    { public bool AddCtlrats(Ctlrats ctlrats)
        {
            string sql = string.Format("insert into qa_ctlrats values({0},{1},'{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                 ctlrats.Id,
                 ctlrats.N,
                 ctlrats.A2,
                 ctlrats.A3,
                 ctlrats.A4,
                 ctlrats.D3,
                 ctlrats.D4,
                 ctlrats.Dd2,
                 ctlrats.Dd3,
                 ctlrats.B3,
                 ctlrats.B4
                );
            bool isTrue = SQLHelper.ExecuteCUDSQL(sql);
            return isTrue;
        }
        public bool UpdateCtlrats(Ctlrats ctlrats)
        {

            string sql = string.Format("update  qa_ctlrats set N={1},A2='{2}',A3='{3}',A4='{4}',D3='{5}',D4='{6}',Dd2='{7}',Dd3='{8}',B3='{9}',B4='{10}'where Id={0} ",
                ctlrats.Id,
                 ctlrats.N,
                 ctlrats.A2,
                 ctlrats.A3,
                 ctlrats.A4,
                 ctlrats.D3,
                 ctlrats.D4,
                 ctlrats.Dd2,
                 ctlrats.Dd3,
                 ctlrats.B3,
                 ctlrats.B4

                );
            bool isTrue = SQLHelper.ExecuteCUDSQL(sql);
            return isTrue;
        }
        public DataSet GetCtlratss()
        {
            return SQLHelper.ExecuteSQLWithFill("select *from qa_ctlrats", "Ctlrats");
        }
        public bool DeleteCtlrats(int id)
        {
            return SQLHelper.ExecuteCUDSQL(string.Format("delete from qa_ctlrats where id={0}", id));
        }
    }
}
