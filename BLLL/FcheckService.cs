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
   public class FcheckService
    {
        private FcheckManager fcheckManager = new FcheckManager();
        public bool AddFcheck(Fcheck fcheck)
        {
            return fcheckManager.AddFcheck(fcheck);
        }
        public DataSet GetFchecks()
        {
            return fcheckManager.GetFchecks();
        }
        public bool DeleteFcheck(int id)
        {
            return fcheckManager.DeleteFcheck(id);
        }
        public bool UpdateFcheck(Fcheck fcheck)
        {
            return fcheckManager.UpdateFcheck(fcheck);
        }
    }
}
