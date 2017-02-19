using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    class Usecase
    {
        public int CaseID;
        public string naam;
        public string samenvatting;
        public int[] actoren;
        public string aannamen;
        public string beschrijving;
        public string uitzonderingen;
        public string resultaat;

        public Usecase(int ID, string n,string s, int[]a,string aa,string b, string u, string r)
        {
            CaseID = ID;
            naam = n;
            samenvatting = s;
            actoren = a;
            aannamen = aa;
            beschrijving = b;
            resultaat = r;
            uitzonderingen = u;
        }
    }
}
