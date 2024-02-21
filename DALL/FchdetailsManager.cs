using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELL;
using System.Data;
namespace DALL
{
    public class FchdetailsManager
    {
        public bool AddFchdetails(Fchdetails fchdetails)
        {
            string sql = string.Format("insert into qa_fchdetails values({0},'{1}','{2}',{3},{4},'{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                fchdetails.ID,
                fchdetails.FCheckID,
                fchdetails.CheckItem,
                fchdetails.Samtnums,
                fchdetails.Unqnums,
                fchdetails.CheckEquip,
                fchdetails.Cstd,
                fchdetails.Cresults,
                fchdetails.Unqseason,
                fchdetails.Ccdate,
                fchdetails.Checker,
                fchdetails.Mark
                );
            bool isTrue = SQLHelper.ExecuteCUDSQL(sql);
            return isTrue;
        }
        public bool UpdateFchdetails(Fchdetails fchdetails)
        {

            string sql = string.Format("update  qa_fchdetails set FCheckID='{1}',CheckItem='{2}',Samtnums={3},Unqnums={4},CheckEquip='{5}',Cstd='{6}',Cresults='{7}',Unqseason='{8}',Ccdate='{9}',Checker='{10}',Mark='{11}'where ID={0} ",
                fchdetails.ID,
                fchdetails.FCheckID,
                fchdetails.CheckItem,
                fchdetails.Samtnums,
                fchdetails.Unqnums,
                fchdetails.CheckEquip,
                fchdetails.Cstd,
                fchdetails.Cresults,
                fchdetails.Unqseason,
                fchdetails.Ccdate,
                fchdetails.Checker,
                fchdetails.Mark

                );
            bool isTrue = SQLHelper.ExecuteCUDSQL(sql);
            return isTrue;
        }
        public DataSet GetFchdetailss()
        {
            return SQLHelper.ExecuteSQLWithFill("select *from qa_fchdetails", "Fchdetails");
        }
        public bool DeleteFchdetails(int id)
        {
            return SQLHelper.ExecuteCUDSQL(string.Format("delete from qa_fchdetails where id={0}", id));
        }
    }
}
