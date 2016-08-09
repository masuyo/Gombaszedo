using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gombaszedo
{
    class RendezesekEsLeszedes
    {    
        //állomány sorbarendezése méret szerint
        public static Gomba[] AllomanyRendezeseMeret(Gomba[] gombaallomany)
        {
            Gomba temp;
            for (int i = 0; i < gombaallomany.Length; i++)
            {
                for (int k = i + 1; k < gombaallomany.Length; k++)
                {
                    if (gombaallomany[i].Gombameret < gombaallomany[k].Gombameret)
                    {
                        //csere
                        temp = gombaallomany[k];
                        gombaallomany[k] = gombaallomany[i];
                        gombaallomany[i] = temp;
                    }
                }
                //Console.WriteLine(gombaallomany[i].Kiiras()); 
            }
            return gombaallomany;
        }

        //állomány sorbarendezése fajta szerint
        public static Gomba[] AllomanyRendezeseFajta(Gomba[] gombaallomany)
        {
            Gomba temp;
            gombaallomany = AllomanyRendezeseMeret(gombaallomany);
            for (int i = 0; i < gombaallomany.Length; i++)
            {
                for (int k = i + 1; k < gombaallomany.Length; k++)
                {
                    if (gombaallomany[i].Gombameret == gombaallomany[k].Gombameret)
                    {
                        if (gombaallomany[i].Gombafajta == 'L' && gombaallomany[k].Gombafajta == 'R' || gombaallomany[i].Gombafajta == 'L' && gombaallomany[k].Gombafajta == 'C' || gombaallomany[i].Gombafajta == 'R' && gombaallomany[k].Gombafajta == 'C')
                        {
                            temp = gombaallomany[k];
                            gombaallomany[k] = gombaallomany[i];
                            gombaallomany[i] = temp;
                        }
                    }
                }
                //Console.WriteLine(gombaallomany[i].Kiiras());
            }
            return gombaallomany;
        }

        //Console.WriteLine("\n");
        //állomány leszedése a megadott feltételek szerint (amíg van az állományban csiperkegomba, nem lehet leszedni lila pereszkét)
        //az állomány leszedett gombáit nullázza
        public static Gomba[] Leszedes(Gomba[] gombaallomany, int csiperkedb, int hatizsakkapacitas)
        {
            int leszedettcsiperkedb = 0;
            int leszedettmennyiseg = 0;
            gombaallomany = AllomanyRendezeseFajta(gombaallomany);
            Gomba[] leszedett = new Gomba[Beolvasas.Allomanymeret()];
            int m = 0;
            for (int i = 0; i < gombaallomany.Length; i++)
            {
                if (leszedettcsiperkedb < csiperkedb && gombaallomany[i].Gombafajta != 'L' && leszedettmennyiseg < hatizsakkapacitas && ((leszedettmennyiseg + gombaallomany[i].Gombameret) <= hatizsakkapacitas))
                {
                    if (gombaallomany[i].Gombafajta == 'C') leszedettcsiperkedb++;
                    leszedett[m] = gombaallomany[i];
                    leszedettmennyiseg += gombaallomany[i].Gombameret;
                    gombaallomany[i] = null;
                    //Console.WriteLine(leszedett[m].Kiiras());
                    m++;
                }
            }

            //ha elfogytak a csiperkék, újranézi az állományt
            for (int i = 0; i < gombaallomany.Length; i++)
            {
                if (gombaallomany[i] != null)
                {
                    if (leszedettcsiperkedb == csiperkedb && leszedettmennyiseg < hatizsakkapacitas && ((leszedettmennyiseg + gombaallomany[i].Gombameret) <= hatizsakkapacitas))
                    {
                        leszedett[m] = gombaallomany[i];
                        leszedettmennyiseg += gombaallomany[i].Gombameret;
                        //Console.WriteLine(leszedett[m].Kiiras());
                        m++;
                    }
                }
            }
            return leszedett;
        }
    }
}
