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
    public class FchdetailsService
    {
        private FchdetailsManager fchdetailsManager = new FchdetailsManager();
        public bool AddFchdetails(Fchdetails fchdetails)
        {
            return fchdetailsManager.AddFchdetails(fchdetails);
        }
        public DataSet GetFchdetailss()
        {
            return fchdetailsManager.GetFchdetailss();
        }
        public bool DeleteFchdetails(int id)
        {
            return fchdetailsManager.DeleteFchdetails(id);
        }
        public bool UpdateFchdetails(Fchdetails fchdetails)
        {
            return fchdetailsManager.UpdateFchdetails(fchdetails);
        }
    }
}
