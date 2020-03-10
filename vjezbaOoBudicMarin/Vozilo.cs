using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaOoBudicMarin
{
    class Vozilo
    {
        private string vrsta; //vrsta vozila
        private double maxBrzina;//maximalna brzina vozila
        private int brojKotaca;//broj kotaca na vozilu
        public Vozilo()
        { }
        public void setVrsta(string vrsta)
        {
            this.vrsta = vrsta;
        }
        public string getVrsta()
        {
            return vrsta;
        }
        public void setMaxBrzina(int maxBrzina)
        {
            this.maxBrzina = maxBrzina;
        }
        public double getMaxBrzina()
        {
            return maxBrzina;
        }
        public void setBrojKotaca(int brojKotaca)
        {
            this.brojKotaca = brojKotaca;
        }
        public int getBrojKotaca()
        {
            return brojKotaca;
        }
        public override string ToString()
        {
            string poruka = "Vrsta: " + vrsta +
                "\nMaksinalna brzina: " + maxBrzina +
                "\nBroj kotača: " + brojKotaca;
            return poruka;
        }
    }
}
