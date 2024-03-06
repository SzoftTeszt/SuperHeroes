using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperModels
{
    public class Vasember : Bosszuallo, IMilliardos
    {
        public Vasember() : base(150, true)
        {}

        public override bool MegmentiAVilagot()
        {
            return this.MekkoraAzEreje() > 1000;
        }

        public void Feltamad() {
            this.Szuperero += 100;
        }

        void IMilliardos.KutyutKeszit()
        {
            this.Szuperero += new Random().NextDouble() * 10;
        }

        public override string? ToString()
        {
            return "Vasember, "+base.ToString();
        }
    }
}
