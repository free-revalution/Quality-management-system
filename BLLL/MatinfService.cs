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
   public class MatinfService
    {
        private MatinfManager matinfManager = new MatinfManager();
        public bool AddMatinf(Matinf matinf)
        {
            return matinfManager.AddMatinf(matinf);
        }
        public DataSet GetMatinfs()
        {
            return matinfManager.GetMatinfs();
        }
        public bool DeleteMatinf(int id)
        {
            return matinfManager.DeleteMatinf(id);
        }
        public bool UpdateMatinf(Matinf matinf)
        {
            return matinfManager.UpdateMatinf(matinf);
        }
    }
}
