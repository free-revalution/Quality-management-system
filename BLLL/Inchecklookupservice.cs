using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
using System.Data;
namespace BLLL
{
    public class Inchecklookupservice
    {
        private Inchecklookupmanager inchecklookupmanager;
        public Inchecklookupservice() {
            inchecklookupmanager = new Inchecklookupmanager();
        }
        public DataSet GetIncheckByid(int ID) {
            return inchecklookupmanager.GetIncheckByid(ID);
        }
    }
}
