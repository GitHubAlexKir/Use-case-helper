using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    public class Usecase
    {
        public int CaseID;
        public string naam;
        public string samenvatting;
        public List<int> actoren;
        public string aannamen;
        public string beschrijving;
        public string uitzonderingen;
        public string resultaat;

        public Usecase(int ID, string naam,string samenvatting, List<int>actoren,string aannamen,string beschrijving, string uitzonderingen, string resultaat)
        {
            CaseID = ID;
            this.naam = naam;
            this.samenvatting = samenvatting;
            this.actoren = actoren;
            this.aannamen = aannamen;
            this.beschrijving = beschrijving;
            this.resultaat = resultaat;
            this.uitzonderingen = uitzonderingen;
        }
    }
}
