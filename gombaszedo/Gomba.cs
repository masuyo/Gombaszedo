using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gombaszedo
{
    class Gomba
    {
        int gombameret;
        char gombafajta;

        public int Gombameret
        {
            get { return gombameret; }
        }

        public char Gombafajta
        {
            get { return gombafajta; }
        }

        public Gomba(char gombafajta, int gombameret) 
        {
            this.gombameret = gombameret;
            this.gombafajta = gombafajta;
        }

        //public string Kiiras()
        //{
        //    return gombafajta + " " + gombameret;
        //}

        public int Csiperkedb()
        {
            if (gombafajta == 'C') return 1;
            return 0;
        }
    }
}
