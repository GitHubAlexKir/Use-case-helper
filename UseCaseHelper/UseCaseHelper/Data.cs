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

        public void addCase(int ID, string naam)
        {
            Caselist.Add(new Usecase());
        }

        public void LinkActorCase(int ActorID, string CaseText)
        {
            foreach (Usecase item in Caselist)
            {
               //if (item.Naam == CaseText)
               //{
               //    item.actors.Add(ActorID);
               //}
            }
        }
    }

}
