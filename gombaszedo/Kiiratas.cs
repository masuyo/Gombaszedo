using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gombaszedo
{
    class Kiiratas
    {
        public static void Kiirat(int ogsz, int ogs, int cssz, int css, int rgsz, int rgs, int lpsz, int lps)
        {
            StreamWriter sw = new StreamWriter("GOMBA.KI");
            sw.WriteLine(ogsz + " " + ogs);
            sw.WriteLine(cssz + " " + css);
            sw.WriteLine(rgsz + " " + rgs);
            sw.WriteLine(lpsz + " " + lps);
            sw.Close();
        }

        public static void Megszamlal(Gomba[] leszedett)
        {
            int ogsz = 0;
            int ogs = 0;
            int cssz = 0;
            int css = 0;
            int rgsz = 0;
            int rgs = 0;
            int lpsz = 0;
            int lps = 0;

            foreach (Gomba l in leszedett)
            {
                if (l != null)
                {
                    if (l.Gombafajta == 'C')
                    {
                        cssz++;
                        css += l.Gombameret;
                    }
                    if (l.Gombafajta == 'R')
                    {
                        rgsz++;
                        rgs += l.Gombameret;
                    }
                    if (l.Gombafajta == 'L')
                    {
                        lpsz++;
                        lps += l.Gombameret;
                    }
                    ogsz++;
                    ogs += l.Gombameret;
                }
            }
            Kiirat(ogsz, ogs, cssz, css, rgsz, rgs, lpsz, lps);
        }
    }
}
