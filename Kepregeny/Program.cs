using SuperModels;
using System.Collections.Generic;

namespace Kepregeny 
{
    class Program
    {
        static List<ISuperhos> hosok = new List<ISuperhos>();

        static void Szuperhosok() {
            foreach (var hos in hosok)
            {
                Console.WriteLine(hos);
            }
        }
        static void Szereplok(string filepath) {

            string[] sorok ;
            try
            {
                sorok = File.ReadAllLines(filepath);

                foreach (var sor in sorok)
                {
                    var hos = sor.Split(" ");
                    if (hos[0] == "Vasember")
                    {
                        var szereplo = new Vasember();
                        for (int i = 0; i < Convert.ToInt32(hos[1]); i++)
                            szereplo.KutyutKeszit();
                        hosok.Add(szereplo);

                    }
                    else
                    {
                        var szereplo = new Batman();
                        for (int i = 0; i < Convert.ToInt32(hos[1]); i++)
                            szereplo.KutyutKeszit();
                        hosok.Add(szereplo);
                    }
                }


            }
            catch (Exception ex) {
                Console.WriteLine("Hiba a file beolvasásánál!");
                Console.WriteLine(ex);
            }              
               
            
          
        }

        static void Main(string[] args) {

            Szereplok("C:\\Adat\\hoseim.txt");
            Szuperhosok();
            if (hosok[0].LegyoziE(hosok[1]))
                Console.WriteLine("Vasember lenyomta!");
            else Console.WriteLine("Batman legyőzhetetlen!");
        }
    }
}
