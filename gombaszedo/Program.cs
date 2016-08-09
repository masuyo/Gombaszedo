using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gombaszedo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tomb = Beolvasas.Beolvas();
            Gomba[] gombaallomany = new Gomba[Beolvasas.Allomanymeret()];
            string[] t;
            char gombafajta;
            int gombameret;
            for (int i = 0; i < tomb.Length - 2; i++)
            {
                t = tomb[i + 2].Split(' ');
                gombafajta = char.Parse(t[0]);
                gombameret = int.Parse(t[1]);
                Gomba g = new Gomba(gombafajta, gombameret);
                gombaallomany[i] = g;
            }

            int hatizsakkapacitas = Beolvasas.Hatizsakkapacitas();
            int csiperkedb = 0;
            int j = 0;

            foreach (Gomba g in gombaallomany)
            {
                csiperkedb += gombaallomany[j].Csiperkedb();
                j++;
            }

            Gomba[] leszedett = RendezesekEsLeszedes.Leszedes(gombaallomany, csiperkedb, hatizsakkapacitas);
            Kiiratas.Megszamlal(leszedett);
        }
    }
}
