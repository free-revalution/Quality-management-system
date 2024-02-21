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
    public class AresultsService
    {
        private AresultsManager aresultsManager = new AresultsManager();
        public bool AddAresults(Aresults aresults)
        {
            return aresultsManager.AddAresults(aresults);
        }
        public DataSet GetAresultss()
        {
            return aresultsManager.GetAresultss();
        }
        public bool DeleteAresults(int id)
        {
            return aresultsManager.DeleteAresults(id);
        }
        public DataSet GetAresultss(int id)
        {
            return aresultsManager.GetAresultss();
        }
        public bool UpdateAresults(Aresults aresults)
        {
            return aresultsManager.UpdateAresults(aresults);
        }
    }
}
