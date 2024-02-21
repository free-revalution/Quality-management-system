using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
using System.Data;
namespace BLLL
{
   public class FchecklookupService
    {
        private FchecklookupManager fchecklookupManager;
        public FchecklookupService()
        {
            fchecklookupManager = new FchecklookupManager();
        }
        public DataSet GetFcheckByid(int ID)
        {
            return fchecklookupManager.GetFcheckByid(ID);
        }
    }
}
