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
   public class McheckService
    {
        private McheckManager mcheckManager = new McheckManager();
        public bool AddMcheck(Mcheck mcheck)
        {
            return mcheckManager.AddMcheck(mcheck);
        }
        public DataSet GetMchecks()
        {
            return mcheckManager.GetMchecks();
        }
        public bool DeleteMcheck(int id)
        {
            return mcheckManager.DeleteMcheck(id);
        }
        public bool UpdateMcheck(Mcheck mcheck)
        {
            return mcheckManager.UpdateMcheck(mcheck);
        }
    }
}
