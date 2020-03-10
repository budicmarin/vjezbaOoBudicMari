using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaOoBudicMarin
{
    class Neboder
    {
        private int visina;
        private int brojKatova;
        

        public Neboder()
        {
            
        }
        public double Prosjek()
        {
            double prosjek;
            prosjek = (double)visina/ (double)brojKatova;
            return prosjek;
        }
        public void setVisina(int visina)
        {
            this.visina = visina;
        }
        public int getVisina()
        {
            return visina;
        }
        public void setBrojKatova(int brojKatova)
        {
            this.brojKatova = brojKatova;
        }
        public int getBrojKatova()
        {
            return brojKatova;
        }
        public override string ToString()
        {
            string poruka = "Prosječna visina kata je " + Prosjek() +" m" ;
            return poruka;
        }
    }
}
