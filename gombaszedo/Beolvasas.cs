using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gombaszedo
{
    class Beolvasas
    {
        public static string[] Beolvas()
        {
            StreamReader sr = new StreamReader("GOMBA.BE");
            string[] tomb = new string[SorokSzama()];
            int i = 0;
            while (!sr.EndOfStream)
            {
                tomb[i++] = sr.ReadLine();
            }
            sr.Close();
            return tomb;
        }

        static int SorokSzama()
        {
            int db = 0;
            StreamReader sr = new StreamReader("GOMBA.BE");
            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                db++;
            }
            sr.Close();
            return db;
        }

        public static int Allomanymeret()
        {
            string[] tomb = Beolvas();
            return int.Parse(tomb[0]);
        }

        public static int Hatizsakkapacitas()
        {
            string[] tomb = Beolvas();
            return int.Parse(tomb[1]);
        }
    }
}
