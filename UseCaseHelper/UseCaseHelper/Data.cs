using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    class Data
    {
        //lijsten met actors en Cases
        public List<Actor> Actorlist = new List<Actor>();
        public List<Usecase> Caselist = new List<Usecase>();

        //Actor toevoegen
        public void addActor(int ID, string naam)
        {
            Actorlist.Add(new Actor(ID, naam));
        }
        //case toevoegen
        public void addCase(string n, string s, List<int> a ,string aa, string b, string u, string r)
        {
            int caseID = Caselist.Count + 1;
            Caselist.Add(new Usecase(caseID, n, s, a, aa, b, u, r));
        }
        //lijn "toevoegen"
        public void addLine(int actorID, string caseName)
        {
            LinkActorCase(actorID, getCaseID(caseName));
        }
        //lijn "verwijderen"
        public void removeLine(int actorID, string caseName)
        {
            foreach (Usecase item in Caselist)
            {
                if (item.CaseID == Convert.ToInt32(caseName))
                {
                    item.actoren.Remove(actorID);
                }
            }
        }
        //case ID achterhalen
        public int getCaseID(string caseNaam)
        {
            int ID = 0;
            foreach (Usecase item in Caselist)
            {
                if (caseNaam == "   " + item.naam + "   ")
                {
                    ID = item.CaseID;
                }
            }
            return ID;
        }
        //Actor aan Case linken
        public void LinkActorCase(int ActorID, int caseID)
        {
            foreach (Usecase item in Caselist)
            {
                if (item.CaseID == caseID)
                {
                    item.actoren.Add(ActorID);
               }
            }
        }
        //Actor naam achterhalen
        public string getActorName(int ActorID)
        {
            string naam = "";
            foreach (Actor item in Actorlist)
            {
                if (ActorID == item.ID)
                {
                    naam = item.naam;
                }
            }
            return naam;
        }
    }

}
