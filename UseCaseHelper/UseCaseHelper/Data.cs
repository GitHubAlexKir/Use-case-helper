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
            int[] a = new int[3];
            Caselist.Add(new Usecase(caseID, n, s, a, aa, b, u, r));
        }

        public void addLine(int actorID, int caseID)
        {
            int lineID = Linelist.Count + 1;
            Linelist.Add(new Line(lineID, actorID, caseID));
        }

        public void LinkActorCase(int ActorID, string CaseText)
        {
            foreach (Usecase item in Caselist)
            {
                //if (item.Naam == CaseText)
                //{
                //    item.actors.Add(ActorID);
                //    addLine(ActorID, item.CaseID);
               //}
            }
        }

        internal void deleteCase(object naam, string v1, string v2, string v3, string v4, string v5)
        {
            //throw new NotImplementedException();
        }
    }

}
