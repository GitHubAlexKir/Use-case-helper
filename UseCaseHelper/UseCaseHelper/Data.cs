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
        public List<Line> Linelist = new List<Line>();

        public void addActor(int ID, string naam)
        {
            Actorlist.Add(new Actor(ID, naam));
        }
        public void addCase(string n, string s, string aa, string b, string u, string r)
        {
            int caseID = Caselist.Count + 1;
            List<int> a = new List<int>();
            Caselist.Add(new Usecase(caseID, n, s, a, aa, b, u, r));
        }

        public void addLine(int actorID, string caseName)
        {
            int lineID = Linelist.Count + 1;
            Linelist.Add(new Line(lineID, actorID, getCaseID(caseName)));
            LinkActorCase(actorID, getCaseID(caseName));
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

        public void deleteCase(object naam, string v1, string v2, string v3, string v4, string v5)
        {
            //throw new NotImplementedException();
        }

        public void removeLine(int selectedActor, string selectedCase)
        {
            int caseID = Convert.ToInt32(selectedCase);
            List<Line> delete = new List<Line>();
            foreach (Line item in Linelist)
            {
                if (item.ActorID == selectedActor & item.CaseID == caseID)
                {
                    delete.Add(item);
                }
            }
            foreach (Line item2 in delete)
            {
                Linelist.Remove(item2);
            }
        }
    }

}
