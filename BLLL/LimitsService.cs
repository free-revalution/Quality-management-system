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
   public class LimitsService
    {
        private LimitsManager limitsManager = new LimitsManager();
        public bool AddLimits(Limits limits)
        {
            return limitsManager.AddLimits(limits);
        }
        public DataSet GetLimitss()
        {
            return limitsManager.GetLimitss();
        }
        public bool DeleteLimits(int id)
        {
            return limitsManager.DeleteLimits(id);
        }
        public bool UpdateLimits(Limits limits)
        {
            return limitsManager.UpdateLimits(limits);
        }
    }
}
