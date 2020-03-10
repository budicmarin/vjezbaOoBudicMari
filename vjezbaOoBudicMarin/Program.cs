using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaOoBudicMarin
{
    class Program
    {
        static void Main(string[] args)
        {
            Neboder Tower = new Neboder();
            Tower.setVisina(200);
            Tower.setBrojKatova(100);
            Tower.setVisina(Tower.getVisina() + 10);
            Tower.setBrojKatova(Tower.getBrojKatova()+1);
            Console.WriteLine(Tower);
            Console.ReadKey();

            Vozilo Motor = new Vozilo();
            Motor.setVrsta("Motor");
            Motor.setBrojKotaca(2);
            Console.WriteLine("Upiši maksimalnu brzinu za motor");
            int brzina = Convert.ToInt32(Console.ReadLine());
            Motor.setMaxBrzina(brzina);
            Vozilo Auto = new Vozilo();
            Auto.setVrsta("Auto");
            Auto.setBrojKotaca(4);
            Auto.setMaxBrzina(Motor.getMaxBrzina+(Motor.getMaxBrzina()*0.3));

        }
    }
}
