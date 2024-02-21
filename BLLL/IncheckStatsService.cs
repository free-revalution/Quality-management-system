using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALL;
using System.Data;
using MODELL;

namespace BLLL
{
   public class IncheckStatsService
    {
        private IncheckStatsmanager estats;

        public IncheckStatsService()
        {
            estats = new IncheckStatsmanager();
        }
        public DataSet StatsNumsOfEqReports()
        {
            return estats.StatsNumsOfEqReports();
        }
        public List<StatsValue> GetStatsReportsValue()
        {
            return estats.GetStatsReportsValue();
        }
    }
}
