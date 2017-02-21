using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    class Data
    {
        public List<Actor> Actorlist = new List<Actor>();
        public List<Usecase> Caselist = new List<Usecase>();

        public void addActor(int ID, string naam)
        {
            Actorlist.Add(new Actor(ID, naam));
        }
        public void addCase(string n, string s, List<int> a ,string aa, string b, string u, string r)
        {
            int caseID = Caselist.Count + 1;
            Caselist.Add(new Usecase(caseID, n, s, a, aa, b, u, r));
        }

        public void addLine(int actorID, string caseName)
        {
            LinkActorCase(actorID, getCaseID(caseName));
        }

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
