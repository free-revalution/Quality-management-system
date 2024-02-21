using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
using MODELL;
namespace BLLL
{
   public class CalresultService
    {
        private CalresultManager calresultManager = new CalresultManager();
        public bool AddCalresult(Calresult calresult)
        {
            return calresultManager.AddCalresult(calresult);
        }
        public DataSet GetCalresults()
        {
            return calresultManager.GetCalresults();
        }
        public bool DeleteCalresult(int id)
        {
            return calresultManager.DeleteCalresult(id);
        }
        public bool UpdateCalresult(Calresult calresult)
        {
            return calresultManager.UpdateCalresult(calresult);
        }
    }
}
