using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    class Usecase
    {
        public string naam;
        public string samenvatting;
        public int[] actoren;
        public string aannamen;
        public string beschrijving;
        public string resultaat;

        public Usecase(string n,string s, int[]a,string aa,string b, string r)
        {
            naam = n;
            samenvatting = s;
            actoren = a;
            aannamen = aa;
            beschrijving = b;
            resultaat = r;
        }
    }
}
