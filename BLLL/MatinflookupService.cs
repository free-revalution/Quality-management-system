using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DALL;
namespace BLLL
{
   public class MatinflookupService
    {
        private MatinflookupManager matinflookupManager;

        public MatinflookupService()
        {
            matinflookupManager = new MatinflookupManager();
        }

        public DataSet GetMatinfByPy(string py)
        {
            return matinflookupManager.GetMatinfByPy(py);
        }
    }
}
