using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperModels
{
    public abstract class Bosszuallo : ISuperhos
    {
        private double szuperero;
        private bool vanEGyengesege;

        public double Szuperero { 
            get {
                return this.szuperero;
            } 
            set { 
                if (value>=0) this.szuperero = value; 
            }
        } 

        public bool VanEGyengesege
        {
            get { return this.vanEGyengesege; }
            set { this.vanEGyengesege = value; }
        }

        public Bosszuallo(double szuperero, bool vanEGyengesege)
        {
            Szuperero = szuperero;
            VanEGyengesege = vanEGyengesege;
        }

        public abstract bool MegmentiAVilagot();

        public double MekkoraAzEreje()
        {
            return this.Szuperero;
        }

        bool ISuperhos.LegyoziE(ISuperhos hos)
        {
            if (hos is Bosszuallo)
            {
                var ellenfel = ((Bosszuallo)hos);
                return (ellenfel.MekkoraAzEreje() < this.MekkoraAzEreje() && ellenfel.VanEGyengesege);
            }
            else {
                return false;
                
            }
                   
        }

        public override string? ToString()
        {
            return this.MekkoraAzEreje()+" az erőm és "+(this.VanEGyengesege?"van":"nincs")+" gyengeségem!";
        }
    }
    }

