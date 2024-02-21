using System;
using System.Collections.Generic;
using System.Text;

namespace MODELL
{
    [Serializable]
    public class Calresult
    {
        public int Id { get; set; }
        public string Fid { get; set; }
        public int Samid { get; set; }
        public decimal Samavg { get; set; }
        public decimal Samexam { get; set; }
        public decimal Maxv { get; set; }
        public decimal Minv { get; set; }

        public Calresult(int id, string fid, int samid, decimal samavg, decimal samexam, decimal maxv, decimal minv)
        {
            Id = id;
            Fid = fid;
            Samid = samid;
            Samavg = samavg;
            Samexam = samexam;
            Maxv = maxv;
            Minv = minv;
        }
    }
}
