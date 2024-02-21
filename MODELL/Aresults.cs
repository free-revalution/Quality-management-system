using System;
using System.Collections.Generic;
using System.Text;

namespace MODELL
{
    [Serializable]
   public class Aresults
    {
        public int Id { get; set; }
        public string MATID { get; set; }
        public string Fid { get; set; }
        public string Results { get; set; }
        public DateTime Anadate { get; set; }

        public Aresults(int id, string mATID, string fid, string results, DateTime anadate)
        {
            Id = id;
            MATID = mATID;
            Fid = fid;
            Results = results;
            Anadate = anadate;
        }
    }
}
