using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperModels
{
    public class Batman : ISuperhos, IMilliardos
    {
        private double lelemenyesseg;

        public Batman()
        {
            this.lelemenyesseg = 100;
        }

        public void KutyutKeszit()
        {
            this.lelemenyesseg += 50;
        }

        public double MekkoraAzEreje()
        {
            return this.lelemenyesseg * 2;
        }

        bool ISuperhos.LegyoziE(ISuperhos hos)
        {
            return hos.MekkoraAzEreje()<this.lelemenyesseg;
        }

        public override string? ToString()
        {
            return "Batman, a erőm " + this.MekkoraAzEreje()+", leleményességem "+this.lelemenyesseg+"!";
        }
    }
}
