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
   public class CtlratsService
    {
        private CtlratsManager ctlratsManager = new CtlratsManager();
        public bool AddCtlrats(Ctlrats ctlrats)
        {
            return ctlratsManager.AddCtlrats(ctlrats);
        }
        public DataSet GetCtlratss()
        {
            return ctlratsManager.GetCtlratss();
        }
        public bool DeleteCtlrats(int id)
        {
            return ctlratsManager.DeleteCtlrats(id);
        }
        public bool UpdateCtlrats(Ctlrats ctlrats)
        {
            return ctlratsManager.UpdateCtlrats(ctlrats);
        }
    }
}
