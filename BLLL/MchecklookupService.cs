using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
using System.Data;
namespace BLLL
{
   public class MchecklookupService
    {
        private MchecklookupManager mchecklookupManager;
        public MchecklookupService()
        {
            mchecklookupManager = new MchecklookupManager();
        }
        public DataSet GetMcheckByid(int ID)
        {
            return mchecklookupManager.GetMcheckByid(ID);
        }
    }
}
