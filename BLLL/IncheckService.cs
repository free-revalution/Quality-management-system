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
   public class IncheckService
    {
        private IncheckManager incheckManager = new IncheckManager();
        public bool AddIncheck(Incheck incheck)
        {
            return incheckManager.AddIncheck(incheck);
        }
        public DataSet GetInchecks()
        {
            return incheckManager.GetInchecks();
        }
        public bool DeleteIncheck(int id)
        {
            return incheckManager.DeleteIncheck(id);
        }
        public bool UpdateIncheck(Incheck incheck)
        {
            return incheckManager.UpdateIncheck(incheck);
        }
    }
}
