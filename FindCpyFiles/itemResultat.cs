using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindCpyFiles
{
    class itemResultat
    {
        public itemResultat()
        {

        }

        public itemResultat(string n, bool t, string nf, int l, DateTime dm)
        {
            numFA = n;
            trouve = t;
            nomfichier = nf;
            ligne = ligne;
            dateModif = dm;
        }

        public string numFA { get; set; }
        public bool trouve { get; set; }
        public string nomfichier { get; set; }
        public int ligne{ get; set; }
        public DateTime dateModif { get; set; }

    }
}
