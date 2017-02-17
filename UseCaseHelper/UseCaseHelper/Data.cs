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
    }

}
