using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
using MODELL;
using System.Data;
namespace BLLL
{
   public class MresultsService
    {
        private MresultsManager mresultsManager = new MresultsManager();
        public bool AddMresults(Mresults mresults)
        {
            return mresultsManager.AddMresults(mresults);
        }
        public DataSet GetMresultss()
        {
            return mresultsManager.GetMresultss();
        }
        public bool DeleteMresults(int id)
        {
            return mresultsManager.DeleteMresults(id);
        }
        public bool UpdateMresults(Mresults mresults)
        {
            return mresultsManager.UpdateMresults(mresults);
        }
    }
}
