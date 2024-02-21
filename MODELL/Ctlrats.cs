using System;
using System.Collections.Generic;
using System.Text;

namespace MODELL
{
    [Serializable]
    public class Ctlrats
    {
        public int  Id { get; set; }
        public int N { get; set; }
        public decimal A2 { get; set; }
        public decimal A3 { get; set; }
        public decimal A4 { get; set; }
        public decimal D3 { get; set; }
        public decimal D4 { get; set; }
        public decimal Dd2 { get; set; }
        public decimal Dd3 { get; set; }
        public decimal B3 { get; set; }
        public decimal B4 { get; set; }

        public Ctlrats(int id, int n, decimal a2, decimal a3, decimal a4, decimal d3, decimal d4, decimal dd2, decimal dd3, decimal b3, decimal b4)
        {
            Id = id;
            N = n;
            A2 = a2;
            A3 = a3;
            A4 = a4;
            D3 = d3;
            D4 = d4;
            Dd2 = dd2;
            Dd3 = dd3;
            B3 = b3;
            B4 = b4;
        }
    }
}
